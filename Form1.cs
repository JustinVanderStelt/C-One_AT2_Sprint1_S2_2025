/* Justin Van der Stelt, Justin Van der Stelt, Sprint 1
 * Date: 21/09/2025
 * Version: V1
 * Astronomical Proccessing
 * A system to store the values of the number of neutrino interactions per hour at a local observatory.
 *  
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
            // Call a method to fill array at start up
            FillArray();
            ShowArray();
            LoadArrayToGrid();
        }
        // Array of random integers
        const int max = 24;
        int[] myArray = new int[max];
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private async void ButtonSort_Click(object sender, EventArgs e)
        {
            // Temporarily disables the button to prevent crashing
            buttonSort.Enabled = false;

            SaveGridToArray();
            int temp = 0;
            for (int outer = 0; outer < max - 1; outer++)
            {
                for (int inner = 0; inner < max - 1 - outer; inner++)
                {
                    if (myArray[inner] > myArray[inner + 1])
                    {
                        // Swap routine
                        temp = myArray[inner + 1];
                        myArray[inner + 1] = myArray[inner];
                        myArray[inner] = temp;
                    }
                    // Code to demostrate the bubble sort 
                    ShowArray();
                    Application.DoEvents();
                    await Task.Delay(100);
                    textBoxInnerFOR.Text = inner.ToString();
                    textBoxOuterFOR.Text = outer.ToString();
                }
            }
            LoadArrayToGrid();
            // Re-eneables the button
            buttonSort.Enabled = true;
        }
        // Method to display array
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int mid;
            int low = 0;
            int high = max - 1;
            int target;

            SaveGridToArray();

            if (!(Int32.TryParse(textBoxSearch.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            // Clear previous results
            listBoxResults.Items.Clear();

            // The search loop
            while (low <= high)
            {
                // Visual demonstration of the process (as used in your existing code)
                ShowArray();
                Application.DoEvents();

                mid = (low + high) / 2;

                if (myArray[mid] == target)
                {
                    // Show the position (index)
                    listBoxResults.Items.Add($"Found at index {mid}");
                    return;
                }
                else if (myArray[mid] > target)
                {
                    // Target is in the lower half
                    high = mid - 1;
                }
                else
                {
                    // Target is in the upper half
                    low = mid + 1;
                }
            }
            MessageBox.Show("Not Found, try again.");
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
                myArray[i] = rand.Next(10, 91);
            }
            LoadArrayToGrid();
        }
        private void LoadArrayToGrid()
        {
            dataGridViewArray.Rows.Clear();
            dataGridViewArray.Columns.Clear();
            for (int i = 0; i < max; i++)
            {
                dataGridViewArray.Columns.Add($"col{i}", i.ToString());
            }
            dataGridViewArray.Rows.Add();
            for (int i = 0; i < max; i++)
            {
                dataGridViewArray.Rows[0].Cells[i].Value = myArray[i];
            }
        }
        private void SaveGridToArray()
        {
            for (int i = 0; i < max; i++)
            {
                int value;
                object cellValue = dataGridViewArray.Rows[0].Cells[i].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out value))
                {
                    myArray[i] = value;
                }
                else
                {
                    MessageBox.Show($"Invalid value at index {i}. Please enter integers only.");
                    return;
                }
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SaveGridToArray(); // Test github
            LoadGridToListBox();
        }
        private void LoadGridToListBox()
        {
            // Clear any existing items in the ListBox
            listBoxResults.Items.Clear();

            // Check if the DataGridView has any rows
            if (dataGridViewArray.Rows.Count > 0)
            {
                // The data is in the first row (index 0) of the grid
                DataGridViewRow dataRow = dataGridViewArray.Rows[0];

                // Loop through each cell in that row
                foreach (DataGridViewCell cell in dataRow.Cells)
                {
                    // Check if the cell has a value before adding it
                    if (cell.Value != null)
                    {
                        // Add the cell's value to the ListBox
                        listBoxResults.Items.Add(cell.Value.ToString());
                    }
                }
            }
        }
        
        private void buttonShowGridData_Click(object sender, EventArgs e)
        {
            LoadGridToListBox();
        }
        
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            FillArray();
            ShowArray();
        }
    }
}