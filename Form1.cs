using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computerScienceProblems
{
    public partial class Form1 : Form
    {
               
        public Form1()
        {
            InitializeComponent();
        }
        ScientificCalculations sCalculations;
        int[] numArray;
        List<int> l ;

        private void UnsortingButton_Click(object sender, EventArgs e)
        {
            randomizingListLabel.Text = sCalculations.getRandomizingListOrder();
        }

        private void MedianButton_Click(object sender, EventArgs e)
        {
            medianLabel.Text = sCalculations.getMedian();

        }

        private void AvarageButton_Click(object sender, EventArgs e)
        {
            avarageLabel.Text = sCalculations.getAverage();
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            modeLabel.Text = sCalculations.getMode();
                
            
        }
        private void MinimumButton_Click(object sender, EventArgs e)
        {
            minimumValue.Text = sCalculations.getMinimumValue();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells["Median"].Value = sCalculations.getMedian();
            dataGridView1.Rows[0].Cells["Minimum_Value"].Value = sCalculations.getMinimumValue();
            dataGridView1.Rows[0].Cells["Mode"].Value = sCalculations.getMode();
            dataGridView1.Rows[0].Cells["UnsortingList"].Value = sCalculations.getRandomizingListOrder();
            dataGridView1.Rows[0].Cells["ArithmeticAverage"].Value = sCalculations.getAverage();
        }
        private void InputButton_Click(object sender, EventArgs e)
        {
           numArray = System.Array.ConvertAll(Values.Text.Split(' '), int.Parse);
            MessageBox.Show("Data added sucessfully", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            sCalculations = new ScientificCalculations(numArray);
        }


        private void NthSmallestButton_Click(object sender, EventArgs e)
        {
            l.Add(Int32.Parse(NthSmallestTextBox.Text));


        }
    }
}