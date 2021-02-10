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
        private DataAccessLayer dataAccessLayer = new DataAccessLayer();
        private ErrorHandler errorHandler = new ErrorHandler();

        public void UpdateBuildingData() //Updates all comboboxes and lists with buildings.
        {
            comboBoxOfficeAddress.Items.Clear();
            comboBoxOfficeAddressDelete.Items.Clear();
            comboBoxAddressViewOffices.Items.Clear();
            comboBoxOldAddress.Items.Clear();
            comboBoxAddressDelete.Items.Clear();

            listBoxBuildings.Items.Clear();

            SqlDataReader buildingReader = dataAccessLayer.GetBuildings(); //Fetch data and hold it in buildingList.
            while (buildingReader.Read())
            {
                comboBoxOfficeAddress.Items.Add(buildingReader.GetString(0));
                comboBoxOfficeAddressDelete.Items.Add(buildingReader.GetString(0));
                comboBoxAddressViewOffices.Items.Add(buildingReader.GetString(0));
                comboBoxOldAddress.Items.Add(buildingReader.GetString(0));
                comboBoxAddressDelete.Items.Add(buildingReader.GetString(0));
                listBoxBuildings.Items.Add(buildingReader.GetString(0));
            }
            buildingReader.Close();
            dataAccessLayer.CloseConnection();
        }

        public Form1()
        {
            InitializeComponent();
            fillVentilationSettingComboBox();
            UpdateBuildingData();
        }


        /*****************.
           *  Button             addBuilding
           *   Description        button that, if successful, adds a building in the database by checking if the radiobutton radioButtonAddBuilding has been 
                                   selected and then if the textbox has any content. It also checks the database if the address already exists before adding
                                   it to the database. Though if radiobutton radioButtonEditBuilding has been selected the address can be altered using the
                                   combination of combobox(for the old address) and textbox(to insert new address).
           ***********/
        private void buttonAddBuilding_Click(object sender, EventArgs e) 
        {
            labelFeedbackForBuildings.ResetText(); //return the label to default 
            string newAddress = textBoxAddress.Text; //retrieves text from textbox

           if (radioButtonAddBuilding.Checked == true)
            {
                if (newAddress.Equals(""))//Error message if the textbox is empty
                {
                    labelFeedbackForBuildings.Text = "To add a new building, please insert address.";
                }

                else
                {
                    if (dataAccessLayer.checkIfBuildingExists(newAddress) != true) //Checks if the address doesn't exist in the database, if so, adds a new building
                    {
                        dataAccessLayer.AddBuilding(newAddress);
                        labelFeedbackForBuildings.Text = "The building with address'" + newAddress + "' has been successfully added to database.";
                        UpdateBuildingData();
                    }
                    if (dataAccessLayer.checkIfBuildingExists(newAddress) == true) // If the address already exists it sends an error message
                    {
                        labelFeedbackForBuildings.Text = "This building with inserted address already exists in our database.";
                    }
                }

            }

           if (radioButtonEditBuilding.Checked == true) //If edit building is chosen
            {
                string oldAddress = comboBoxOldAddress.SelectedItem.ToString();

                //Checks if the old address doesn't exist in the database, if so, change to address in new address textbox
                if (dataAccessLayer.checkIfBuildingExists(oldAddress) == true)
                {
                    if (newAddress.Equals(""))//Error message if the textbox is empty
                    {
                        labelFeedbackForBuildings.Text = "To edit a new building, please insert the new address.";
                    }
                    else
                    { //Checks if the new address doesn't exist in the database, if so, edits the old address to the new one
                        if(dataAccessLayer.checkIfBuildingExists(newAddress) != true)
                        {
                            dataAccessLayer.EditBuilding(oldAddress, newAddress);
                            labelFeedbackForBuildings.Text = "The building with address'" + oldAddress + "' has been successfully changed into '" + newAddress + "' within the database.";
                            UpdateBuildingData();

                        }
                        if (dataAccessLayer.checkIfBuildingExists(newAddress) == true) // If the new address already exists it sends an error message
                        {
                            labelFeedbackForBuildings.Text = "This building with inserted new address already exists in our database. Please try another another address.";
                        }

                    }


                }

            }

            else
            {
                labelFeedbackForBuildings.Text = "To add a new building, please press the radiobutton add building."; //fixa så edit är med
            }

        }
          private void comboBoxAddressDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonDeleteBuilding_Click(object sender, EventArgs e)
        {

            labelFeedbackForBuildings.ResetText();
            
            string address = comboBoxAddressDelete.SelectedItem.ToString();
            dataAccessLayer.RemoveBuilding(address);
            dataAccessLayer.CloseConnection();

            labelFeedbackForBuildings.Text = "Building has been removed!";
            UpdateBuildingData();
        }

        private void buttonViewOffices_Click(object sender, EventArgs e) //Displays all offices on a selected address. If no address is selected, an error message is displayed in a text label at the bottom of the frame.
        {
            try
            {
                string selectedAddress = comboBoxAddressViewOffices.SelectedValue.ToString();
                SqlDataReader offices = dataAccessLayer.GetOffices(selectedAddress);
                DataTable officeTable = new DataTable();
                officeTable.Load(offices);
                dataGridViewOffices.DataSource = officeTable;
            }
            catch (NullReferenceException exception)
            {
                labelFeedbackForOffices.Text = "Please select a valid address to display its offices. If there are no addresses please create one.";
            }
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            labelSelectedTemperature.Text = trackBarTemperature.Value + " °C";
        }

        private void buttonRemoveOffice_Click(object sender, EventArgs e)
        {
            string number = comboBoxOfficeNumberDelete.SelectedItem.ToString();
            string address = comboBoxOfficeAddressDelete.SelectedItem.ToString();
            dataAccessLayer.RemoveOffice(number, address);
        }

       

        private void comboBoxOfficeAddressDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOfficeAddressDelete.SelectedIndex != -1) //If an object in the combobox is selected, the combobox with office numbers is updated.
            {
                string selectedAddress = comboBoxOfficeAddressDelete.SelectedItem.ToString();
                FillOfficeNumberComboBox(selectedAddress, comboBoxOfficeNumberDelete);
            }
            else
            {
                comboBoxOfficeNumberDelete.Items.Clear();
            }
        }
        /*****************.
           *  Button             addOffice
           *   Description        button that, if successful, adds an office in the database by checking if the radiobutton radioButtonAddOffice has been 
                                   selected and then if the textbox has any content. It also automatically allocates an office number.
                                   Though if radiobutton radioButtonEditBuilding has been selected the address can be altered using the
                                   combination of comboboxes for selecting a building address, office number, ventilation setting and temperature setting.
                                   TO-DO: office numbers should be autogenerated from the SQL side of the application.
           ***********/
        private void buttonAddOffice_Click(object sender, EventArgs e)
        {
            labelFeedbackForOffices.ResetText(); //return the label to default 
            string buildingAddress = comboBoxOfficeAddress.SelectedItem.ToString(); //retrieves address
            string ventilationSetting = comboBoxVentilationSetting.SelectedItem.ToString(); //retrieves ventilation setting
            int temperatureSetting = trackBarTemperature.Value;

            if (radioButtonAddOffice.Checked == true)
            {
                buttonAddOffice.Text = "Add office";
                comboBoxOfficeNumber.Enabled = false; //disables a choice of office number.
                if (buildingAddress.Equals(""))//Error message if the combobox is empty
                {
                    labelFeedbackForOffices.Text = "To add a new office, please insert an address.";
                }
                else if (ventilationSetting.Equals(""))
                {
                    labelFeedbackForOffices.Text = "To add a new office, please choose a ventilation setting.";
                }
                string officeNumber = dataAccessLayer.AddOffice(buildingAddress, temperatureSetting, ventilationSetting);
                string feedbackString =  "The office with number " + officeNumber + "  and address " + buildingAddress + " has been successfully added to the database.";
                labelFeedbackForOffices.Text = feedbackString;
            }

            else if (radioButtonEditOffice.Checked == true) //If edit building is chosen
            {
                buttonAddOffice.Text = "Edit office";
                comboBoxOfficeNumber.Enabled = true; //enables a choice of office number.
                object officeNumberObject = comboBoxOfficeNumber.SelectedItem;
                if (buildingAddress.Equals(""))//Error message if no address is chosen
                {
                    labelFeedbackForOffices.Text = "To edit this office, please insert an address.";
                }
                else if (ventilationSetting.Equals("")) //Error message if no ventilation setting is chosen
                {
                    labelFeedbackForOffices.Text = "To edit this office, please choose a ventilation setting.";
                }
                else if (officeNumberObject == null) //Error message if no office number is chosen
                {
                    labelFeedbackForOffices.Text = "To edit an office, please choose an office number.";
                }
                else
                {
                    string officeNumberToEdit = officeNumberObject.ToString();
                    dataAccessLayer.EditOffice(officeNumberToEdit, buildingAddress, ventilationSetting, temperatureSetting);
                    labelFeedbackForOffices.Text = "The office with address'" + buildingAddress + "' and office number '" + officeNumberToEdit + "' has been successfully edited.";
                }
            }
            else
            {
                labelFeedbackForOffices.Text = "To add a new office, please press the radiobutton add office."; //fixa så edit är med
            }
        }

        private void comboBoxOfficeAddress_SelectedIndexChanged(object sender, EventArgs e) //Updates the office number combobox under the address combobox
        {
            if (comboBoxOfficeAddress.SelectedItem.ToString() != "") //If an object in the combobox is selected, the combobox with office numbers is updated.
            {
                string selectedAddress = comboBoxOfficeAddress.SelectedItem.ToString();
                FillOfficeNumberComboBox(selectedAddress, comboBoxOfficeNumber);
            }
            else
            {
                comboBoxOfficeNumber.Items.Clear();
            }
        }

        private void radioButtonAddOffice_CheckedChanged(object sender, EventArgs e) //Changes the text on the button from "Edit office" to "Add office" or vice versa depending on the selected radio button.
        {
            if(radioButtonAddOffice.Checked)
            {
                buttonAddOffice.Text = "Add office";
            }
            else
            {
                buttonAddOffice.Text = "Edit office";
            }
        }

        private void fillVentilationSettingComboBox()
        {
            VentilationSetting vS = new VentilationSetting();
            comboBoxVentilationSetting.DataSource = vS.VentilationSettingList.ToList<string>();
        }
        private void FillOfficeNumberComboBox(string buildingAddress, ComboBox officeNumberComboBox)
        {
            //comboBoxOfficeAddress.Items.Clear();
            //comboBoxOfficeAddressDelete.Items.Clear();
            //comboBoxAddressViewOffices.Items.Clear();
            //comboBoxOldAddress.Items.Clear();
            //comboBoxAddressDelete.Items.Clear();

            //listBoxBuildings.Items.Clear();

            //SqlDataReader buildingReader = dataAccessLayer.GetBuildings(); //Fetch data and hold it in buildingList.
            //while (buildingReader.Read())
            //{
            //    comboBoxOfficeAddress.Items.Add(buildingReader.GetString(0));
            //    comboBoxOfficeAddressDelete.Items.Add(buildingReader.GetString(0));
            //    comboBoxAddressViewOffices.Items.Add(buildingReader.GetString(0));
            //    comboBoxOldAddress.Items.Add(buildingReader.GetString(0));
            //    comboBoxAddressDelete.Items.Add(buildingReader.GetString(0));
            //    listBoxBuildings.Items.Add(buildingReader.GetString(0));
            //}
            //buildingReader.Close();
            //dataAccessLayer.CloseConnection();

            officeNumberComboBox.Items.Clear();
            SqlDataReader officeReader = dataAccessLayer.GetOffices(buildingAddress); //Fetch data and hold it in buildingList.
            while (officeReader.Read())
            {
                officeNumberComboBox.Items.Add(officeReader.GetString(1));
            }
            officeReader.Close();
            dataAccessLayer.CloseConnection();
        }

        private void radioButtonAddBuilding_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddBuilding.Checked)
            {
                buttonAddBuilding.Text = "Add building";
            }
            else
            {
                buttonAddBuilding.Text = "Edit building";

            }
        }
    }
}

