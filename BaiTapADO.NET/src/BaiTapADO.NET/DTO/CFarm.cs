using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DTO
{
    public class CFarm
    {
        CCattle[] listCattle; 
        public CCattle[] ListCattle { get { return listCattle; } set { listCattle = value; } }
        public CFarm(CCattle[] c)
        {
            this.ListCattle = c;
        }
    }
}
