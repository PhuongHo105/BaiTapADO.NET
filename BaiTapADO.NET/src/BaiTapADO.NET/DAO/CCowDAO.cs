using BaiTapADO.NET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DAO
{
    public class CCowDAO 
    {
        private CCowDAO() { }
        private static CCowDAO instance;
        public static CCowDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CCowDAO();
                return instance;
            }
            private set { }
        }
        public CCow GetInfo()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Cattles where type ='Cow'");
            if (data.Rows.Count > 0)
            {
                return new CCow(data.Rows[0]);
            }
            return null;

        }
        
    }
}
