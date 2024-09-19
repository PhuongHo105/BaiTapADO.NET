using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DTO
{
    public abstract class CCattle
    {
        int quantity;
        public int Quantity { get { return quantity; } set { quantity = value; } }
        int maxMilk;
        public int MaxMilk { get { return maxMilk; } set { maxMilk = value; } }
        string cry;
        public string SCry { get { return cry; } set { cry = value; } }
        public abstract string Cry();
        public abstract int GiveMilk();
        public abstract void GiveBirth();
        public abstract int getType();//0-cow, 1-sheep, 2-goat
    }
}
