using BaiTapADO.NET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DAO
{
    public class CSheepDAO 
    {

        private CSheepDAO() { }
        private static CSheepDAO instance;
        public static CSheepDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CSheepDAO();
                return instance;
            }
            private set { }
        }
        public CSheep GetInfo()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Cattles where type ='Sheep'");
            if (data.Rows.Count > 0)
            {
                return new CSheep(data.Rows[0]);
            }
            return null;

        }

    }
}
