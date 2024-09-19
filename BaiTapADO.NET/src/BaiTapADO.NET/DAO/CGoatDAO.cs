using BaiTapADO.NET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DAO
{
    public class CGoatDAO 
    { 
        private CGoatDAO() { }
        private static CGoatDAO instance;
        public static CGoatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CGoatDAO();
                return instance;
            }
            private set { }
        }
        public CGoat GetInfo()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Cattles where type ='Goat'");
            if (data.Rows.Count>0)
            {
                return new CGoat(data.Rows[0]);
            }
            return null;

        }
        
    }
}
