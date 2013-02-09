using Gtd.Shell.Projections;

namespace Gtd.Shell.Commands
{
    class ListProjectsCommand : IConsoleCommand
    {
        public string[] Key { get { return new string[] {"list", "ls"};} }
        public string Usage { get { return @"list
    Return list of all projects available"; } }

        public void Execute(ConsoleEnvironment env, string[] args)
        {
            if (args.Length == 0)
            {
                ListProjects(env);
            }
            else if (args.Length == 1)
            {
                var projectMatch = args[0];
                ListActionsInProject(env, projectMatch);
            }
        }

        static void ListActionsInProject(ConsoleEnvironment env, string projectMatch)
        {
            var project = env.Session.MatchProject(projectMatch);
            env.Log.Info("Project: {0} ({1} actions)", project.Outcome, project.Actions.Count);

            foreach (var action in project.Actions)
            {
                var guid = action.Id.Id;
                var shortId = guid.ToString().ToLowerInvariant().Replace("-", "").Substring(0, 3);
                env.Log.Info(string.Format("  {0}  {1,-60}", shortId, action.Outcome));
            }
        }

        static void ListProjects(ConsoleEnvironment env)
        {
            var system = env.Session.GetCurrentSystem();
            var projects = system.ProjectList;
            env.Log.Info("Projects ({0} records)", projects.Count);

            foreach (var entry in projects)
            {
                var guid = entry.ProjectId.Id;

                var shortId = guid.ToString().ToLowerInvariant().Replace("-", "").Substring(0, 3);
                env.Log.Info(string.Format("  {0} ({2}) {1, -60}", shortId, entry.Outcome, entry.Actions.Count));
            }
        }
    }
}