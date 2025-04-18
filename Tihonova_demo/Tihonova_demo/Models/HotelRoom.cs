using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tihonova_demo.Models
{
    public partial class HotelRoom
    {
        public HotelRoom()
        {
            ContractCientRoom = new HashSet<ContractCientRoom>();
        }

        public int HotelRoomId { get; set; }
        public string HotelRoomDescription { get; set; }
        public int? Ground { get; set; }
        public decimal Price { get; set; }
        public int? CountSeats { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContractCientRoom> ContractCientRoom { get; set; }
    }
}
