using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testtrackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(255, tbr_r.Value,tbr_g.Value, tbr_b.Value);
            tb.Text = tbr_r.Value.ToString() + "," + tbr_g.Value.ToString() + "," + tbr_b.Value.ToString();
        }

        private void tbr_r_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, tbr_r.Value, tbr_g.Value, tbr_b.Value);
            tb.Text = tbr_r.Value.ToString() + "," + tbr_g.Value.ToString() + "," + tbr_b.Value.ToString();
        }

        private void tbr_g_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, tbr_r.Value, tbr_g.Value, tbr_b.Value);
            tb.Text = tbr_r.Value.ToString() + "," + tbr_g.Value.ToString() + "," + tbr_b.Value.ToString();
        }

        private void tbr_b_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, tbr_r.Value, tbr_g.Value, tbr_b.Value);
            tb.Text = tbr_r.Value.ToString() + "," + tbr_g.Value.ToString()+","+ tbr_b.Value.ToString();
        }
    }
}
