using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form1 : Form
    {
        public static bool login = false;
   
        public Form1()
        {
            InitializeComponent();
            if (login == true) {
                LogiSisse_btn.Text = "logi välja";
            }
        }

        private void Kava_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void LogiSisse_btn_Click(object sender, EventArgs e)
        {
            if(login == false)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                login = false;
            }
        }


        private void OstaPilet_btn_Click(object sender, EventArgs e)
        {
            if (login == false)
            {
                MessageBox.Show("logi sisse selleks et osta pilet");
            }
            else
            {
                MessageBox.Show("koik on hasti");
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
