using MetodoBurbuja.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(btnumero.Text);
                numbers[i++] = number;
                ShowNumbers();
                Clear();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowNumbers()
        {
            if (lbNumbers.Items.Count > 0) 
            {
                lbNumbers.Items.Clear();   
            }
            foreach (int number in numbers)
            {
                lbNumbers.Items.Add(number);
            }
        }
        private void Clear()
        {
            btnumero.Clear();
            btnumero.Focus();
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            Burbuja burbuja = new Burbuja();
            burbuja.BubbleSort(numbers);
            ShowNumbers();
        }
    }
}
