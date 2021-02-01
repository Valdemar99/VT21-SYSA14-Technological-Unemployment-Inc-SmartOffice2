namespace SmartOfficeApplication
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
            this.tabControlOffice = new System.Windows.Forms.TabControl();
            this.tabPageBuilding = new System.Windows.Forms.TabPage();
            this.radioButtonEditBuilding = new System.Windows.Forms.RadioButton();
            this.radioButtonAddBuilding = new System.Windows.Forms.RadioButton();
            this.labelOldAddress = new System.Windows.Forms.Label();
            this.oldAddress = new System.Windows.Forms.ComboBox();
            this.labelAddressDelete = new System.Windows.Forms.Label();
            this.readRemoveAddress = new System.Windows.Forms.ComboBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonDeleteBuilding = new System.Windows.Forms.Button();
            this.newAddress = new System.Windows.Forms.TextBox();
            this.buttonAddBuilding = new System.Windows.Forms.Button();
            this.tabPageOffice = new System.Windows.Forms.TabPage();
            this.tabControlOffice.SuspendLayout();
            this.tabPageBuilding.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOffice
            // 
            this.tabControlOffice.Controls.Add(this.tabPageBuilding);
            this.tabControlOffice.Controls.Add(this.tabPageOffice);
            this.tabControlOffice.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlOffice.Location = new System.Drawing.Point(0, -1);
            this.tabControlOffice.Name = "tabControlOffice";
            this.tabControlOffice.SelectedIndex = 0;
            this.tabControlOffice.Size = new System.Drawing.Size(800, 452);
            this.tabControlOffice.TabIndex = 0;
            // 
            // tabPageBuilding
            // 
            this.tabPageBuilding.Controls.Add(this.radioButtonEditBuilding);
            this.tabPageBuilding.Controls.Add(this.radioButtonAddBuilding);
            this.tabPageBuilding.Controls.Add(this.labelOldAddress);
            this.tabPageBuilding.Controls.Add(this.oldAddress);
            this.tabPageBuilding.Controls.Add(this.labelAddressDelete);
            this.tabPageBuilding.Controls.Add(this.readRemoveAddress);
            this.tabPageBuilding.Controls.Add(this.labelAddress);
            this.tabPageBuilding.Controls.Add(this.buttonDeleteBuilding);
            this.tabPageBuilding.Controls.Add(this.newAddress);
            this.tabPageBuilding.Controls.Add(this.buttonAddBuilding);
            this.tabPageBuilding.Location = new System.Drawing.Point(4, 23);
            this.tabPageBuilding.Name = "tabPageBuilding";
            this.tabPageBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuilding.Size = new System.Drawing.Size(792, 425);
            this.tabPageBuilding.TabIndex = 0;
            this.tabPageBuilding.Text = "Buildings";
            this.tabPageBuilding.UseVisualStyleBackColor = true;
            this.tabPageBuilding.Click += new System.EventHandler(this.tabPageBuilding_Click);
            // 
            // radioButtonEditBuilding
            // 
            this.radioButtonEditBuilding.AutoSize = true;
            this.radioButtonEditBuilding.Location = new System.Drawing.Point(210, 122);
            this.radioButtonEditBuilding.Name = "radioButtonEditBuilding";
            this.radioButtonEditBuilding.Size = new System.Drawing.Size(92, 18);
            this.radioButtonEditBuilding.TabIndex = 11;
            this.radioButtonEditBuilding.TabStop = true;
            this.radioButtonEditBuilding.Text = "Edit building";
            this.radioButtonEditBuilding.UseVisualStyleBackColor = true;
            this.radioButtonEditBuilding.CheckedChanged += new System.EventHandler(this.radioButtonEditBuilding_CheckedChanged);
            // 
            // radioButtonAddBuilding
            // 
            this.radioButtonAddBuilding.AutoSize = true;
            this.radioButtonAddBuilding.Location = new System.Drawing.Point(111, 122);
            this.radioButtonAddBuilding.Name = "radioButtonAddBuilding";
            this.radioButtonAddBuilding.Size = new System.Drawing.Size(93, 18);
            this.radioButtonAddBuilding.TabIndex = 10;
            this.radioButtonAddBuilding.TabStop = true;
            this.radioButtonAddBuilding.Text = "Add building";
            this.radioButtonAddBuilding.UseVisualStyleBackColor = true;
            this.radioButtonAddBuilding.CheckedChanged += new System.EventHandler(this.radioButtonAddBuilding_CheckedChanged_1);
            // 
            // labelOldAddress
            // 
            this.labelOldAddress.AutoSize = true;
            this.labelOldAddress.Location = new System.Drawing.Point(26, 35);
            this.labelOldAddress.Name = "labelOldAddress";
            this.labelOldAddress.Size = new System.Drawing.Size(72, 14);
            this.labelOldAddress.TabIndex = 9;
            this.labelOldAddress.Text = "Old address:";
            // 
            // oldAddress
            // 
            this.oldAddress.FormattingEnabled = true;
            this.oldAddress.Location = new System.Drawing.Point(111, 32);
            this.oldAddress.Name = "oldAddress";
            this.oldAddress.Size = new System.Drawing.Size(187, 22);
            this.oldAddress.TabIndex = 8;
            // 
            // labelAddressDelete
            // 
            this.labelAddressDelete.AutoSize = true;
            this.labelAddressDelete.Location = new System.Drawing.Point(26, 317);
            this.labelAddressDelete.Name = "labelAddressDelete";
            this.labelAddressDelete.Size = new System.Drawing.Size(51, 14);
            this.labelAddressDelete.TabIndex = 7;
            this.labelAddressDelete.Text = "Address:";
            // 
            // readRemoveAddress
            // 
            this.readRemoveAddress.FormattingEnabled = true;
            this.readRemoveAddress.Location = new System.Drawing.Point(111, 314);
            this.readRemoveAddress.Name = "readRemoveAddress";
            this.readRemoveAddress.Size = new System.Drawing.Size(187, 22);
            this.readRemoveAddress.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(26, 80);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(51, 14);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address:";
            // 
            // buttonDeleteBuilding
            // 
            this.buttonDeleteBuilding.Location = new System.Drawing.Point(111, 356);
            this.buttonDeleteBuilding.Name = "buttonDeleteBuilding";
            this.buttonDeleteBuilding.Size = new System.Drawing.Size(126, 23);
            this.buttonDeleteBuilding.TabIndex = 4;
            this.buttonDeleteBuilding.Text = "Remove building";
            this.buttonDeleteBuilding.UseVisualStyleBackColor = true;
            // 
            // newAddress
            // 
            this.newAddress.Location = new System.Drawing.Point(111, 77);
            this.newAddress.Name = "newAddress";
            this.newAddress.Size = new System.Drawing.Size(187, 21);
            this.newAddress.TabIndex = 3;
            this.newAddress.TextChanged += new System.EventHandler(this.newAddress_TextChanged);
            // 
            // buttonAddBuilding
            // 
            this.buttonAddBuilding.Location = new System.Drawing.Point(111, 146);
            this.buttonAddBuilding.Name = "buttonAddBuilding";
            this.buttonAddBuilding.Size = new System.Drawing.Size(126, 23);
            this.buttonAddBuilding.TabIndex = 0;
            this.buttonAddBuilding.Text = "Add building";
            this.buttonAddBuilding.UseVisualStyleBackColor = true;
            this.buttonAddBuilding.Click += new System.EventHandler(this.buttonAddBuilding_Click);
            // 
            // tabPageOffice
            // 
            this.tabPageOffice.Location = new System.Drawing.Point(4, 23);
            this.tabPageOffice.Name = "tabPageOffice";
            this.tabPageOffice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffice.Size = new System.Drawing.Size(792, 425);
            this.tabPageOffice.TabIndex = 1;
            this.tabPageOffice.Text = "Offices";
            this.tabPageOffice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlOffice);
            this.Name = "Form1";
            this.Text = "Smart Office 2.0";
            this.tabControlOffice.ResumeLayout(false);
            this.tabPageBuilding.ResumeLayout(false);
            this.tabPageBuilding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOffice;
        private System.Windows.Forms.TabPage tabPageBuilding;
        private System.Windows.Forms.TabPage tabPageOffice;
        private System.Windows.Forms.Button buttonAddBuilding;
        private System.Windows.Forms.Button buttonDeleteBuilding;
        private System.Windows.Forms.TextBox newAddress;
        private System.Windows.Forms.ComboBox readRemoveAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAddressDelete;
        private System.Windows.Forms.RadioButton radioButtonEditBuilding;
        private System.Windows.Forms.RadioButton radioButtonAddBuilding;
        private System.Windows.Forms.Label labelOldAddress;
        private System.Windows.Forms.ComboBox oldAddress;
    }
}

