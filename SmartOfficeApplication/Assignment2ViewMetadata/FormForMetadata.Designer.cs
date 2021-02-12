namespace Assignment2ViewMetadata
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
            this.labelAmountOfRows = new System.Windows.Forms.Label();
            this.listBoxColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(129, 53);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTables.TabIndex = 0;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
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
            // labelAmountOfRows
            // 
            this.labelAmountOfRows.AutoSize = true;
            this.labelAmountOfRows.Location = new System.Drawing.Point(376, 56);
            this.labelAmountOfRows.Name = "labelAmountOfRows";
            this.labelAmountOfRows.Size = new System.Drawing.Size(110, 13);
            this.labelAmountOfRows.TabIndex = 2;
            this.labelAmountOfRows.Text = "This table has ... rows";
            // 
            // listBoxColumns
            // 
            this.listBoxColumns.FormattingEnabled = true;
            this.listBoxColumns.Location = new System.Drawing.Point(534, 56);
            this.listBoxColumns.Name = "listBoxColumns";
            this.listBoxColumns.Size = new System.Drawing.Size(188, 108);
            this.listBoxColumns.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(780, 201);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxColumns);
            this.Controls.Add(this.labelAmountOfRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "FormForMetadata";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAmountOfRows;
        private System.Windows.Forms.ListBox listBoxColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

