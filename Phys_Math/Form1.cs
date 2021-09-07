﻿using System;
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
            int S, D1;
            S = 8;
            D1 = 10;
            try
            {           
                int H = Convert.ToInt32(Height_TB1.Text);
                int V = S * H;
                Volume_TB.Text = Convert.ToString(V);                                   //Подсчёт Объёма 

                int W1 = D1 * V;
                int W2 = W1;
                Weight_TB1.Text = Convert.ToString(W1);                                 //Нахождение массы
                Weight_TB2.Text = Convert.ToString(W2);

            } catch (FormatException)
            {
                Volume_TB.Text = "Ошибка ввода";
                Weight_TB1.Text = "Ошибка ввода";
                Weight_TB2.Text = "Ошибка ввода";
            }
        }

        private void Res_B2_Click(object sender, EventArgs e)                           
        {
            try
            {
                int D2 = Convert.ToInt32(Density_TB2.Text);
                int W2 = Convert.ToInt32(Weight_TB2.Text);
                int S = Convert.ToInt32(Area_TB.Text);
                int V2 = W2 / D2;
                int H = V2 / S;
                Height_TB2.Text = Convert.ToString(H);
            } catch (FormatException)
            {
                Height_TB2.Text = "Ошибка ввода";
            }
        }
    }
}
