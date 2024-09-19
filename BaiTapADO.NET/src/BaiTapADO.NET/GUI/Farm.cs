using BaiTapADO.NET.DAO;
using BaiTapADO.NET.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapADO.NET
{
    public partial class Farm : Form
    {
        private CFarm farm;
        public Farm()
        {
            InitializeComponent();
        }

        private void bt_Enter_Click(object sender, EventArgs e)
        {
            farm = CFarmDAO.Instance.getInfo(Convert.ToInt16(numericUpDown_Cow.Value),
                Convert.ToInt16(numericUpDown_Sheep.Value), Convert.ToInt16(numericUpDown_Goat.Value));
            tb_Milk.Text = CFarmDAO.Instance.calculateMilk(farm).ToString();
            tb_Cry.Text = CFarmDAO.Instance.cry(farm);
            CFarmDAO.Instance.giveBirth(farm);
            tb_Cow.Text = CFarmDAO.Instance.getQuantityOfCow(farm).ToString();
            tb_Sheep.Text = CFarmDAO.Instance.getQuantityOfSheep(farm).ToString();
            tb_Goat.Text = CFarmDAO.Instance.getQuantityOfGoat(farm).ToString();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            farm.ListCattle = null;
            farm = null;
            numericUpDown_Cow.Value = 0;
            numericUpDown_Goat.Value = 0;
            numericUpDown_Sheep.Value = 0;
            tb_Milk.Clear();
            tb_Cry.Clear();
            tb_Cow.Clear();
            tb_Sheep.Clear();
            tb_Goat.Clear();
        }
    }
}
