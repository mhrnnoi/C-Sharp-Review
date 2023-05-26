using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public interface IBuilder
    {
        public int HousePrice { get; set; }
        public bool IsCheck { get; set; }
        void BuyHouse();
        void BuyHotel();
        void SellHotel();
        void SellHouse();
        void CheckSet();
        
    }
}