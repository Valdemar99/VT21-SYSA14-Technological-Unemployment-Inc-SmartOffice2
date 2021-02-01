using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOfficeApplication
{
    public partial class Form1 : Form
    {
        private DataAccessLayer dataAccessLayer;

        public void updateBuildingList() //Update listBoxBuildings with all buildings in the database.
        {
            listBoxBuildings.Items.Clear();
            SqlDataReader buildingReader = dataAccessLayer.GetBuildings(); //Fetch data and hold it in buildingList.
            while (buildingReader.Read())
            {
                listBoxBuildings.Items.Add(buildingReader.GetString(0));
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAddBuilding_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPageBuilding_Click(object sender, EventArgs e)
        {

        }


        private void radioButtonAddBuilding_CheckedChanged_1(object sender, EventArgs e) 
        {

        }

        private void radioButtonEditBuilding_CheckedChanged(object sender, EventArgs e) 
        {

        }

        private void buttonAddBuilding_Click(object sender, EventArgs e) //Knappen
        {

           if (radioButtonAddBuilding.Checked == true)
            {
                string address = textBoxAddress.Text; //skapa felmeddelande för att undvika att lägga till någon som redan finns 

                if (address.Equals(""))
                {
                    //felmeddelande för att textboxen är tom. 
                }
                
                //if(address !=  )
                dataAccessLayer.AddBuilding(address);
            }
           else
            {
                //lägg till felmeddelande 
            }


        }

        private void buttonDeleteBuilding_Click(object sender, EventArgs e)
        {


        }

        private void buttonViewOffices_Click(object sender, EventArgs e)
        {
            string selectedAddress = comboBoxAddressViewOffices.SelectedValue.ToString();
            SqlDataReader offices = dataAccessLayer.GetOffices(selectedAddress);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Smart_Office_2_0DataSet.Office' table. You can move, or remove it, as needed.
            this.officeTableAdapter.Fill(this._Smart_Office_2_0DataSet.Office);

        }

        private void dataGridViewOffices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
