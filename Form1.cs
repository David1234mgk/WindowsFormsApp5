using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int burger1 = 0;//crab
        int qq1 = 0;//qq
        int gold1 = 0;//gold
        int big1 = 0;//big
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)//已經打勾了
            {
                if (comboBox1.Items.IndexOf(comboBox1.Text) == 0)
                {
                    burger1 = 75 * 1;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 1)
                {
                    burger1 = 75 * 2;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 2)
                {
                    burger1 = 75 * 3;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 3)
                {
                    burger1 = 75 * 4;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 4)
                {
                    burger1 = 75 * 5;
                }
                Program.crab = burger1;
            }
            if (checkBox2.Checked == true)//已經打勾了   
            {
                if (comboBox2.Items.IndexOf(comboBox2.Text) == 0)
                {
                    qq1 = 75 * 1;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 1)
                {
                    qq1 = 75 * 2;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 2)
                {
                    qq1 = 75 * 3;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 3)
                {
                    qq1 = 75 * 4;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 4)
                {
                    qq1 = 75 * 5;
                }
                Program.qq = qq1;
            }
            if (
            /*美味蟹堡*/
            (((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 0)) ||
            ((checkBox1.Checked == true) && comboBox1.Items.IndexOf(comboBox1.Text) == 1) ||
            ((checkBox1.Checked == true) && comboBox1.Items.IndexOf(comboBox1.Text) == 2) ||
            ((checkBox1.Checked == true) && comboBox1.Items.IndexOf(comboBox1.Text) == 3) ||
            ((checkBox1.Checked == true) && comboBox1.Items.IndexOf(comboBox1.Text) == 4))

            /*QQㄋㄟㄋㄟ好喝到咩噗茶*/||
            (((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 0) ||
            ((checkBox2.Checked == true) && comboBox2.Items.IndexOf(comboBox2.Text) == 1) ||
            ((checkBox2.Checked == true) && comboBox2.Items.IndexOf(comboBox2.Text) == 2) ||
            ((checkBox2.Checked == true) && comboBox2.Items.IndexOf(comboBox2.Text) == 3) ||
            ((checkBox2.Checked == true) && comboBox2.Items.IndexOf(comboBox2.Text) == 4)))

            /*黃金布丁凍泰式鮮奶茶*/||
            (((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 0) ||
            ((checkBox3.Checked == true) && comboBox3.Items.IndexOf(comboBox3.Text) == 1) ||
            ((checkBox3.Checked == true) && comboBox3.Items.IndexOf(comboBox3.Text) == 2) ||
            ((checkBox3.Checked == true) && comboBox3.Items.IndexOf(comboBox3.Text) == 3) ||
            ((checkBox3.Checked == true) && comboBox3.Items.IndexOf(comboBox3.Text) == 4)))

            /*宇宙大燒賣*/||
            (((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 0) ||
            ((checkBox4.Checked == true) && comboBox4.Items.IndexOf(comboBox4.Text) == 1) ||
            ((checkBox4.Checked == true) && comboBox4.Items.IndexOf(comboBox4.Text) == 2) ||
            ((checkBox4.Checked == true) && comboBox4.Items.IndexOf(comboBox4.Text) == 3) ||
            ((checkBox4.Checked == true) && comboBox4.Items.IndexOf(comboBox4.Text) == 4)))
            )
            {
                form2 frame = new form2();
                frame.Show();
            }
        }
    }
}
