using System.Collections.Generic;
using Gtd.Shell.Projections;

namespace Gtd.Shell.Filters
{
    public sealed class AllActionsFilter : IFilterCriteria
    {
        public IEnumerable<ActionView> FilterActions(ProjectView view)
        {
            return view.Actions;
        }

        public string Title { get { return "All actions"; } }
        public string Description { get { return "includes completed and archived items"; } }

        public string FormatActionCount(int actionCount)
        {
            return string.Format("{0} total", actionCount);
        }
    }
}