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
        public FormForMetadata()
        {
            InitializeComponent();
            UpdateComboBoxWithTables();
            UpdateColumnTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateComboBoxWithTables();
        }

        private void UpdateColumnTable()
        {
            DataTable columnList = data.GetAllTables();
            dataGridViewColumns.DataSource = columnList;
        }

        private void UpdateComboBoxWithTables()
        {
            DataTable tableNames = data.GetTablesOfInterest();
            comboBoxTables.DataSource = tableNames;
            comboBoxTables.DisplayMember = "tableName";
            comboBoxTables.ValueMember = "tableName";
        }
        private void UpdateColumnList(string tableName)
        {
            DataTable columnList = data.GetAllColumns(tableName);
            listBoxColumns.DataSource = columnList;
            listBoxColumns.DisplayMember = "name";
            listBoxColumns.ValueMember = "name";
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tableName = comboBoxTables.SelectedValue.ToString();
                UpdateColumnList(tableName);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("was null");
            }

        }
    }
}
