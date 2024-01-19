using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Car_Sales
{
    public class SQLManager
    {
        private SqlConnection sqlConn;
        public SQLManager()
        {
            //If you want me to give you access to the database, message me at s.kozarov23@acsbg.bg
            sqlConn = new SqlConnection("Server = sensitiveInfo; Database = sensitiveInfo; User Id = sensitiveInfo; Password = sensitiveInfo;TrustServerCertificate=True");
        }

        public void InsertNewSaleFromVSToSql(DateTime CurrentDate, string Brand, string Model, int Year, double Price, string Accessories, string FirstName, string LastName, string PhoneNumber, string Adress, string ZipCode, string City)
        {
            try
            {
                sqlConn.Open();
                string query = $"INSERT INTO CarSales (CurrentDate, Brand,Model,Year,Price,Accessories,FirstName,LastName,PhoneNumber,Adress,ZipCode,city) VALUES (@CurrentDate,@brand,@model,@year,@price,@accessories,@firstName,@lastName,@phoneNumber,@adress,@zipCode,@City)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@CurrentDate", CurrentDate);
                cmd.Parameters.AddWithValue("@brand", Brand);
                cmd.Parameters.AddWithValue("@model", Model);
                cmd.Parameters.AddWithValue("@year", Year);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@accessories", Accessories);
                cmd.Parameters.AddWithValue("@firstName", FirstName);
                cmd.Parameters.AddWithValue("@lastName", LastName);
                cmd.Parameters.AddWithValue("@phoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@adress", Adress);
                cmd.Parameters.AddWithValue("@zipCode", ZipCode);
                cmd.Parameters.AddWithValue("@City", City);
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

        }
    }
}
