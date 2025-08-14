using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_One_AT2_Sprint1_S2_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Array of random integers
        const int max = 24;
        int[] myArray = new int[max];
        private void Form1_Load(object sender, EventArgs e)
        {
            myArray = new int[max];
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int outer = 0; outer < max - 1; outer++)
            {
                for (int inner = 0; inner < max - 1; inner++)
                {
                    if (myArray[inner] > myArray[inner + 1])
                    {
                        // Swap routine
                        temp = myArray[inner + 1];
                        myArray[inner + 1] = myArray[inner];
                        myArray[inner] = temp;
                    }
                    // Code to demostare the bubble sort 
                    ShowArray();
                    Application.DoEvents();
                    Thread.Sleep(100);
                    textBoxInnerFOR.Text = inner.ToString();
                    textBoxOuterFOR.Text = outer.ToString();
                }
            }
        }
        // Method to deisplay array
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int mid;
            int lowBound = 0;
            int highBound = max;
            int target;
            if (!(Int32.TryParse(textBoxSearch.Text, out target)))
            {
                MessageBox.Show("You must eneter an integer");
                return;
            }
            while (lowBound <= highBound) // Check "<" or "<="
            {
                // Display list
                ShowArray();
                // Find the mid-point
                mid = (lowBound + highBound) / 2;
                // Pause with a messagebox
                MessageBox.Show("Low:" + lowBound + "Mid:" + mid + "High:" + highBound);
                if (myArray[mid] == target)
                {
                    // Target has been found
                    listBoxResults.Items.Add("Found at index " + mid);
                    return;
                }
                else if (myArray[mid] >= target)
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }
                MessageBox.Show("Not Found, try again.");

            }
        }
        //Mehtod to display array    
        private void ShowArray()
        {
            listBoxResults.Items.Clear();
            for (int i = 0; i < max; i++)
            {
                listBoxResults.Items.Add(myArray[i]);
            }
        }
        // Method to fill Array with random numbers

        private void FillArray()
        {
            // Create a random number
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                // Random number 10..90
                myArray[i] = rand.Next(10, 90);
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
