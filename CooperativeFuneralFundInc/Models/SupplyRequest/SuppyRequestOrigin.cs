using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.SupplyRequest
{
    public class SuppyRequestOrigin
    {
        public int SuppyRequestOriginId { get; set; }
        public string SuppyRequestOriginName { get; set; }

        public static implicit operator SuppyRequestOrigin(int v)
        {
            throw new NotImplementedException();
        }
    }
}
