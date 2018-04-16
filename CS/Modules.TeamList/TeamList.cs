using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modules.Infrastructure;

namespace Modules.TeamList {
    public class TeamList {
        static TeamList() {
            Teams = Modules.Infrastructure.TeamList.CreateSampleData();
        }
        public static List<Team> Teams;
    }
}
