﻿namespace Assignment2ViewMetadata
{
    partial class FormForMetadata
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
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTablesOfInterest = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesOfInterest)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(129, 53);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTables.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "This table has ... rows";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(534, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 355);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Columns";
            // 
            // dataGridViewTablesOfInterest
            // 
            this.dataGridViewTablesOfInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablesOfInterest.Location = new System.Drawing.Point(37, 127);
            this.dataGridViewTablesOfInterest.Name = "dataGridViewTablesOfInterest";
            this.dataGridViewTablesOfInterest.Size = new System.Drawing.Size(449, 284);
            this.dataGridViewTablesOfInterest.TabIndex = 5;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(37, 98);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh data";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormForMetadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewTablesOfInterest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "FormForMetadata";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesOfInterest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTablesOfInterest;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
