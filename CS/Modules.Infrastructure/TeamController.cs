// Developer Express Code Central Example:
// Using DXDocking for WPF in accordance with Composite Application Guidelines
// 
// This example contains a DXDocking (http://devexpress.com/DXDocking) to Prism
// (http://www.codeplex.com/CompositeWPF) adapter that allows you to use the
// DXDocking for WPF in your composite applications.
// The sample for version
// v10.2.5 supports Prism 4
// 
// See Also:
// Prism: patterns & practices Composite
// Application Guidance for WPF and Silverlight site
// (http://compositewpf.codeplex.com/)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1926

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Modules.Infrastructure {

    public class TeamController : DependencyObject {
        public static readonly DependencyProperty SelectedTeamProperty;
        public static readonly DependencyProperty SelectedProjectProperty;
        static TeamController() {
            Controller = new TeamController();
            Type ownerType = typeof(TeamController);
            SelectedTeamProperty = DependencyProperty.Register("SelectedTeam", typeof(Team), ownerType);
            SelectedProjectProperty = DependencyProperty.Register("SelectedProject", typeof(Project), ownerType);
        }
        public Team SelectedTeam {
            get { return (Team)GetValue(SelectedTeamProperty); }
            set { SetValue(SelectedTeamProperty, value); }
        }
        public Project SelectedProject {
            get { return (Project)GetValue(SelectedProjectProperty); }
            set { SetValue(SelectedProjectProperty, value); }
        }
        public static TeamController Controller { get; private set; }
    }
}
