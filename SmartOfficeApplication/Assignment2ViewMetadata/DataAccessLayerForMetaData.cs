using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2ViewMetadata
{
    class DataAccessLayerForMetaData
    {
        private static string serverName = "uwdb18.srv.lu.se";
        private static string instanceName = "icssql001";
        private static string databaseName = "SYSA14_PK_ProgAssignment2";
        private static string userName = "sysa14reader";
        private static string userPassword = "INFreader1";
        private static string connectionString = "Server=" + serverName + "\\" + instanceName + ";Database=" + databaseName + ";User Id = " + userName + "; Password = " + userPassword;

        public DataTable GetTablesOfInterest()
        {
            DataTable tablesOfInterest = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TablesOfInterest", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            tablesOfInterest.Load(dataReader);
                            return tablesOfInterest;
                        }
                    }
                    catch (SqlException exe)
                    {
                        throw exe;
                    }
                }
            }
        }
        public DataTable GetColumnsForTable(string selectedTableName)
        {
            /*
             * SELECT name
                FROM sys.columns c
                WHERE c.object_id = (
                SELECT o.object_id
                FROM sys.objects o
                WHERE o.name = 'tableName')
             */
            String query = "SELECT name FROM sys.columns c " +
                "WHERE c.object_id = (SELECT o.object_id FROM sys.objects o WHERE o.name = '" + selectedTableName + "')";
            DataTable columnTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        columnTable.Load(dataReader);                      
                        return columnTable;
                    }
                }
            }
        }
        public int GetRowCountForTable(string selectedTableName)
        {
            /*
             * SELECT COUNT(*)
                FROM selectedTableName;
             */
            String query = "SELECT COUNT(*) FROM " + selectedTableName + ";";
            int amountOfRows = 0;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                amountOfRows = dataReader.GetInt32(0);
                            } 
                        }
                    }
                }

            }catch(SqlException exe)
            {
                throw exe;
            }
            
            return amountOfRows;
        }

    }
}