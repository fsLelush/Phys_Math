using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phys_Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Res_B_Click(object sender, EventArgs e)
        {
            try
            {
                int L = Convert.ToInt32(Length_TB.Text);
                int W = Convert.ToInt32(Width_TB.Text);
                int S = L * W;
                int H = Convert.ToInt32(Height_TB.Text);
                int V = S * H;
                Area_TB.Text = Convert.ToString(S);
                Volume_TB.Text = Convert.ToString(V);
            } catch (FormatException)
            {
                Area_TB.Text = "Ошибка ввода";
                Volume_TB.Text = "Ошибка ввода";
            }
        }
    }
}
