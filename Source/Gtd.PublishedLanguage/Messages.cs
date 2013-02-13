using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMember.Local
namespace Gtd
{
    #region Generated by Lokad Code DSL
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class TrustedSystemCreated : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        
        TrustedSystemCreated () {}
        public TrustedSystemCreated (TrustedSystemId id)
        {
            Id = id;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class CaptureThought : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid RequestId { get; private set; }
        [DataMember(Order = 3)] public string Thought { get; private set; }
        
        CaptureThought () {}
        public CaptureThought (TrustedSystemId id, Guid requestId, string thought)
        {
            Id = id;
            RequestId = requestId;
            Thought = thought;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ThoughtCaptured : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid ThoughtId { get; private set; }
        [DataMember(Order = 3)] public string Thought { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ThoughtCaptured () {}
        public ThoughtCaptured (TrustedSystemId id, Guid thoughtId, string thought, DateTime timeUtc)
        {
            Id = id;
            ThoughtId = thoughtId;
            Thought = thought;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ArchiveThought : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid ThoughtId { get; private set; }
        
        ArchiveThought () {}
        public ArchiveThought (TrustedSystemId id, Guid thoughtId)
        {
            Id = id;
            ThoughtId = thoughtId;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ThoughtArchived : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid ThoughtId { get; private set; }
        [DataMember(Order = 3)] public DateTime TimeUtc { get; private set; }
        
        ThoughtArchived () {}
        public ThoughtArchived (TrustedSystemId id, Guid thoughtId, DateTime timeUtc)
        {
            Id = id;
            ThoughtId = thoughtId;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class DefineAction : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid RequestId { get; private set; }
        [DataMember(Order = 3)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 4)] public string Outcome { get; private set; }
        
        DefineAction () {}
        public DefineAction (TrustedSystemId id, Guid requestId, ProjectId projectId, string outcome)
        {
            Id = id;
            RequestId = requestId;
            ProjectId = projectId;
            Outcome = outcome;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionDefined : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 4)] public string Outcome { get; private set; }
        [DataMember(Order = 5)] public DateTime TimeUtc { get; private set; }
        
        ActionDefined () {}
        public ActionDefined (TrustedSystemId id, ActionId actionId, ProjectId projectId, string outcome, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            ProjectId = projectId;
            Outcome = outcome;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class DefineProject : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid RequestId { get; private set; }
        [DataMember(Order = 3)] public string ProjectOutcome { get; private set; }
        
        DefineProject () {}
        public DefineProject (TrustedSystemId id, Guid requestId, string projectOutcome)
        {
            Id = id;
            RequestId = requestId;
            ProjectOutcome = projectOutcome;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ProjectDefined : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 3)] public string ProjectOutcome { get; private set; }
        [DataMember(Order = 4)] public ProjectType Type { get; private set; }
        [DataMember(Order = 5)] public DateTime TimeUtc { get; private set; }
        
        ProjectDefined () {}
        public ProjectDefined (TrustedSystemId id, ProjectId projectId, string projectOutcome, ProjectType type, DateTime timeUtc)
        {
            Id = id;
            ProjectId = projectId;
            ProjectOutcome = projectOutcome;
            Type = type;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class DefineSingleActionProject : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid RequestId { get; private set; }
        [DataMember(Order = 3)] public Guid ThoughtId { get; private set; }
        
        DefineSingleActionProject () {}
        public DefineSingleActionProject (TrustedSystemId id, Guid requestId, Guid thoughtId)
        {
            Id = id;
            RequestId = requestId;
            ThoughtId = thoughtId;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ChangeProjectType : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 3)] public ProjectType Type { get; private set; }
        
        ChangeProjectType () {}
        public ChangeProjectType (TrustedSystemId id, ProjectId projectId, ProjectType type)
        {
            Id = id;
            ProjectId = projectId;
            Type = type;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ProjectTypeChanged : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 3)] public ProjectType Type { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ProjectTypeChanged () {}
        public ProjectTypeChanged (TrustedSystemId id, ProjectId projectId, ProjectType type, DateTime timeUtc)
        {
            Id = id;
            ProjectId = projectId;
            Type = type;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionAssignedToProject : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId NewProject { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ActionAssignedToProject () {}
        public ActionAssignedToProject (TrustedSystemId id, ActionId actionId, ProjectId newProject, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            NewProject = newProject;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionRemovedFromProject : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId OldProject { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ActionRemovedFromProject () {}
        public ActionRemovedFromProject (TrustedSystemId id, ActionId actionId, ProjectId oldProject, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            OldProject = oldProject;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionMovedToProject : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId OldProject { get; private set; }
        [DataMember(Order = 4)] public ProjectId NewProject { get; private set; }
        [DataMember(Order = 5)] public DateTime TimeUtc { get; private set; }
        
        ActionMovedToProject () {}
        public ActionMovedToProject (TrustedSystemId id, ActionId actionId, ProjectId oldProject, ProjectId newProject, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            OldProject = oldProject;
            NewProject = newProject;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ArchiveAction : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        
        ArchiveAction () {}
        public ArchiveAction (TrustedSystemId id, ActionId actionId)
        {
            Id = id;
            ActionId = actionId;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionArchived : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ActionArchived () {}
        public ActionArchived (TrustedSystemId id, ActionId actionId, ProjectId projectId, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            ProjectId = projectId;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class CompleteAction : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        
        CompleteAction () {}
        public CompleteAction (TrustedSystemId id, ActionId actionId)
        {
            Id = id;
            ActionId = actionId;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionCompleted : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 4)] public string ActionOutcome { get; private set; }
        [DataMember(Order = 5)] public DateTime TimeUtc { get; private set; }
        
        ActionCompleted () {}
        public ActionCompleted (TrustedSystemId id, ActionId actionId, ProjectId projectId, string actionOutcome, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            ProjectId = projectId;
            ActionOutcome = actionOutcome;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ChangeActionOutcome : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public string Outcome { get; private set; }
        
        ChangeActionOutcome () {}
        public ChangeActionOutcome (TrustedSystemId id, ActionId actionId, string outcome)
        {
            Id = id;
            ActionId = actionId;
            Outcome = outcome;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ActionOutcomeChanged : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ActionId ActionId { get; private set; }
        [DataMember(Order = 3)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 4)] public string ActionOutcome { get; private set; }
        [DataMember(Order = 5)] public DateTime TimeUtc { get; private set; }
        
        ActionOutcomeChanged () {}
        public ActionOutcomeChanged (TrustedSystemId id, ActionId actionId, ProjectId projectId, string actionOutcome, DateTime timeUtc)
        {
            Id = id;
            ActionId = actionId;
            ProjectId = projectId;
            ActionOutcome = actionOutcome;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ChangeProjectOutcome : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 3)] public string Outcome { get; private set; }
        
        ChangeProjectOutcome () {}
        public ChangeProjectOutcome (TrustedSystemId id, ProjectId projectId, string outcome)
        {
            Id = id;
            ProjectId = projectId;
            Outcome = outcome;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ProjectOutcomeChanged : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public ProjectId ProjectId { get; private set; }
        [DataMember(Order = 3)] public string ProjectOutcome { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ProjectOutcomeChanged () {}
        public ProjectOutcomeChanged (TrustedSystemId id, ProjectId projectId, string projectOutcome, DateTime timeUtc)
        {
            Id = id;
            ProjectId = projectId;
            ProjectOutcome = projectOutcome;
            TimeUtc = timeUtc;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ChangeThoughtSubject : Command, ITrustedSystemCommand
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid ThoughtId { get; private set; }
        [DataMember(Order = 3)] public string Subject { get; private set; }
        
        ChangeThoughtSubject () {}
        public ChangeThoughtSubject (TrustedSystemId id, Guid thoughtId, string subject)
        {
            Id = id;
            ThoughtId = thoughtId;
            Subject = subject;
        }
    }
    [DataContract(Namespace = "BTW2/GTD")]
    public partial class ThoughtSubjectChanged : Event, ITrustedSystemEvent
    {
        [DataMember(Order = 1)] public TrustedSystemId Id { get; private set; }
        [DataMember(Order = 2)] public Guid ThoughtId { get; private set; }
        [DataMember(Order = 3)] public string Subject { get; private set; }
        [DataMember(Order = 4)] public DateTime TimeUtc { get; private set; }
        
        ThoughtSubjectChanged () {}
        public ThoughtSubjectChanged (TrustedSystemId id, Guid thoughtId, string subject, DateTime timeUtc)
        {
            Id = id;
            ThoughtId = thoughtId;
            Subject = subject;
            TimeUtc = timeUtc;
        }
    }
    
    public interface ITrustedSystemApplicationService
    {
        void When(CaptureThought c);
        void When(ArchiveThought c);
        void When(DefineAction c);
        void When(DefineProject c);
        void When(DefineSingleActionProject c);
        void When(ChangeProjectType c);
        void When(ArchiveAction c);
        void When(CompleteAction c);
        void When(ChangeActionOutcome c);
        void When(ChangeProjectOutcome c);
        void When(ChangeThoughtSubject c);
    }
    
    public interface ITrustedSystemState
    {
        void When(TrustedSystemCreated e);
        void When(ThoughtCaptured e);
        void When(ThoughtArchived e);
        void When(ActionDefined e);
        void When(ProjectDefined e);
        void When(ProjectTypeChanged e);
        void When(ActionAssignedToProject e);
        void When(ActionRemovedFromProject e);
        void When(ActionMovedToProject e);
        void When(ActionArchived e);
        void When(ActionCompleted e);
        void When(ActionOutcomeChanged e);
        void When(ProjectOutcomeChanged e);
        void When(ThoughtSubjectChanged e);
    }
    #endregion
}
