﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Gtd.Client.Models;

namespace Gtd.Client.Views.Navigation
{
    public sealed class NavigationController : 
        IHandle<AppInit>, 
        IHandle<Dumb.ClientModelLoaded>,
        IHandle<Dumb.StuffAddedToInbox>, 
        IHandle<Dumb.StuffRemovedFromInbox>,
        IHandle<Dumb.ProjectAdded>, 
        IHandle<Dumb.ActionAdded>, 
        IHandle<Dumb.ActionUpdated>,
    IHandle<UI.FilterChanged>,
        IHandle<UI.ProjectDisplayed>,
        IHandle<UI.InboxDisplayed>

    {
        readonly NavigationView _tree;
        readonly Region _region;
        readonly IPublisher _queue;
        readonly ClientPerspective _perspective;
        

        bool _loaded;

        NavigationController(Region region, IPublisher queue, ClientPerspective perspective)
        {
            _tree = new NavigationView(this);
            _region = region;
            _queue = queue;
            _perspective = perspective;
        }

        public static NavigationController Wire(Region control, IPublisher queue, ISubscriber bus, ClientPerspective view)
        {
            var adapter  = new NavigationController(control, queue, view);

            bus.Subscribe<AppInit>(adapter);
            bus.Subscribe<Dumb.StuffAddedToInbox>(adapter);
            bus.Subscribe<Dumb.StuffRemovedFromInbox>(adapter);
            bus.Subscribe<Dumb.ProjectAdded>(adapter);
            bus.Subscribe<Dumb.ActionAdded>(adapter);
            bus.Subscribe<Dumb.ClientModelLoaded>(adapter);
            bus.Subscribe<UI.FilterChanged>(adapter);
            bus.Subscribe<Dumb.ActionUpdated>(adapter);

            bus.Subscribe<UI.InboxDisplayed>(adapter);
            bus.Subscribe<UI.ProjectDisplayed>(adapter);

            return adapter ;
        }

        public void Handle(AppInit message)
        {
            _region.RegisterDock(_tree, "nav-tree");
            _region.SwitchTo("nav-tree");
        }

        

        void ReloadInboxNode(int count)
        {
            _tree.AddOrUpdateNode("inbox",string.Format("Inbox ({0})", count), NodeType.Inbox);
        }

        

        public void Handle(Dumb.StuffAddedToInbox message)
        {
            
            Sync(() => ReloadInboxNode(message.InboxCount));
        }

        public void Handle(Dumb.StuffRemovedFromInbox message)
        {
            Sync(() => ReloadInboxNode(message.InboxCount));
        }

        void Sync(Action act)
        {
            if (_tree.InvokeRequired)
            {
                _tree.Invoke(act);
                return;
            }
            act();
        }

        public void Handle(Dumb.ClientModelLoaded message)
        {
            _loaded = true;

            Sync(LoadNavigation);

        }

        public void Handle(UI.FilterChanged message)
        {
            if (!_loaded) return;
            Sync(LoadNavigation);
        }

        public void Handle(Dumb.ProjectAdded message)
        {
            if (!_loaded)
                return;

            ReloadProjectNode(message.ProjectId);
        }

        void ReloadProjectNode(ProjectId projectId)
        {
            AddOrUpdateProject(_perspective.Model.GetProjectOrNull(projectId));
        }

        public void Handle(Dumb.ActionAdded message)
        {
            ReloadProjectNode(message.Action.ProjectId);
        }

        public void Handle(Dumb.ActionUpdated message)
        {
            ReloadProjectNode(message.Action.ProjectId); 
        }

        void AddOrUpdateProject(ImmutableProject model)
        {
            _nodes[model.Info.UIKey] = model.Info.ProjectId;
            Sync(() => _tree.AddOrUpdateNode(model.Info.UIKey, model.Info.Outcome, NodeType.Project));
        }


        void LoadNavigation()
        {
            _tree.Clear();
            var format = string.Format("Inbox ({0})", _perspective.Model.GetTheNumberOfItemsOfStuffInInbox());
            _tree.AddOrUpdateNode("inbox", format, NodeType.Inbox);
            foreach (var project in _perspective.ListProjects())
            {
                AddOrUpdateProject(project);
            }
        }

        readonly IDictionary<string,object> _nodes = new Dictionary<string, object>();


        string _currentNode;
        public void WhenNodeSelected(string tag)
        {
            if (_currentNode == tag)
                return;

            _currentNode = tag;
            if (tag == "inbox")
            {
                _queue.Publish(new UI.DisplayInbox());
                return;
            }
            var node = _nodes[tag];

            if (node is ProjectId)
            {
                _queue.Publish(new UI.DisplayProject((ProjectId) node));
            }
        }

        public void Handle(UI.ProjectDisplayed message)
        {
            if (_currentNode == message.Project.UIKey)
                return;

            _currentNode = message.Project.UIKey;
            Sync(() => _tree.UpdateSelectionIfNeeded(message.Project.UIKey));
        }

        public void Handle(UI.InboxDisplayed message)
        {
            if (_currentNode == "inbox")
                return;

            _currentNode = "inbox";
            Sync(() => _tree.UpdateSelectionIfNeeded("inbox"));
        }
    }



    public interface IFormCommand
    {
        
    }
}