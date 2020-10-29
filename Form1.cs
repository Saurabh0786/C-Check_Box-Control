using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Box
{
    public partial class Form1 : Form
    {
        string Text1 = "";
        string Text2 = "";
        string Text3 = "";
        string Text4 = "";
        string Text5 = "";
        string Text6 = "";
        string Text7 = "";
        string Text8 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboneplus_CheckedChanged(object sender, EventArgs e)
        {
            if(cboneplus.Checked == true)
            {
                Text1 = cboneplus.Text;
            }
            else
            {
                Text1 = "";
            }

        }

        private void cbapple_CheckedChanged(object sender, EventArgs e)
        {
            if (cbapple.Checked == true)
            {
                Text2 = cbapple.Text;
            }
            else
            {
                Text2 = "";
            }
        }

        private void cbsamsung_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsamsung.Checked == true)
            {
                Text3 = cbsamsung.Text;
            }
            else
            {
                Text3 = "";
            }
        }

        private void cbvivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbvivo.Checked == true)
            {
                Text4 = cbvivo.Text;
            }
            else
            {
                Text4 = "";
            }
        }

        private void cboppo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboppo.Checked == true)
            {
                Text5 = cboppo.Text;
            }
            else
            {
                Text5 = "";
            }
        }

        private void cbxiaomi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxiaomi.Checked == true)
            {
                Text6 = cbxiaomi.Text;
            }
            else
            {
                Text6 = "";
            }

        }

        private void cbrealme_CheckedChanged(object sender, EventArgs e)
        {
            if (cbrealme.Checked == true)
            {
                Text7 = cbrealme.Text;
            }
            else
            {
                Text7 = "";
            }

        }

        private void cbrog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbrog.Checked == true)
            {
                Text8 = cbrog.Text;
            }
            else
            {
                Text8 = "";
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Your Favorite Mobile companies are: " + Text1 + " " + Text2 + " " + Text3 + " " + Text4 +
                " " + Text5 + " " + Text6 + " " + Text7 + " " + Text8 );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnmybutton.Enabled = checkBox1.Checked;
        }
    }
}
