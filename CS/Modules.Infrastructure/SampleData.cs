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
using System.Windows.Media;
using System.Collections;
using System.Windows.Media.Imaging;

namespace Modules.Infrastructure {
    public class TeamList : DependencyObject {
        public static List<Team> CreateSampleData() {

            Person lead1 = new Person() { Email = "team1@team.com", FirstName = "John", LastName = "Doe", Phone = "111-2222", Icq = "77-77-77", JobTitle = "Team lead", Photo = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative)) };
            Person lead2 = new Person() { Email = "team2@team.com", FirstName = "Jane", LastName = "Doe", Phone = "222-3333", Icq = "88-88-88", JobTitle = "Team lead", Photo = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative)) };

            Person person1 = new Person() { JobTitle = "Developer", FirstName = "James", LastName = "Sheppard", Icq = "11-11-11" };
            Person person2 = new Person() { JobTitle = "Designer", FirstName = "Kate", LastName = "Locke", Icq = "22-22-22" };
            Person person3 = new Person() { JobTitle = "Developer", FirstName = "Clarie", LastName = "Ford", Icq = "33-33-33" };
            Person person4 = new Person() { JobTitle = "Developer", FirstName = "Jack", LastName = "Littleton", Icq = "44-44-44" };
            Person person5 = new Person() { JobTitle = "Designer", FirstName = "Hugo", LastName = "Pace", Icq = "55-55-55" };

            Project project1 = new Project("Project 1") { BugsTotal = 15, IssuesTotal = 26 };
            project1.IssuesData.AddRange(new Point[] { new Point(0, 58), new Point(1, 63), new Point(2, 40), new Point(3, 44), new Point(4, 26) });
            project1.BugsData.AddRange(new Point[] { new Point(0, 10), new Point(1, 20), new Point(2, 19), new Point(3, 13), new Point(4, 15) });
            Project project2 = new Project("Project 2") { BugsTotal = 20, IssuesTotal = 40 };
            project2.IssuesData.AddRange(new Point[] { new Point(0, 18), new Point(1, 12), new Point(2, 42), new Point(3, 35), new Point(4, 40) });
            project2.BugsData.AddRange(new Point[] { new Point(0, 9), new Point(1, 6), new Point(2, 20), new Point(3, 13), new Point(4, 20) });
            Project project3 = new Project("Project 3") { BugsTotal = 9, IssuesTotal = 20 };
            project3.IssuesData.AddRange(new Point[] { new Point(0, 18), new Point(1, 44), new Point(2, 30), new Point(3, 25), new Point(4, 20) });
            project3.BugsData.AddRange(new Point[] { new Point(0, 8), new Point(1, 13), new Point(2, 11), new Point(3, 9), new Point(4, 9) });
            Project project4 = new Project("Project 4") { BugsTotal = 15, IssuesTotal = 26 };
            project4.IssuesData.AddRange(new Point[] { new Point(0, 58), new Point(1, 63), new Point(2, 40), new Point(3, 44), new Point(4, 26) });
            project4.BugsData.AddRange(new Point[] { new Point(0, 10), new Point(1, 20), new Point(2, 19), new Point(3, 13), new Point(4, 15) });

            Team team1 = new Team() { TeamName = "Team 1" };
            team1.TeamLead = lead1;
            team1.Projects = new List<Project>();
            team1.Projects.AddRange(new Project[] { project1, project2 });
            team1.Staff = new List<Person>();
            team1.Staff.AddRange(new Person[] { lead1, person1, person2 });

            Team team2 = new Team() { TeamName = "Team 2" };
            team2.TeamLead = lead2;
            team2.Projects = new List<Project>();
            team2.Projects.AddRange(new Project[] { project3, project4 });
            team2.Staff = new List<Person>();
            team2.Staff.AddRange(new Person[] { lead2, person3, person4, person5 });

            List<Team> list = new List<Team>();
            list.AddRange(new Team[] { team1, team2 });
            return list;
        }
    }

    public class Team : DependencyObject {

        public static readonly DependencyProperty TeamNameProperty;
        public static readonly DependencyProperty TeamLeadProperty;
        public static readonly DependencyProperty ProjectsProperty;
        public static readonly DependencyProperty StaffProperty;

        static Team() {
            Type ownerType = typeof(Team);
            TeamNameProperty = DependencyProperty.Register("TeamName", typeof(String), ownerType);
            TeamLeadProperty = DependencyProperty.Register("TeamLead", typeof(Person), ownerType);
            ProjectsProperty = DependencyProperty.Register("Projects", typeof(List<Project>), ownerType);
            StaffProperty = DependencyProperty.Register("Staff", typeof(List<Person>), ownerType);
        }

        public String TeamName {
            get { return (String)GetValue(TeamNameProperty); }
            set { SetValue(TeamNameProperty, value); }
        }
        public Person TeamLead {
            get { return (Person)GetValue(TeamLeadProperty); }
            set { SetValue(TeamLeadProperty, value); }
        }
        public List<Project> Projects {
            get { return (List<Project>)GetValue(ProjectsProperty); }
            set { SetValue(ProjectsProperty, value); }
        }
        public List<Person> Staff {
            get { return (List<Person>)GetValue(StaffProperty); }
            set { SetValue(StaffProperty, value); }
        }
    }

    public class Person {
        public String JobTitle { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public ImageSource Photo { get; set; }
        public String Icq { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
    }
    public class Project : DependencyObject {
        public static readonly DependencyProperty BugsDataProperty;
        public static readonly DependencyProperty IssuesDataProperty;

        static Project() {
            Type ownerType = typeof(Team);
            BugsDataProperty = DependencyProperty.Register("BugsData", typeof(ArrayList), ownerType);
            IssuesDataProperty = DependencyProperty.Register("IssuesData", typeof(ArrayList), ownerType);
        }

        public String Title { get; set; }
        public int IssuesTotal { get; set; }
        public int BugsTotal { get; set; }
        public ArrayList BugsData {
            get { return (ArrayList)GetValue(BugsDataProperty); }
            set { SetValue(BugsDataProperty, value); }
        }
        public ArrayList IssuesData {
            get { return (ArrayList)GetValue(IssuesDataProperty); }
            set { SetValue(IssuesDataProperty, value); }
        }
        public Project(String Title) {
            this.Title = Title;
            IssuesData = new ArrayList();
            BugsData = new ArrayList();
        }
    }

}
