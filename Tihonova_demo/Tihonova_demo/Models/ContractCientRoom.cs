using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tihonova_demo.Models
{
    public partial class ContractCientRoom
    {
        public int ContractCientRoomId { get; set; }
        public int? ClientId { get; set; }
        public int? HotelRoomId { get; set; }
        public DateTime? DateContract { get; set; }
        public DateTime? DateImp { get; set; }
        public DateTime? DateExp { get; set; }
        public decimal? Sum { get; set; }

        public void CalculateSum()
        {
            decimal Pay = 0;
            Pay = Tihonova_demoContext.GetContext().HotelRoom.Where(h => h.HotelRoomId == HotelRoomId).Sum(p => p.Price * Convert.ToDecimal(DateExp - DateImp));
            Sum = Pay;
        } 

        public virtual Client Client { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
