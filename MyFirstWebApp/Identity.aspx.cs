using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Identity : System.Web.UI.Page
    {
        SqlConnection myConnection;
        SqlCommand cmdTest;
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection("uid=Shadowman4444;" + "pwd=Password69;" + "server=techpreneurs.cbljq0uymiqe.ap-southeast-2.rds.amazonaws.com, 1433;" +
                            "database=Techpreneurs;");

            try
            {
                myConnection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;

            string result = "Hello " + firstName + " " + lastName + ".";

            resultLabel.Text = result;
        }

        protected void closeConnection_Click(object sender, EventArgs e)
        {
            myConnection = new SqlConnection("uid=Shadowman4444;" + "pwd=Password69;" + "server=techpreneurs.cbljq0uymiqe.ap-southeast-2.rds.amazonaws.com, 1433;" +
                            "database=Techpreneurs;");
            try
            {
                myConnection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            cmdTest = new SqlCommand();
            cmdTest.CommandText = "SELECT * FROM INDUSTRY";
            cmdTest.CommandType = CommandType.Text;
            cmdTest.Connection = myConnection;

            reader = cmdTest.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataLabel.Text += " " + reader.GetInt32(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ".";
                }
            }
            else
            {
                Console.WriteLine("No rows mate");
            }

            myConnection.Close();
        }
    }
}