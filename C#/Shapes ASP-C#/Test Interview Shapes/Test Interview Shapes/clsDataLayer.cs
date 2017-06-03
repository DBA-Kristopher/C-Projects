using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Net;
using System.Data;
namespace Test_Interview_Shapes
{
    public class clsDataLayer
    {



        public clsDataLayer()
        {
        }
  

        /////////////////////////////////////////////////////////////////////////////////////////////
        // This function saves the personnel data
        public static bool SavePersonnel(string Database, string Shape, int Height)
        {

            // Transaction for SQL
            OleDbTransaction myTransaction = null;

            bool recordSaved;
            try
            {
                // Opens connections to database and creates a command
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;

                // Setting value to myTransaction
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;

                // Sets value
                strSQL = "Insert into Shapes " +
                "(Shape, Height) values ('" +
                Shape + "', '" + Height + "')";
               
              
             

                // Receives input
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Executes query
                command.ExecuteNonQuery();

                // Commit changes to myTransaction
                myTransaction.Commit();

                // Closes connection
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {

                // Rollback changes
                myTransaction.Rollback();

                recordSaved = false;
            }
            return recordSaved;
        }



        ////////////////////////////////////////////////////////////////////////
        public static DataSet1 GetPersonnel(string Database, string strSearch)
        {
            // Retreives information
            DataSet1 DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Creates new connection
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            // Defines sqlDA and what it consist of
            if (strSearch == null || strSearch.Trim() == "")
            {
                sqlDA = new OleDbDataAdapter("select * from Shapes", sqlConn);
            }
            else
            {
                sqlDA = new OleDbDataAdapter("select * from Shapes where Height = '" + strSearch + "'", sqlConn);
            }
            // Defines DS and what it consist of
            DS = new DataSet1();
            // Outputs the result from information gathered
            sqlDA.Fill(DS.Shapes);
            // Starts over for new user
            return DS;
        }

    }
}