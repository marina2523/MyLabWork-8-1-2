using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_Lab8_Samost
{
    public partial class Form1 : Form
    {
        int[] Arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            ClearFields();
            int n = int.Parse(txtN.Text);
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                lblArr.Text += Arr[i];
                if (i != n) lblArr.Text += ", ";
            }
            btnSort.Enabled = true;
        }

        private int[] Insertion(int[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                int k = Array[i];
                int j = i - 1;

                while (j >= 0 && Array[j] > k) 
                {
                    Array[j + 1] = Array[j];
                    Array[j] = k;
                    j--;
                }
            }

            return Array;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Arr = Insertion(Arr);
            for (int i = 0; i < Arr.Length; i++)
            {
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1)
                {
                    lblResult.Text += ", ";
                }
            }
        }

        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
