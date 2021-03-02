using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOfficeApplication
{
    class DataAccessLayer
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Server=localhost;Database=Smart Office 2.0;User Id = user2.0; Password = losen";

        public SqlConnection SqlConnection { get => SqlConnection; set => SqlConnection = value; }

        /*****************.
            *  Function             getBuildings
            *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
            *    Parameters
            *     Returns           SqlDataReader
            ***********/
        public DataTable GetBuildings()
        {
            string queryString = "SELECT * FROM BUILDING";
            DataTable dataTable = PerformQueryReader(queryString);
            return dataTable;

        }
        
        /*****************.
            *  Function             checkIfBuildingExists
            *   Description         Method that returns true if a building with the specified address already exists in the database.
            *    Parameters         string address
            *     Returns           bool
            ***********/
        public bool checkIfBuildingExists(string address)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Building WHERE address = '" + address + "'", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        return dataReader.HasRows;
                    }
                    catch (SqlException e)
                    {
                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        /*****************.
            *  Function             addBuilding
            *   Description         Method that adds a building in the database.
            *    Parameters         string address
            *     Returns           
            ***********/
        public void AddBuilding(string address)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Building VALUES(@address)", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@address", address);

                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {

                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }

            }
        }

        /*****************.
        *  Function             removeBuilding
        *   Description         Method that removes a building from the database and the offices that belong to it.
        *    Parameters         string address
        *     Returns           
        ***********/
        public void RemoveBuilding(string address)
        {
            string queryString = "DELETE FROM Building WHERE address = '" + address + "'";
            PerformQuery(queryString);
            RemoveAllOfficesFromAddress(address);
        }

        /*****************.
        *  Function             RemoveAllOfficesFromAddress
        *   Description         Method that removes all offices from a building.
        *    Parameters         string address
        *     Returns           
        ***********/
        public void RemoveAllOfficesFromAddress(string address)
        {
            string queryString = "DELETE FROM Office WHERE buildingAddress = '" + address + "'";
            PerformQuery(queryString);
        }

        /*****************.
          *  Function             editBuilding
          *   Description         Method that edits a building from the database.
          *    Parameters         string address
          *     Returns           
          ***********/
        public void EditBuilding(string oldAddress, string newAddress)
        {
            string queryString = "UPDATE Building SET address = '" + newAddress + "' WHERE address = '" + oldAddress + "'";
            PerformQuery(queryString);
        }

        /*****************.
        *  Function             findOffice
        *   Description         Method that returns an sqlDataReader with all associated information from database
        *    Parameters         string officeNumber, string buildingAddress
        *     Returns           SqlDataReader
        ***********/
        public DataTable FindOffice(string officeNumber, string buildingAddress)
        {
            string queryString = "SELECT * FROM Office WHERE buildingAddress = '" + buildingAddress + "' AND officeNumber = '" + officeNumber + "'";
            DataTable dataTable = PerformQueryReader(queryString);
            return dataTable;
        }

        /*****************.
            *  Function             GetOffices
            *   Description         Method that, returns an sqlDataReader with all associated information from database
            *    Parameters         string buildingAddress
            *     Returns           SqlDataReader
         ***********/
        public DataTable GetOffices(string buildingAddress)
        {
            string queryString = "SELECT officeNumber, buildingAddress, temperatureSetting, ventilationSetting FROM Office WHERE buildingAddress = '" + buildingAddress + "'";
            DataTable dataTable = PerformQueryReader(queryString);
            return dataTable;
        }

        /*****************.
            *  Function             AddOffice
            *   Description         Method that adds an office in the database. As well as generates a new officeNumber
            *    Parameters         string officeNumber, string buildingAddress, int temperatureSetting, string ventilationSetting
            *     Returns           string with officeNumber
            ***********/
        public void AddOffice(string buildingAddress, int temperatureSetting, string ventilationSetting)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Office (buildingAddress, temperatureSetting, ventilationSetting) VALUES(@buildingAddress, @temperatureSetting, @ventilationSetting) ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@buildingAddress", buildingAddress);
                    sqlCommand.Parameters.AddWithValue("@temperatureSetting", temperatureSetting);
                    sqlCommand.Parameters.AddWithValue("@ventilationSetting", ventilationSetting);

                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {

                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }

            }
        }

        /********************
	 * Function			getMostRecentScenarioID
	 * Description		Method to get the most recent scenario ID. Must be run directly after a row has been added.
	 * Parameters 		
	 * Returns			int
	 * @throws SQLException 
	 * @throws ClassNotFoundException 
	 ********************/
        public string GetMostRecentOfficeNumber()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommandGetOffice = new SqlCommand("SELECT officeNumber FROM Office WHERE ID = (SELECT MAX(ID) FROM Office)", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        string officeNumber;

                        SqlDataReader dataReader = sqlCommandGetOffice.ExecuteReader();
                        dataReader.Read();
                        officeNumber = dataReader.GetString(0);

                        return officeNumber;
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        /*****************.
        *  Function             RemoveOffice
        *   Description         Method that removes an office from the database.
        *    Parameters         string officeNumber, string buildingAddress
        *     Returns           
        ***********/
        public void RemoveOffice(string officeNumber, string buildingAddress)
        {
            string queryString = "DELETE FROM Office WHERE buildingAddress = '" + buildingAddress + "' AND officeNumber = '" + officeNumber + "'";
            PerformQuery(queryString);

        }

        /*****************.
         * Function             editOffice  
         * Description         Method that edits an office from the database.
         * Parameters         string officeNumber, string buildingAddress, string ventilationSetting, int temperatureSetting
         * Returns           
      ***********/
        public void EditOffice(string officeNumber, string buildingAddress, string ventilationSetting, int temperatureSetting)
        {
            string queryString = "UPDATE Office SET ventilationSetting = '" + ventilationSetting + "', temperatureSetting = " + temperatureSetting +
                " WHERE officeNumber = '" + officeNumber + "' AND buildingAddress = '" + buildingAddress + "'";
            PerformQuery(queryString);
        }

        /*****************.
              *  Function             PerformQuery
              *   Description         Method that implements a generic form of errorhandling
              *    Parameters         sqlConnection and sqlCommand
              *     Returns           void
              ***********/
        public void PerformQuery(string queryString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {

                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }

            }

        }

        /*****************.
             *  Function             PerformQueryVoid
             *   Description         Method that implements a generic form of errorhandling
             *    Parameters         sqlConnection and sqlCommand
             *     Returns           sqlReader
             ***********/
        public DataTable PerformQueryReader(string queryString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    DataTable table = new DataTable();

                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        table.Load(dataReader);
                    }
                    catch (SqlException e)
                    {
                        throw e;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                    return table;
                }

            }

        }
    }
    
}




