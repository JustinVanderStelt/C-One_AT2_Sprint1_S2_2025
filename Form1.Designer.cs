namespace C_One_AT2_Sprint1_S2_2025
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxOuterFOR = new System.Windows.Forms.TextBox();
            this.textBoxInnerFOR = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 20;
            this.listBoxResults.Location = new System.Drawing.Point(18, 42);
            this.listBoxResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(404, 544);
            this.listBoxResults.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(604, 137);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(112, 35);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(604, 257);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 35);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxOuterFOR
            // 
            this.textBoxOuterFOR.Location = new System.Drawing.Point(622, 366);
            this.textBoxOuterFOR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOuterFOR.Name = "textBoxOuterFOR";
            this.textBoxOuterFOR.ReadOnly = true;
            this.textBoxOuterFOR.Size = new System.Drawing.Size(148, 26);
            this.textBoxOuterFOR.TabIndex = 3;
            // 
            // textBoxInnerFOR
            // 
            this.textBoxInnerFOR.Location = new System.Drawing.Point(622, 440);
            this.textBoxInnerFOR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInnerFOR.Name = "textBoxInnerFOR";
            this.textBoxInnerFOR.ReadOnly = true;
            this.textBoxInnerFOR.Size = new System.Drawing.Size(148, 26);
            this.textBoxInnerFOR.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(604, 198);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(148, 26);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(622, 589);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 7;
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.ColumnHeadersVisible = false;
            this.dataGridViewArray.Location = new System.Drawing.Point(861, 42);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersVisible = false;
            this.dataGridViewArray.RowTemplate.Height = 28;
            this.dataGridViewArray.Size = new System.Drawing.Size(270, 544);
            this.dataGridViewArray.TabIndex = 8;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(622, 525);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(113, 33);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxInnerFOR);
            this.Controls.Add(this.textBoxOuterFOR);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.listBoxResults);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Astronomical processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxOuterFOR;
        private System.Windows.Forms.TextBox textBoxInnerFOR;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button buttonEdit;
    }
}

