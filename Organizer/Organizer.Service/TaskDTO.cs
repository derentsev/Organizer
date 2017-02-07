using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service
{
    public class TaskDTO
    {        
        public string TaskTitle { get; set; }
        public string TaskSubject { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public DateTime TaskCreationDate { get; set; }
        public int CreatorID { get; set; }
        //TaskPriority is tinyint in Database
        public int TaskPriority { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFinished { get; set; }
    }
}
