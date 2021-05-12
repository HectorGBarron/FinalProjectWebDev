using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.ClientManagement
{
    public class ListClientContacts
    {
        public int ListClientContactsID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public Client Client { get; set; }
    }
}
