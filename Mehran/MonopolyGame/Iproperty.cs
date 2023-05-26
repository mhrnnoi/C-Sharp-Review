using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public interface Iproperty
    {
        public int Price { get; set; }
        public int Rent { get; set; }
        public string Name { get; set; }
        public Player Owner { get; set; }

        
        void Mortgage();
        void UnMortgage();
        void SetOwner();


    }
}