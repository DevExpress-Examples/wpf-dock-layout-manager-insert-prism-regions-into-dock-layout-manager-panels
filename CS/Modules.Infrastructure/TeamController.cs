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
