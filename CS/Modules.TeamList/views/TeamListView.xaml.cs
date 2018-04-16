using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modules.Infrastructure;

namespace Modules.TeamList {
    /// <summary>
    /// Interaction logic for TeamListView.xaml
    /// </summary>
    public partial class TeamListView : UserControl {
        public TeamListView() {
            InitializeComponent();
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            TeamController.Controller.SelectedTeam = (Team)e.AddedItems[0];
        }
    }
}
