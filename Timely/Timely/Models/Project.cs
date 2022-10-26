using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timely.Models
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime ProjectStartTime { get; set; }
        public DateTime ProjectEndTime { get; set; }
        public string ProjectName { get; set; }
        public int ProjectDuration { get; set; }

        public Project()
        {

        }
    }
}
