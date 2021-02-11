using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2ViewMetadata
{
    public partial class FormForMetadata : Form
    {
        DataAccessLayerForMetaData data = new DataAccessLayerForMetaData();
        public void UpdateTablesOfInterest()
        {
            dataGridViewTablesOfInterest.DataSource = data.GetTablesOfInterest();
        }
        public FormForMetadata()
        {
            InitializeComponent();
            UpdateTablesOfInterest();
           // UpdateTables();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
           // UpdateTables();
        }

        //private void UpdateTables()
        //{
        //    DataTable tableNames = data.GetTablesOfInterest();
        //    comboBoxTables.DataSource = tableNames;
        //    comboBoxTables.DisplayMember = "Name";
        //    comboBoxTables.ValueMember = "Name";
        //}
        //private void UpdateColumns(string tableName)
        //{
            
        //    DataTable dt = data.GetAllColumns(selectedTableName)
        //    cbxparameter.DataSource = dt;
        //    cbxparameter.DisplayMember = "ItemName";
        //    cbxparameter.ValueMember = "ItemName";
        //}
    }
}
