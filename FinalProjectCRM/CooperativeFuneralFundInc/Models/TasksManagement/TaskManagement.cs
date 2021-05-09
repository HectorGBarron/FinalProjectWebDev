using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CooperativeFuneralFundInc.Models.DropDownMenu;

namespace CooperativeFuneralFundInc.Models.TasksManagement
{
    public class TaskManagement
    {

        public int TaskManagementId { get; set; }
        public int StatusID { get; set; }
        public Status StatusName { get; set; }

        public int OwnerID { get; set; }
        public Owner OwnerName { get; set; }
        public string RelatedTo { get; set; }
        public string RelatedToName { get; set; }

        public int RequestTypeID { get; set; }
        public RequestType RequestTypeDescription { get; set; }

        public int Priority { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}