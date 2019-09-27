using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StandardApp.Models;
namespace StandardApp.ViewModels
{
    public class StateDept
    {
        public StateMaster State { get; set; }
        public DeptMaster Dept { get; set; }
        public List<StateMaster> States { get; set; }
        public List<DeptMaster> Depts { get; set; }
    }
}
