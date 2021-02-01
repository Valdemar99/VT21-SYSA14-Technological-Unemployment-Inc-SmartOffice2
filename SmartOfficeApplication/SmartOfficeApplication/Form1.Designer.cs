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
            this.components = new System.ComponentModel.Container();
            this.tabControlOffice = new System.Windows.Forms.TabControl();
            this.tabPageBuilding = new System.Windows.Forms.TabPage();
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
            this.labelFeedbackForOfficesTab = new System.Windows.Forms.Label();
            this.dataGridViewOffices = new System.Windows.Forms.DataGridView();
            this.buildingAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventilationSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonViewOffices = new System.Windows.Forms.Button();
            this.labelAddressViewOffices = new System.Windows.Forms.Label();
            this.comboBoxAddressViewOffices = new System.Windows.Forms.ComboBox();
            this.buttonRemoveOffice = new System.Windows.Forms.Button();
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
            this.tabControlOffice.SuspendLayout();
            this.tabPageBuilding.SuspendLayout();
            this.tabPageOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOffice
            // 
            this.tabControlOffice.Controls.Add(this.tabPageBuilding);
            this.tabControlOffice.Controls.Add(this.tabPageOffice);
            this.tabControlOffice.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlOffice.Location = new System.Drawing.Point(0, -2);
            this.tabControlOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlOffice.Name = "tabControlOffice";
            this.tabControlOffice.SelectedIndex = 0;
            this.tabControlOffice.Size = new System.Drawing.Size(1200, 749);
            this.tabControlOffice.TabIndex = 0;
            // 
            // tabPageBuilding
            // 
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
            this.tabPageBuilding.Location = new System.Drawing.Point(4, 31);
            this.tabPageBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBuilding.Name = "tabPageBuilding";
            this.tabPageBuilding.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBuilding.Size = new System.Drawing.Size(1192, 714);
            this.tabPageBuilding.TabIndex = 0;
            this.tabPageBuilding.Text = "Buildings";
            this.tabPageBuilding.UseVisualStyleBackColor = true;
            this.tabPageBuilding.Click += new System.EventHandler(this.tabPageBuilding_Click);
            // 
            // labelListOfBuildings
            // 
            this.labelListOfBuildings.AutoSize = true;
            this.labelListOfBuildings.Location = new System.Drawing.Point(576, 54);
            this.labelListOfBuildings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListOfBuildings.Name = "labelListOfBuildings";
            this.labelListOfBuildings.Size = new System.Drawing.Size(227, 22);
            this.labelListOfBuildings.TabIndex = 36;
            this.labelListOfBuildings.Text = "List of all building addresses:";
            // 
            // labelFeedbackForBuildings
            // 
            this.labelFeedbackForBuildings.AutoSize = true;
            this.labelFeedbackForBuildings.Location = new System.Drawing.Point(39, 265);
            this.labelFeedbackForBuildings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeedbackForBuildings.Name = "labelFeedbackForBuildings";
            this.labelFeedbackForBuildings.Size = new System.Drawing.Size(118, 22);
            this.labelFeedbackForBuildings.TabIndex = 35;
            this.labelFeedbackForBuildings.Text = "feedbackLabel";
            // 
            // listBoxBuildings
            // 
            this.listBoxBuildings.Enabled = false;
            this.listBoxBuildings.FormattingEnabled = true;
            this.listBoxBuildings.ItemHeight = 22;
            this.listBoxBuildings.Location = new System.Drawing.Point(580, 118);
            this.listBoxBuildings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBuildings.Name = "listBoxBuildings";
            this.listBoxBuildings.Size = new System.Drawing.Size(541, 422);
            this.listBoxBuildings.TabIndex = 12;
            // 
            // radioButtonEditBuilding
            // 
            this.radioButtonEditBuilding.AutoSize = true;
            this.radioButtonEditBuilding.Location = new System.Drawing.Point(315, 188);
            this.radioButtonEditBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonEditBuilding.Name = "radioButtonEditBuilding";
            this.radioButtonEditBuilding.Size = new System.Drawing.Size(131, 26);
            this.radioButtonEditBuilding.TabIndex = 11;
            this.radioButtonEditBuilding.TabStop = true;
            this.radioButtonEditBuilding.Text = "Edit building";
            this.radioButtonEditBuilding.UseVisualStyleBackColor = true;
            this.radioButtonEditBuilding.CheckedChanged += new System.EventHandler(this.radioButtonEditBuilding_CheckedChanged_1);
            // 
            // radioButtonAddBuilding
            // 
            this.radioButtonAddBuilding.AutoSize = true;
            this.radioButtonAddBuilding.Location = new System.Drawing.Point(166, 188);
            this.radioButtonAddBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonAddBuilding.Name = "radioButtonAddBuilding";
            this.radioButtonAddBuilding.Size = new System.Drawing.Size(133, 26);
            this.radioButtonAddBuilding.TabIndex = 10;
            this.radioButtonAddBuilding.TabStop = true;
            this.radioButtonAddBuilding.Text = "Add building";
            this.radioButtonAddBuilding.UseVisualStyleBackColor = true;
            this.radioButtonAddBuilding.CheckedChanged += new System.EventHandler(this.radioButtonAddBuilding_CheckedChanged_2);
            // 
            // labelOldAddress
            // 
            this.labelOldAddress.AutoSize = true;
            this.labelOldAddress.Location = new System.Drawing.Point(39, 54);
            this.labelOldAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldAddress.Name = "labelOldAddress";
            this.labelOldAddress.Size = new System.Drawing.Size(104, 22);
            this.labelOldAddress.TabIndex = 9;
            this.labelOldAddress.Text = "Old address:";
            // 
            // comboBoxOldAddress
            // 
            this.comboBoxOldAddress.FormattingEnabled = true;
            this.comboBoxOldAddress.Location = new System.Drawing.Point(166, 49);
            this.comboBoxOldAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOldAddress.Name = "comboBoxOldAddress";
            this.comboBoxOldAddress.Size = new System.Drawing.Size(278, 30);
            this.comboBoxOldAddress.TabIndex = 8;
            // 
            // labelAddressDelete
            // 
            this.labelAddressDelete.AutoSize = true;
            this.labelAddressDelete.Location = new System.Drawing.Point(39, 489);
            this.labelAddressDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddressDelete.Name = "labelAddressDelete";
            this.labelAddressDelete.Size = new System.Drawing.Size(74, 22);
            this.labelAddressDelete.TabIndex = 7;
            this.labelAddressDelete.Text = "Address:";
            // 
            // comboBoxAddressDelete
            // 
            this.comboBoxAddressDelete.FormattingEnabled = true;
            this.comboBoxAddressDelete.Location = new System.Drawing.Point(166, 485);
            this.comboBoxAddressDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAddressDelete.Name = "comboBoxAddressDelete";
            this.comboBoxAddressDelete.Size = new System.Drawing.Size(278, 30);
            this.comboBoxAddressDelete.TabIndex = 6;
            this.comboBoxAddressDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddressDelete_SelectedIndexChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(39, 123);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 22);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address:";
            // 
            // buttonDeleteBuilding
            // 
            this.buttonDeleteBuilding.Location = new System.Drawing.Point(166, 543);
            this.buttonDeleteBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteBuilding.Name = "buttonDeleteBuilding";
            this.buttonDeleteBuilding.Size = new System.Drawing.Size(189, 35);
            this.buttonDeleteBuilding.TabIndex = 4;
            this.buttonDeleteBuilding.Text = "Remove building";
            this.buttonDeleteBuilding.UseVisualStyleBackColor = true;
            this.buttonDeleteBuilding.Click += new System.EventHandler(this.buttonDeleteBuilding_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(166, 118);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(278, 28);
            this.textBoxAddress.TabIndex = 3;
            // 
            // buttonAddBuilding
            // 
            this.buttonAddBuilding.Location = new System.Drawing.Point(166, 225);
            this.buttonAddBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddBuilding.Name = "buttonAddBuilding";
            this.buttonAddBuilding.Size = new System.Drawing.Size(189, 35);
            this.buttonAddBuilding.TabIndex = 0;
            this.buttonAddBuilding.Text = "Add building";
            this.buttonAddBuilding.UseVisualStyleBackColor = true;
            this.buttonAddBuilding.Click += new System.EventHandler(this.buttonAddBuilding_Click);
            // 
            // tabPageOffice
            // 
            this.tabPageOffice.Controls.Add(this.labelFeedbackForOfficesTab);
            this.tabPageOffice.Controls.Add(this.dataGridViewOffices);
            this.tabPageOffice.Controls.Add(this.buttonViewOffices);
            this.tabPageOffice.Controls.Add(this.labelAddressViewOffices);
            this.tabPageOffice.Controls.Add(this.comboBoxAddressViewOffices);
            this.tabPageOffice.Controls.Add(this.buttonRemoveOffice);
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
            this.tabPageOffice.Location = new System.Drawing.Point(4, 31);
            this.tabPageOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageOffice.Name = "tabPageOffice";
            this.tabPageOffice.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageOffice.Size = new System.Drawing.Size(1192, 714);
            this.tabPageOffice.TabIndex = 1;
            this.tabPageOffice.Text = "Offices";
            this.tabPageOffice.UseVisualStyleBackColor = true;
            // 
            // labelFeedbackForOfficesTab
            // 
            this.labelFeedbackForOfficesTab.AutoSize = true;
            this.labelFeedbackForOfficesTab.Location = new System.Drawing.Point(39, 674);
            this.labelFeedbackForOfficesTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeedbackForOfficesTab.Name = "labelFeedbackForOfficesTab";
            this.labelFeedbackForOfficesTab.Size = new System.Drawing.Size(118, 22);
            this.labelFeedbackForOfficesTab.TabIndex = 34;
            this.labelFeedbackForOfficesTab.Text = "feedbackLabel";
            // 
            // dataGridViewOffices
            // 
            this.dataGridViewOffices.AutoGenerateColumns = false;
            this.dataGridViewOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingAddress,
            this.officeNumber,
            this.ventilationSetting,
            this.temperatureSetting});
            this.dataGridViewOffices.DataSource = this.officeBindingSource;
            this.dataGridViewOffices.Location = new System.Drawing.Point(634, 188);
            this.dataGridViewOffices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOffices.Name = "dataGridViewOffices";
            this.dataGridViewOffices.RowHeadersWidth = 62;
            this.dataGridViewOffices.Size = new System.Drawing.Size(468, 462);
            this.dataGridViewOffices.TabIndex = 33;
            this.dataGridViewOffices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOffices_CellContentClick);
            // 
            // buildingAddress
            // 
            this.buildingAddress.HeaderText = "Building Address";
            this.buildingAddress.MinimumWidth = 8;
            this.buildingAddress.Name = "buildingAddress";
            this.buildingAddress.ReadOnly = true;
            this.buildingAddress.Width = 150;
            // 
            // officeNumber
            // 
            this.officeNumber.HeaderText = "Office Number";
            this.officeNumber.MinimumWidth = 8;
            this.officeNumber.Name = "officeNumber";
            this.officeNumber.ReadOnly = true;
            this.officeNumber.Width = 150;
            // 
            // ventilationSetting
            // 
            this.ventilationSetting.HeaderText = "Ventilation Setting";
            this.ventilationSetting.MinimumWidth = 8;
            this.ventilationSetting.Name = "ventilationSetting";
            this.ventilationSetting.ReadOnly = true;
            this.ventilationSetting.Width = 150;
            // 
            // temperatureSetting
            // 
            this.temperatureSetting.HeaderText = "Temperature Setting";
            this.temperatureSetting.MinimumWidth = 8;
            this.temperatureSetting.Name = "temperatureSetting";
            this.temperatureSetting.ReadOnly = true;
            this.temperatureSetting.Width = 150;
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            // 
            // buttonViewOffices
            // 
            this.buttonViewOffices.Location = new System.Drawing.Point(822, 117);
            this.buttonViewOffices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonViewOffices.Name = "buttonViewOffices";
            this.buttonViewOffices.Size = new System.Drawing.Size(189, 35);
            this.buttonViewOffices.TabIndex = 32;
            this.buttonViewOffices.Text = "View offices";
            this.buttonViewOffices.UseVisualStyleBackColor = true;
            this.buttonViewOffices.Click += new System.EventHandler(this.buttonViewOffices_Click);
            // 
            // labelAddressViewOffices
            // 
            this.labelAddressViewOffices.AutoSize = true;
            this.labelAddressViewOffices.Location = new System.Drawing.Point(630, 58);
            this.labelAddressViewOffices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddressViewOffices.Name = "labelAddressViewOffices";
            this.labelAddressViewOffices.Size = new System.Drawing.Size(74, 22);
            this.labelAddressViewOffices.TabIndex = 31;
            this.labelAddressViewOffices.Text = "Address:";
            // 
            // comboBoxAddressViewOffices
            // 
            this.comboBoxAddressViewOffices.FormattingEnabled = true;
            this.comboBoxAddressViewOffices.Location = new System.Drawing.Point(822, 54);
            this.comboBoxAddressViewOffices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAddressViewOffices.Name = "comboBoxAddressViewOffices";
            this.comboBoxAddressViewOffices.Size = new System.Drawing.Size(278, 30);
            this.comboBoxAddressViewOffices.TabIndex = 30;
            // 
            // buttonRemoveOffice
            // 
            this.buttonRemoveOffice.Location = new System.Drawing.Point(231, 614);
            this.buttonRemoveOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveOffice.Name = "buttonRemoveOffice";
            this.buttonRemoveOffice.Size = new System.Drawing.Size(189, 35);
            this.buttonRemoveOffice.TabIndex = 29;
            this.buttonRemoveOffice.Text = "Remove office";
            this.buttonRemoveOffice.UseVisualStyleBackColor = true;
            this.buttonRemoveOffice.Click += new System.EventHandler(this.buttonRemoveOffice_Click);
            // 
            // labelOfficeNumberDelete
            // 
            this.labelOfficeNumberDelete.AutoSize = true;
            this.labelOfficeNumberDelete.Location = new System.Drawing.Point(39, 558);
            this.labelOfficeNumberDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfficeNumberDelete.Name = "labelOfficeNumberDelete";
            this.labelOfficeNumberDelete.Size = new System.Drawing.Size(126, 22);
            this.labelOfficeNumberDelete.TabIndex = 28;
            this.labelOfficeNumberDelete.Text = "Office Number:";
            // 
            // comboBoxOfficeNumberDelete
            // 
            this.comboBoxOfficeNumberDelete.FormattingEnabled = true;
            this.comboBoxOfficeNumberDelete.Location = new System.Drawing.Point(231, 554);
            this.comboBoxOfficeNumberDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOfficeNumberDelete.Name = "comboBoxOfficeNumberDelete";
            this.comboBoxOfficeNumberDelete.Size = new System.Drawing.Size(278, 30);
            this.comboBoxOfficeNumberDelete.TabIndex = 27;
            this.comboBoxOfficeNumberDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfficeNumberDelete_SelectedIndexChanged);
            // 
            // labelOfficeAddressDelete
            // 
            this.labelOfficeAddressDelete.AutoSize = true;
            this.labelOfficeAddressDelete.Location = new System.Drawing.Point(39, 489);
            this.labelOfficeAddressDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfficeAddressDelete.Name = "labelOfficeAddressDelete";
            this.labelOfficeAddressDelete.Size = new System.Drawing.Size(74, 22);
            this.labelOfficeAddressDelete.TabIndex = 26;
            this.labelOfficeAddressDelete.Text = "Address:";
            // 
            // comboBoxOfficeAddressDelete
            // 
            this.comboBoxOfficeAddressDelete.FormattingEnabled = true;
            this.comboBoxOfficeAddressDelete.Location = new System.Drawing.Point(231, 485);
            this.comboBoxOfficeAddressDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOfficeAddressDelete.Name = "comboBoxOfficeAddressDelete";
            this.comboBoxOfficeAddressDelete.Size = new System.Drawing.Size(278, 30);
            this.comboBoxOfficeAddressDelete.TabIndex = 25;
            this.comboBoxOfficeAddressDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfficeAddressDelete_SelectedIndexChanged);
            // 
            // radioButtonEditOffice
            // 
            this.radioButtonEditOffice.AutoSize = true;
            this.radioButtonEditOffice.Location = new System.Drawing.Point(380, 354);
            this.radioButtonEditOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonEditOffice.Name = "radioButtonEditOffice";
            this.radioButtonEditOffice.Size = new System.Drawing.Size(110, 26);
            this.radioButtonEditOffice.TabIndex = 24;
            this.radioButtonEditOffice.TabStop = true;
            this.radioButtonEditOffice.Text = "Edit office";
            this.radioButtonEditOffice.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddOffice
            // 
            this.radioButtonAddOffice.AutoSize = true;
            this.radioButtonAddOffice.Location = new System.Drawing.Point(231, 354);
            this.radioButtonAddOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonAddOffice.Name = "radioButtonAddOffice";
            this.radioButtonAddOffice.Size = new System.Drawing.Size(112, 26);
            this.radioButtonAddOffice.TabIndex = 23;
            this.radioButtonAddOffice.TabStop = true;
            this.radioButtonAddOffice.Text = "Add office";
            this.radioButtonAddOffice.UseVisualStyleBackColor = true;
            // 
            // buttonAddOffice
            // 
            this.buttonAddOffice.Location = new System.Drawing.Point(231, 391);
            this.buttonAddOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddOffice.Name = "buttonAddOffice";
            this.buttonAddOffice.Size = new System.Drawing.Size(189, 35);
            this.buttonAddOffice.TabIndex = 22;
            this.buttonAddOffice.Text = "Add office";
            this.buttonAddOffice.UseVisualStyleBackColor = true;
            // 
            // labelSelectedTemperature
            // 
            this.labelSelectedTemperature.AutoSize = true;
            this.labelSelectedTemperature.Location = new System.Drawing.Point(159, 265);
            this.labelSelectedTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedTemperature.Name = "labelSelectedTemperature";
            this.labelSelectedTemperature.Size = new System.Drawing.Size(60, 22);
            this.labelSelectedTemperature.TabIndex = 19;
            this.labelSelectedTemperature.Text = "(26 °C)";
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.Location = new System.Drawing.Point(231, 265);
            this.trackBarTemperature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(280, 69);
            this.trackBarTemperature.TabIndex = 18;
            // 
            // comboBoxVentilationSetting
            // 
            this.comboBoxVentilationSetting.FormattingEnabled = true;
            this.comboBoxVentilationSetting.Location = new System.Drawing.Point(231, 188);
            this.comboBoxVentilationSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxVentilationSetting.Name = "comboBoxVentilationSetting";
            this.comboBoxVentilationSetting.Size = new System.Drawing.Size(278, 30);
            this.comboBoxVentilationSetting.TabIndex = 17;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(39, 265);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(112, 22);
            this.labelTemperature.TabIndex = 16;
            this.labelTemperature.Text = "Temperature:";
            // 
            // labelVentilationSetting
            // 
            this.labelVentilationSetting.AutoSize = true;
            this.labelVentilationSetting.Location = new System.Drawing.Point(39, 192);
            this.labelVentilationSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVentilationSetting.Name = "labelVentilationSetting";
            this.labelVentilationSetting.Size = new System.Drawing.Size(156, 22);
            this.labelVentilationSetting.TabIndex = 14;
            this.labelVentilationSetting.Text = "Ventilation Setting:";
            // 
            // labelOfficeNumber
            // 
            this.labelOfficeNumber.AutoSize = true;
            this.labelOfficeNumber.Location = new System.Drawing.Point(39, 123);
            this.labelOfficeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfficeNumber.Name = "labelOfficeNumber";
            this.labelOfficeNumber.Size = new System.Drawing.Size(126, 22);
            this.labelOfficeNumber.TabIndex = 13;
            this.labelOfficeNumber.Text = "Office Number:";
            // 
            // comboBoxOfficeNumber
            // 
            this.comboBoxOfficeNumber.FormattingEnabled = true;
            this.comboBoxOfficeNumber.Location = new System.Drawing.Point(231, 118);
            this.comboBoxOfficeNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOfficeNumber.Name = "comboBoxOfficeNumber";
            this.comboBoxOfficeNumber.Size = new System.Drawing.Size(278, 30);
            this.comboBoxOfficeNumber.TabIndex = 12;
            // 
            // labelOfficeAddress
            // 
            this.labelOfficeAddress.AutoSize = true;
            this.labelOfficeAddress.Location = new System.Drawing.Point(39, 54);
            this.labelOfficeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfficeAddress.Name = "labelOfficeAddress";
            this.labelOfficeAddress.Size = new System.Drawing.Size(74, 22);
            this.labelOfficeAddress.TabIndex = 10;
            this.labelOfficeAddress.Text = "Address:";
            // 
            // comboBoxOfficeAddress
            // 
            this.comboBoxOfficeAddress.FormattingEnabled = true;
            this.comboBoxOfficeAddress.Location = new System.Drawing.Point(231, 49);
            this.comboBoxOfficeAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOfficeAddress.Name = "comboBoxOfficeAddress";
            this.comboBoxOfficeAddress.Size = new System.Drawing.Size(278, 30);
            this.comboBoxOfficeAddress.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 743);
            this.Controls.Add(this.tabControlOffice);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Smart Office 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlOffice.ResumeLayout(false);
            this.tabPageBuilding.ResumeLayout(false);
            this.tabPageBuilding.PerformLayout();
            this.tabPageOffice.ResumeLayout(false);
            this.tabPageOffice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonRemoveOffice;
        private System.Windows.Forms.Label labelOfficeNumberDelete;
        private System.Windows.Forms.ComboBox comboBoxOfficeNumberDelete;
        private System.Windows.Forms.Label labelOfficeAddressDelete;
        private System.Windows.Forms.ComboBox comboBoxOfficeAddressDelete;
        private System.Windows.Forms.Button buttonViewOffices;
        private System.Windows.Forms.Label labelAddressViewOffices;
        private System.Windows.Forms.ComboBox comboBoxAddressViewOffices;
        private System.Windows.Forms.DataGridView dataGridViewOffices;
        private System.Windows.Forms.Label labelFeedbackForOfficesTab;
        private System.Windows.Forms.Label labelFeedbackForBuildings;
        private System.Windows.Forms.Label labelListOfBuildings;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventilationSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureSetting;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureSettingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventilationSettingDataGridViewTextBoxColumn;
    }
}

