using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;

namespace BaiTapADO.NET.DTO
{
    public class CCow:CCattle
    {
        public CCow(int quantity, CCow c) { 
            this.Quantity = quantity;
            this.MaxMilk = c.MaxMilk;
            this.SCry = c.SCry;
        }
        public CCow(DataRow row)
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
            return 0;
        }

        public override void GiveBirth()
        {
            if (Quantity!=0)
                Quantity += 1;
        }

        public override int GiveMilk()
        {
            Random random = new Random();
            return (int)random.Next(0, MaxMilk + 1);
        }
    }
}
