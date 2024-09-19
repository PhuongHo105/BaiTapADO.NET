using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DTO
{
    public class CSheep : CCattle
    {
        public CSheep (int quantity, CSheep c)
        {
            this.Quantity = quantity;
            this.MaxMilk = c.MaxMilk;
            this.SCry = c.SCry;
        }
        public CSheep(DataRow row)
        {
            this.MaxMilk = int.Parse(row["max_Milk"].ToString());
            this.SCry = row["cry"].ToString();
        }

        
        public override string Cry()
        {
            return this.SCry;
        }

        
        public override int getType()
        {
            return 1;
        }

        public override void GiveBirth()
        {
            if (Quantity != 0)
                Quantity += 1;
        }

        public override int GiveMilk()
        {
            Random random = new Random();
            return (int)random.Next(0, MaxMilk + 1);
        }
    }
}
