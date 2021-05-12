using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.TasksManagement
{
    public class ListTaskNotes
    {
        public int ListTaskNotesId { get; set; }

        public TaskManagement TaskManagement { get; set; }

        public string Note { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Archived { get; set; }
    }
}
