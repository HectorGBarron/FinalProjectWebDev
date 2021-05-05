using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CooperativeFuneralFundInc.Models.SupplyRequest;

namespace CooperativeFuneralFundInc.Models.TaskManagement
{
    public class TaskManagement
    {

        public int TaskId { get; set; }
        public int StatusID { get; set; }
        public Status StatusName { get; set; }

        public string Owner { get; set; }
        public string RelatedTo { get; set; }
        public string RelatedToName { get; set; }
        public string TaskType { get; set; }
        public int Priority { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}