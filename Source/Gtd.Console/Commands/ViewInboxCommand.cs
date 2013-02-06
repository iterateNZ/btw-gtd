using Gtd.Shell.LesserEvils;

namespace Gtd.Shell.Commands
{
    class ViewInboxCommand : IConsoleCommand
    {
        public string Usage { get { return "inbox"; } }
        public void Execute(ConsoleEnvironment env, string[] args)
        {
            if (!env.InboxView.TenantInboxes.ContainsKey(env.Id))
            {
                env.Log.Error("Tenant not defined");
                return;
            }
            var entries = env.InboxView.TenantInboxes[env.Id];
            env.Log.Info("Inbox ({0} records)", env.Id.Id, entries.Count);

            
            foreach (var entry in entries)
            {
                var shortId = entry.ItemId.ToString().ToLowerInvariant().Replace("-", "").Substring(0, 3);
                env.Log.Info(string.Format("  {0}  {1, -60}  {2,10}", shortId, entry.Subject, FormatEvil.TwitterOffestUtc(entry.Added)));
            }
        }
    }
}