/*
 * Created by: Nicholas  Ellul
 * Created on: 13-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-03
 * This program returns the smallest nuumber in an array.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAnalyzerSmall503
{
    public partial class frmArrayAnalyzer : Form
    {
        //global declaration
        int[] arrayOfNumbers = new int[10];
        Random randomNumbers = new Random();

        public int SmallestNumber(int[] array)
        {
            //returns biggest number in array
            int elementHolder = 10;
            foreach (int element in array)
            {
                if (elementHolder > element)
                {
                    elementHolder = element;
                }

            }
            return elementHolder;
        }

        public frmArrayAnalyzer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //input
            const int NUMBER_OF_ITEMS = 10;
            int randomizedNumber;
            int leastNumber;

            this.lstBox.Items.Clear();
            Array.Clear(arrayOfNumbers, 0, arrayOfNumbers.Length);

            //process
            for (int counter = 0; counter < NUMBER_OF_ITEMS; counter++)
            {
                randomizedNumber = randomNumbers.Next(1, 10 + 1);
                this.lstBox.Items.Add(randomizedNumber);
                arrayOfNumbers[counter] = randomizedNumber;

            }

            //output
            leastNumber = SmallestNumber(arrayOfNumbers);

            MessageBox.Show(Convert.ToString(leastNumber), "The Smallest number is...");

        }
    }
}
