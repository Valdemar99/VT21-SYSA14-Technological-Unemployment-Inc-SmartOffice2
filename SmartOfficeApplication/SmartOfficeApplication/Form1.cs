using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
          private void comboBoxAddressDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonDeleteBuilding_Click(object sender, EventArgs e)
        {

            labelFeedbackForBuildings.ResetText();
            if (radioButtonAddBuilding.Checked == true)
            {
                string address = comboBoxAddressDelete.SelectedItem.ToString();
                dataAccessLayer.RemoveBuilding(address);

            }
            labelFeedbackForBuildings.Text = "Building has been removed!";
        }

        private void radioButtonAddBuilding_CheckedChanged_2(object sender, EventArgs e)
        {
           
        }

        private void radioButtonEditBuilding_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
