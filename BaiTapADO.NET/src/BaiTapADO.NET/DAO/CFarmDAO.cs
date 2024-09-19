using BaiTapADO.NET.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapADO.NET.DAO
{
    public class CFarmDAO
    {
        private CFarmDAO() { }
        private static CFarmDAO instance;
        public static CFarmDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CFarmDAO();
                }
                return instance;
            }
            private set { }
        } 
        public CFarm getInfo(int cow, int sheep, int goat)
        {
            CCattle[] list = { new CCow(cow, CCowDAO.Instance.GetInfo()), 
                new CSheep(sheep, CSheepDAO.Instance.GetInfo()), 
                new CGoat(goat, CGoatDAO.Instance.GetInfo()) };
            return new CFarm(list);
        }
        public int calculateMilk(CFarm f)
        {
            int milk = 0;
            foreach (CCattle item in f.ListCattle)
            {
                for (int i=1;i<=item.Quantity;i++)
                    milk += item.GiveMilk();
            }
            return milk;
        }

        public void giveBirth(CFarm f)
        {
            foreach (CCattle item in f.ListCattle)
            {
                int quantity = item.Quantity;
                for (int i = 1; i <= quantity; i++)
                    item.GiveBirth();
            }
        }
        public string cry(CFarm f)
        {
            string s = "";
            foreach (CCattle item in f.ListCattle)
            {
                for (int i = 1; i <= item.Quantity; i++)
                    s += item.Cry() + " ";
            }
            return s;
        }
        public int getQuantityOfCow(CFarm f)
        {
            foreach (CCattle item in f.ListCattle)
            {
                if (item.getType()==0)
                {
                    return item.Quantity;
                }
            }
            return 0;
        }
        public int getQuantityOfSheep(CFarm f)
        {
            foreach (CCattle item in f.ListCattle)
            {
                if (item.getType() == 1)
                {
                    return item.Quantity;
                }
            }
            return 0;
        }
        public int getQuantityOfGoat(CFarm f)
        {
            foreach (CCattle item in f.ListCattle)
            {
                if (item.getType() == 2)
                {
                    return item.Quantity;
                }
            }
            return 0;
        }

    }
}