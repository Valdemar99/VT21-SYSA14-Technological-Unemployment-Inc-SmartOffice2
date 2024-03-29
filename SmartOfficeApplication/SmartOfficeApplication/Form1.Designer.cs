﻿namespace SmartOfficeApplication
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
            this.labelFeedbackForDeletingBuilding = new System.Windows.Forms.Label();
            this.labelListOfBuildings = new System.Windows.Forms.Label();
            this.labelFeedbackForBuildings = new System.Windows.Forms.Label();
            this.listBoxBuildings = new System.Windows.Forms.ListBox();
            this.radioButtonEditBuilding = new System.Windows.Forms.RadioButton();
            this.radioButtonAddBuilding = new System.Windows.Forms.RadioButton();
            this.labelOldAddress = new System.Windows.Forms.Label();
            this.comboBoxOldAddress = new System.Windows.Forms.ComboBox();
            this.labelAddressDelete = new System.Windows.Forms.Label();
            this.comboBoxAddressDelete = new System.Windows.Forms.ComboBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonDeleteBuilding = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAddBuilding = new System.Windows.Forms.Button();
            this.tabPageOffice = new System.Windows.Forms.TabPage();
            this.dataGridViewOffices = new System.Windows.Forms.DataGridView();
            this.labelFeedbackForViewingOffices = new System.Windows.Forms.Label();
            this.labelFeedbackLabelForDeletingOffice = new System.Windows.Forms.Label();
            this.labelFeedbackForOffices = new System.Windows.Forms.Label();
            this.buttonViewOffices = new System.Windows.Forms.Button();
            this.labelAddressViewOffices = new System.Windows.Forms.Label();
            this.comboBoxAddressViewOffices = new System.Windows.Forms.ComboBox();
            this.buttonDeleteOffice = new System.Windows.Forms.Button();
            this.labelOfficeNumberDelete = new System.Windows.Forms.Label();
            this.comboBoxOfficeNumberDelete = new System.Windows.Forms.ComboBox();
            this.labelOfficeAddressDelete = new System.Windows.Forms.Label();
            this.comboBoxOfficeAddressDelete = new System.Windows.Forms.ComboBox();
            this.radioButtonEditOffice = new System.Windows.Forms.RadioButton();
            this.radioButtonAddOffice = new System.Windows.Forms.RadioButton();
            this.buttonAddOffice = new System.Windows.Forms.Button();
            this.labelSelectedTemperature = new System.Windows.Forms.Label();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.comboBoxVentilationSetting = new System.Windows.Forms.ComboBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelVentilationSetting = new System.Windows.Forms.Label();
            this.labelOfficeNumber = new System.Windows.Forms.Label();
            this.comboBoxOfficeNumber = new System.Windows.Forms.ComboBox();
            this.labelOfficeAddress = new System.Windows.Forms.Label();
            this.comboBoxOfficeAddress = new System.Windows.Forms.ComboBox();
            this.officeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureSettingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventilationSettingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlOffice.SuspendLayout();
            this.tabPageBuilding.SuspendLayout();
            this.tabPageOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
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
            this.tabControlOffice.Size = new System.Drawing.Size(800, 487);
            this.tabControlOffice.TabIndex = 0;
            // 
            // tabPageBuilding
            // 
            this.tabPageBuilding.Controls.Add(this.labelFeedbackForDeletingBuilding);
            this.tabPageBuilding.Controls.Add(this.labelListOfBuildings);
            this.tabPageBuilding.Controls.Add(this.labelFeedbackForBuildings);
            this.tabPageBuilding.Controls.Add(this.listBoxBuildings);
            this.tabPageBuilding.Controls.Add(this.radioButtonEditBuilding);
            this.tabPageBuilding.Controls.Add(this.radioButtonAddBuilding);
            this.tabPageBuilding.Controls.Add(this.labelOldAddress);
            this.tabPageBuilding.Controls.Add(this.comboBoxOldAddress);
            this.tabPageBuilding.Controls.Add(this.labelAddressDelete);
            this.tabPageBuilding.Controls.Add(this.comboBoxAddressDelete);
            this.tabPageBuilding.Controls.Add(this.labelAddress);
            this.tabPageBuilding.Controls.Add(this.buttonDeleteBuilding);
            this.tabPageBuilding.Controls.Add(this.textBoxAddress);
            this.tabPageBuilding.Controls.Add(this.buttonAddBuilding);
            this.tabPageBuilding.Location = new System.Drawing.Point(4, 23);
            this.tabPageBuilding.Name = "tabPageBuilding";
            this.tabPageBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuilding.Size = new System.Drawing.Size(792, 460);
            this.tabPageBuilding.TabIndex = 0;
            this.tabPageBuilding.Text = "Buildings";
            this.tabPageBuilding.UseVisualStyleBackColor = true;
            // 
            // labelFeedbackForDeletingBuilding
            // 
            this.labelFeedbackForDeletingBuilding.AutoSize = true;
            this.labelFeedbackForDeletingBuilding.Location = new System.Drawing.Point(26, 387);
            this.labelFeedbackForDeletingBuilding.Name = "labelFeedbackForDeletingBuilding";
            this.labelFeedbackForDeletingBuilding.Size = new System.Drawing.Size(10, 14);
            this.labelFeedbackForDeletingBuilding.TabIndex = 37;
            this.labelFeedbackForDeletingBuilding.Text = " ";
            // 
            // labelListOfBuildings
            // 
            this.labelListOfBuildings.AutoSize = true;
            this.labelListOfBuildings.Location = new System.Drawing.Point(384, 35);
            this.labelListOfBuildings.Name = "labelListOfBuildings";
            this.labelListOfBuildings.Size = new System.Drawing.Size(157, 14);
            this.labelListOfBuildings.TabIndex = 36;
            this.labelListOfBuildings.Text = "List of all building addresses:";
            // 
            // labelFeedbackForBuildings
            // 
            this.labelFeedbackForBuildings.AutoSize = true;
            this.labelFeedbackForBuildings.Location = new System.Drawing.Point(26, 172);
            this.labelFeedbackForBuildings.Name = "labelFeedbackForBuildings";
            this.labelFeedbackForBuildings.Size = new System.Drawing.Size(10, 14);
            this.labelFeedbackForBuildings.TabIndex = 35;
            this.labelFeedbackForBuildings.Text = " ";
            // 
            // listBoxBuildings
            // 
            this.listBoxBuildings.Enabled = false;
            this.listBoxBuildings.FormattingEnabled = true;
            this.listBoxBuildings.ItemHeight = 14;
            this.listBoxBuildings.Location = new System.Drawing.Point(387, 77);
            this.listBoxBuildings.Name = "listBoxBuildings";
            this.listBoxBuildings.Size = new System.Drawing.Size(362, 270);
            this.listBoxBuildings.TabIndex = 12;
            // 
            // radioButtonEditBuilding
            // 
            this.radioButtonEditBuilding.AutoSize = true;
            this.radioButtonEditBuilding.Location = new System.Drawing.Point(210, 122);
            this.radioButtonEditBuilding.Name = "radioButtonEditBuilding";
            this.radioButtonEditBuilding.Size = new System.Drawing.Size(92, 18);
            this.radioButtonEditBuilding.TabIndex = 11;
            this.radioButtonEditBuilding.Text = "Edit building";
            this.radioButtonEditBuilding.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddBuilding
            // 
            this.radioButtonAddBuilding.AutoSize = true;
            this.radioButtonAddBuilding.Checked = true;
            this.radioButtonAddBuilding.Location = new System.Drawing.Point(111, 122);
            this.radioButtonAddBuilding.Name = "radioButtonAddBuilding";
            this.radioButtonAddBuilding.Size = new System.Drawing.Size(93, 18);
            this.radioButtonAddBuilding.TabIndex = 10;
            this.radioButtonAddBuilding.TabStop = true;
            this.radioButtonAddBuilding.Text = "Add building";
            this.radioButtonAddBuilding.UseVisualStyleBackColor = true;
            this.radioButtonAddBuilding.CheckedChanged += new System.EventHandler(this.radioButtonAddBuilding_CheckedChanged);
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
            // comboBoxOldAddress
            // 
            this.comboBoxOldAddress.Enabled = false;
            this.comboBoxOldAddress.FormattingEnabled = true;
            this.comboBoxOldAddress.Location = new System.Drawing.Point(111, 32);
            this.comboBoxOldAddress.Name = "comboBoxOldAddress";
            this.comboBoxOldAddress.Size = new System.Drawing.Size(187, 22);
            this.comboBoxOldAddress.TabIndex = 8;
            // 
            // labelAddressDelete
            // 
            this.labelAddressDelete.AutoSize = true;
            this.labelAddressDelete.Location = new System.Drawing.Point(26, 318);
            this.labelAddressDelete.Name = "labelAddressDelete";
            this.labelAddressDelete.Size = new System.Drawing.Size(51, 14);
            this.labelAddressDelete.TabIndex = 7;
            this.labelAddressDelete.Text = "Address:";
            // 
            // comboBoxAddressDelete
            // 
            this.comboBoxAddressDelete.FormattingEnabled = true;
            this.comboBoxAddressDelete.Location = new System.Drawing.Point(111, 315);
            this.comboBoxAddressDelete.Name = "comboBoxAddressDelete";
            this.comboBoxAddressDelete.Size = new System.Drawing.Size(187, 22);
            this.comboBoxAddressDelete.TabIndex = 6;
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
            this.buttonDeleteBuilding.Location = new System.Drawing.Point(111, 353);
            this.buttonDeleteBuilding.Name = "buttonDeleteBuilding";
            this.buttonDeleteBuilding.Size = new System.Drawing.Size(126, 23);
            this.buttonDeleteBuilding.TabIndex = 4;
            this.buttonDeleteBuilding.Text = "Remove building";
            this.buttonDeleteBuilding.UseVisualStyleBackColor = true;
            this.buttonDeleteBuilding.Click += new System.EventHandler(this.buttonDeleteBuilding_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(111, 77);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddress.TabIndex = 3;
            // 
            // buttonAddBuilding
            // 
            this.buttonAddBuilding.Location = new System.Drawing.Point(111, 146);
            this.buttonAddBuilding.Name = "buttonAddBuilding";
            this.buttonAddBuilding.Size = new System.Drawing.Size(126, 23);
            this.buttonAddBuilding.TabIndex = 0;
            this.buttonAddBuilding.Text = "Save";
            this.buttonAddBuilding.UseVisualStyleBackColor = true;
            this.buttonAddBuilding.Click += new System.EventHandler(this.buttonAddBuilding_Click);
            // 
            // tabPageOffice
            // 
            this.tabPageOffice.Controls.Add(this.dataGridViewOffices);
            this.tabPageOffice.Controls.Add(this.labelFeedbackForViewingOffices);
            this.tabPageOffice.Controls.Add(this.labelFeedbackLabelForDeletingOffice);
            this.tabPageOffice.Controls.Add(this.labelFeedbackForOffices);
            this.tabPageOffice.Controls.Add(this.buttonViewOffices);
            this.tabPageOffice.Controls.Add(this.labelAddressViewOffices);
            this.tabPageOffice.Controls.Add(this.comboBoxAddressViewOffices);
            this.tabPageOffice.Controls.Add(this.buttonDeleteOffice);
            this.tabPageOffice.Controls.Add(this.labelOfficeNumberDelete);
            this.tabPageOffice.Controls.Add(this.comboBoxOfficeNumberDelete);
            this.tabPageOffice.Controls.Add(this.labelOfficeAddressDelete);
            this.tabPageOffice.Controls.Add(this.comboBoxOfficeAddressDelete);
            this.tabPageOffice.Controls.Add(this.radioButtonEditOffice);
            this.tabPageOffice.Controls.Add(this.radioButtonAddOffice);
            this.tabPageOffice.Controls.Add(this.buttonAddOffice);
            this.tabPageOffice.Controls.Add(this.labelSelectedTemperature);
            this.tabPageOffice.Controls.Add(this.trackBarTemperature);
            this.tabPageOffice.Controls.Add(this.comboBoxVentilationSetting);
            this.tabPageOffice.Controls.Add(this.labelTemperature);
            this.tabPageOffice.Controls.Add(this.labelVentilationSetting);
            this.tabPageOffice.Controls.Add(this.labelOfficeNumber);
            this.tabPageOffice.Controls.Add(this.comboBoxOfficeNumber);
            this.tabPageOffice.Controls.Add(this.labelOfficeAddress);
            this.tabPageOffice.Controls.Add(this.comboBoxOfficeAddress);
            this.tabPageOffice.Location = new System.Drawing.Point(4, 23);
            this.tabPageOffice.Name = "tabPageOffice";
            this.tabPageOffice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffice.Size = new System.Drawing.Size(792, 460);
            this.tabPageOffice.TabIndex = 1;
            this.tabPageOffice.Text = "Offices";
            this.tabPageOffice.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOffices
            // 
            this.dataGridViewOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffices.Location = new System.Drawing.Point(423, 136);
            this.dataGridViewOffices.Name = "dataGridViewOffices";
            this.dataGridViewOffices.Size = new System.Drawing.Size(312, 246);
            this.dataGridViewOffices.TabIndex = 37;
            // 
            // labelFeedbackForViewingOffices
            // 
            this.labelFeedbackForViewingOffices.AutoSize = true;
            this.labelFeedbackForViewingOffices.Location = new System.Drawing.Point(420, 105);
            this.labelFeedbackForViewingOffices.Name = "labelFeedbackForViewingOffices";
            this.labelFeedbackForViewingOffices.Size = new System.Drawing.Size(10, 14);
            this.labelFeedbackForViewingOffices.TabIndex = 36;
            this.labelFeedbackForViewingOffices.Text = " ";
            // 
            // labelFeedbackLabelForDeletingOffice
            // 
            this.labelFeedbackLabelForDeletingOffice.AutoSize = true;
            this.labelFeedbackLabelForDeletingOffice.Location = new System.Drawing.Point(26, 438);
            this.labelFeedbackLabelForDeletingOffice.Name = "labelFeedbackLabelForDeletingOffice";
            this.labelFeedbackLabelForDeletingOffice.Size = new System.Drawing.Size(10, 14);
            this.labelFeedbackLabelForDeletingOffice.TabIndex = 35;
            this.labelFeedbackLabelForDeletingOffice.Text = " ";
            // 
            // labelFeedbackForOffices
            // 
            this.labelFeedbackForOffices.AutoSize = true;
            this.labelFeedbackForOffices.Location = new System.Drawing.Point(26, 282);
            this.labelFeedbackForOffices.Name = "labelFeedbackForOffices";
            this.labelFeedbackForOffices.Size = new System.Drawing.Size(81, 14);
            this.labelFeedbackForOffices.TabIndex = 34;
            this.labelFeedbackForOffices.Text = "feedbackLabel";
            // 
            // buttonViewOffices
            // 
            this.buttonViewOffices.Location = new System.Drawing.Point(548, 76);
            this.buttonViewOffices.Name = "buttonViewOffices";
            this.buttonViewOffices.Size = new System.Drawing.Size(126, 23);
            this.buttonViewOffices.TabIndex = 32;
            this.buttonViewOffices.Text = "View offices";
            this.buttonViewOffices.UseVisualStyleBackColor = true;
            this.buttonViewOffices.Click += new System.EventHandler(this.buttonViewOffices_Click);
            // 
            // labelAddressViewOffices
            // 
            this.labelAddressViewOffices.AutoSize = true;
            this.labelAddressViewOffices.Location = new System.Drawing.Point(420, 38);
            this.labelAddressViewOffices.Name = "labelAddressViewOffices";
            this.labelAddressViewOffices.Size = new System.Drawing.Size(51, 14);
            this.labelAddressViewOffices.TabIndex = 31;
            this.labelAddressViewOffices.Text = "Address:";
            // 
            // comboBoxAddressViewOffices
            // 
            this.comboBoxAddressViewOffices.FormattingEnabled = true;
            this.comboBoxAddressViewOffices.Location = new System.Drawing.Point(548, 35);
            this.comboBoxAddressViewOffices.Name = "comboBoxAddressViewOffices";
            this.comboBoxAddressViewOffices.Size = new System.Drawing.Size(187, 22);
            this.comboBoxAddressViewOffices.TabIndex = 30;
            // 
            // buttonDeleteOffice
            // 
            this.buttonDeleteOffice.Location = new System.Drawing.Point(154, 399);
            this.buttonDeleteOffice.Name = "buttonDeleteOffice";
            this.buttonDeleteOffice.Size = new System.Drawing.Size(126, 23);
            this.buttonDeleteOffice.TabIndex = 29;
            this.buttonDeleteOffice.Text = "Remove office";
            this.buttonDeleteOffice.UseVisualStyleBackColor = true;
            this.buttonDeleteOffice.Click += new System.EventHandler(this.buttonDeleteOffice_Click);
            // 
            // labelOfficeNumberDelete
            // 
            this.labelOfficeNumberDelete.AutoSize = true;
            this.labelOfficeNumberDelete.Location = new System.Drawing.Point(26, 363);
            this.labelOfficeNumberDelete.Name = "labelOfficeNumberDelete";
            this.labelOfficeNumberDelete.Size = new System.Drawing.Size(85, 14);
            this.labelOfficeNumberDelete.TabIndex = 28;
            this.labelOfficeNumberDelete.Text = "Office Number:";
            // 
            // comboBoxOfficeNumberDelete
            // 
            this.comboBoxOfficeNumberDelete.FormattingEnabled = true;
            this.comboBoxOfficeNumberDelete.Location = new System.Drawing.Point(154, 360);
            this.comboBoxOfficeNumberDelete.Name = "comboBoxOfficeNumberDelete";
            this.comboBoxOfficeNumberDelete.Size = new System.Drawing.Size(187, 22);
            this.comboBoxOfficeNumberDelete.TabIndex = 27;
            // 
            // labelOfficeAddressDelete
            // 
            this.labelOfficeAddressDelete.AutoSize = true;
            this.labelOfficeAddressDelete.Location = new System.Drawing.Point(26, 318);
            this.labelOfficeAddressDelete.Name = "labelOfficeAddressDelete";
            this.labelOfficeAddressDelete.Size = new System.Drawing.Size(51, 14);
            this.labelOfficeAddressDelete.TabIndex = 26;
            this.labelOfficeAddressDelete.Text = "Address:";
            // 
            // comboBoxOfficeAddressDelete
            // 
            this.comboBoxOfficeAddressDelete.FormattingEnabled = true;
            this.comboBoxOfficeAddressDelete.Location = new System.Drawing.Point(154, 315);
            this.comboBoxOfficeAddressDelete.Name = "comboBoxOfficeAddressDelete";
            this.comboBoxOfficeAddressDelete.Size = new System.Drawing.Size(187, 22);
            this.comboBoxOfficeAddressDelete.TabIndex = 25;
            this.comboBoxOfficeAddressDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfficeAddressDelete_SelectedIndexChanged);
            // 
            // radioButtonEditOffice
            // 
            this.radioButtonEditOffice.AutoSize = true;
            this.radioButtonEditOffice.Location = new System.Drawing.Point(253, 230);
            this.radioButtonEditOffice.Name = "radioButtonEditOffice";
            this.radioButtonEditOffice.Size = new System.Drawing.Size(77, 18);
            this.radioButtonEditOffice.TabIndex = 24;
            this.radioButtonEditOffice.Text = "Edit office";
            this.radioButtonEditOffice.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddOffice
            // 
            this.radioButtonAddOffice.AutoSize = true;
            this.radioButtonAddOffice.Checked = true;
            this.radioButtonAddOffice.Location = new System.Drawing.Point(154, 230);
            this.radioButtonAddOffice.Name = "radioButtonAddOffice";
            this.radioButtonAddOffice.Size = new System.Drawing.Size(78, 18);
            this.radioButtonAddOffice.TabIndex = 23;
            this.radioButtonAddOffice.TabStop = true;
            this.radioButtonAddOffice.Text = "Add office";
            this.radioButtonAddOffice.UseVisualStyleBackColor = true;
            this.radioButtonAddOffice.CheckedChanged += new System.EventHandler(this.radioButtonAddOffice_CheckedChanged);
            // 
            // buttonAddOffice
            // 
            this.buttonAddOffice.Location = new System.Drawing.Point(154, 254);
            this.buttonAddOffice.Name = "buttonAddOffice";
            this.buttonAddOffice.Size = new System.Drawing.Size(126, 23);
            this.buttonAddOffice.TabIndex = 22;
            this.buttonAddOffice.Text = "Save";
            this.buttonAddOffice.UseVisualStyleBackColor = true;
            this.buttonAddOffice.Click += new System.EventHandler(this.buttonAddOffice_Click_1);
            // 
            // labelSelectedTemperature
            // 
            this.labelSelectedTemperature.AutoSize = true;
            this.labelSelectedTemperature.Location = new System.Drawing.Point(106, 172);
            this.labelSelectedTemperature.Name = "labelSelectedTemperature";
            this.labelSelectedTemperature.Size = new System.Drawing.Size(0, 14);
            this.labelSelectedTemperature.TabIndex = 19;
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.Location = new System.Drawing.Point(154, 159);
            this.trackBarTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarTemperature.Maximum = 30;
            this.trackBarTemperature.Minimum = 16;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(187, 45);
            this.trackBarTemperature.TabIndex = 18;
            this.trackBarTemperature.Value = 20;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // comboBoxVentilationSetting
            // 
            this.comboBoxVentilationSetting.FormattingEnabled = true;
            this.comboBoxVentilationSetting.Location = new System.Drawing.Point(154, 122);
            this.comboBoxVentilationSetting.Name = "comboBoxVentilationSetting";
            this.comboBoxVentilationSetting.Size = new System.Drawing.Size(187, 22);
            this.comboBoxVentilationSetting.TabIndex = 17;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(26, 172);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(74, 14);
            this.labelTemperature.TabIndex = 16;
            this.labelTemperature.Text = "Temperature:";
            // 
            // labelVentilationSetting
            // 
            this.labelVentilationSetting.AutoSize = true;
            this.labelVentilationSetting.Location = new System.Drawing.Point(26, 125);
            this.labelVentilationSetting.Name = "labelVentilationSetting";
            this.labelVentilationSetting.Size = new System.Drawing.Size(107, 14);
            this.labelVentilationSetting.TabIndex = 14;
            this.labelVentilationSetting.Text = "Ventilation Setting:";
            // 
            // labelOfficeNumber
            // 
            this.labelOfficeNumber.AutoSize = true;
            this.labelOfficeNumber.Location = new System.Drawing.Point(26, 80);
            this.labelOfficeNumber.Name = "labelOfficeNumber";
            this.labelOfficeNumber.Size = new System.Drawing.Size(85, 14);
            this.labelOfficeNumber.TabIndex = 13;
            this.labelOfficeNumber.Text = "Office Number:";
            // 
            // comboBoxOfficeNumber
            // 
            this.comboBoxOfficeNumber.Enabled = false;
            this.comboBoxOfficeNumber.FormattingEnabled = true;
            this.comboBoxOfficeNumber.Location = new System.Drawing.Point(154, 77);
            this.comboBoxOfficeNumber.Name = "comboBoxOfficeNumber";
            this.comboBoxOfficeNumber.Size = new System.Drawing.Size(187, 22);
            this.comboBoxOfficeNumber.TabIndex = 12;
            // 
            // labelOfficeAddress
            // 
            this.labelOfficeAddress.AutoSize = true;
            this.labelOfficeAddress.Location = new System.Drawing.Point(26, 35);
            this.labelOfficeAddress.Name = "labelOfficeAddress";
            this.labelOfficeAddress.Size = new System.Drawing.Size(51, 14);
            this.labelOfficeAddress.TabIndex = 10;
            this.labelOfficeAddress.Text = "Address:";
            // 
            // comboBoxOfficeAddress
            // 
            this.comboBoxOfficeAddress.FormattingEnabled = true;
            this.comboBoxOfficeAddress.Location = new System.Drawing.Point(154, 32);
            this.comboBoxOfficeAddress.Name = "comboBoxOfficeAddress";
            this.comboBoxOfficeAddress.Size = new System.Drawing.Size(187, 22);
            this.comboBoxOfficeAddress.TabIndex = 9;
            this.comboBoxOfficeAddress.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfficeAddress_SelectedIndexChanged);
            // 
            // officeNumberDataGridViewTextBoxColumn
            // 
            this.officeNumberDataGridViewTextBoxColumn.DataPropertyName = "officeNumber";
            this.officeNumberDataGridViewTextBoxColumn.HeaderText = "officeNumber";
            this.officeNumberDataGridViewTextBoxColumn.Name = "officeNumberDataGridViewTextBoxColumn";
            // 
            // buildingAddressDataGridViewTextBoxColumn
            // 
            this.buildingAddressDataGridViewTextBoxColumn.DataPropertyName = "buildingAddress";
            this.buildingAddressDataGridViewTextBoxColumn.HeaderText = "buildingAddress";
            this.buildingAddressDataGridViewTextBoxColumn.Name = "buildingAddressDataGridViewTextBoxColumn";
            // 
            // temperatureSettingDataGridViewTextBoxColumn
            // 
            this.temperatureSettingDataGridViewTextBoxColumn.DataPropertyName = "temperatureSetting";
            this.temperatureSettingDataGridViewTextBoxColumn.HeaderText = "temperatureSetting";
            this.temperatureSettingDataGridViewTextBoxColumn.Name = "temperatureSettingDataGridViewTextBoxColumn";
            // 
            // ventilationSettingDataGridViewTextBoxColumn
            // 
            this.ventilationSettingDataGridViewTextBoxColumn.DataPropertyName = "ventilationSetting";
            this.ventilationSettingDataGridViewTextBoxColumn.HeaderText = "ventilationSetting";
            this.ventilationSettingDataGridViewTextBoxColumn.Name = "ventilationSettingDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.tabControlOffice);
            this.Name = "Form1";
            this.Text = "Smart Office 2.0";
            this.tabControlOffice.ResumeLayout(false);
            this.tabPageBuilding.ResumeLayout(false);
            this.tabPageBuilding.PerformLayout();
            this.tabPageOffice.ResumeLayout(false);
            this.tabPageOffice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOffice;
        private System.Windows.Forms.TabPage tabPageBuilding;
        private System.Windows.Forms.TabPage tabPageOffice;
        private System.Windows.Forms.Button buttonAddBuilding;
        private System.Windows.Forms.Button buttonDeleteBuilding;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxAddressDelete;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAddressDelete;
        private System.Windows.Forms.RadioButton radioButtonEditBuilding;
        private System.Windows.Forms.RadioButton radioButtonAddBuilding;
        private System.Windows.Forms.Label labelOldAddress;
        private System.Windows.Forms.ComboBox comboBoxOldAddress;
        private System.Windows.Forms.ListBox listBoxBuildings;
        private System.Windows.Forms.ComboBox comboBoxOfficeAddress;
        private System.Windows.Forms.Label labelOfficeAddress;
        private System.Windows.Forms.RadioButton radioButtonEditOffice;
        private System.Windows.Forms.RadioButton radioButtonAddOffice;
        private System.Windows.Forms.Button buttonAddOffice;
        private System.Windows.Forms.Label labelSelectedTemperature;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.ComboBox comboBoxVentilationSetting;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelVentilationSetting;
        private System.Windows.Forms.Label labelOfficeNumber;
        private System.Windows.Forms.ComboBox comboBoxOfficeNumber;
        private System.Windows.Forms.Button buttonDeleteOffice;
        private System.Windows.Forms.Label labelOfficeNumberDelete;
        private System.Windows.Forms.ComboBox comboBoxOfficeNumberDelete;
        private System.Windows.Forms.Label labelOfficeAddressDelete;
        private System.Windows.Forms.ComboBox comboBoxOfficeAddressDelete;
        private System.Windows.Forms.Button buttonViewOffices;
        private System.Windows.Forms.Label labelAddressViewOffices;
        private System.Windows.Forms.ComboBox comboBoxAddressViewOffices;
        private System.Windows.Forms.Label labelFeedbackForOffices;
        private System.Windows.Forms.Label labelFeedbackForBuildings;
        private System.Windows.Forms.Label labelListOfBuildings;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureSettingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventilationSettingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelFeedbackForDeletingBuilding;
        private System.Windows.Forms.Label labelFeedbackLabelForDeletingOffice;
        private System.Windows.Forms.Label labelFeedbackForViewingOffices;
        private System.Windows.Forms.DataGridView dataGridViewOffices;
    }
}

