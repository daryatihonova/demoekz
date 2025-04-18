using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tihonova_demo.Models
{
    public partial class Client
    {
        public Client()
        {
            ContractCientRoom = new HashSet<ContractCientRoom>();
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public DateTime? DateBirthday { get; set; }
        public double? Serya { get; set; }
        public double? Number { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Home { get; set; }
        public string Flat { get; set; }
        public string BonusCard { get; set; }

        public virtual ICollection<ContractCientRoom> ContractCientRoom { get; set; }
    }
}
