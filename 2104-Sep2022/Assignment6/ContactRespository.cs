using _2104_Sep2022.Assignment5;
using _2104_Sep2022.Week1Quiz;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment6
{
    public class ContactRespository : IContactRepository
    {
        public string GetConnectionString()
        {
            var appConfigReader = new AppConfigReader();
            appConfigReader.ReadConnectionStrings();

            var connString = appConfigReader.GetConnctionString("ProjectContactDev");
            if (string.IsNullOrWhiteSpace(connString))
            {
                Console.WriteLine("connection string was NOT FOUND");
            }

            return connString;
        }

        public List<Contact> Get(int Count = 10)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            string sqlCommandText = $"SELECT TOP {Count} * FROM CONTACT";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandText, connection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"Row: ContactID: {row["contactID"]}, firstName: {row["firstName"]} lastName: {row["lastName"]} companyName: {row["companyName"]} phoneNumber: {row["phoneNumber"]} personalEmail: {row["personalEmail"]} workEmail: {row["workEmail"]} personalAddress: {row["personalAddress"]}, workAddress: {row["workAddress"]}, contactURL: {row["contactURL"]}, contactNotes: {row["contactNotes"]}, sourceOfIntroduction: {row["sourceOfIntroduction"]}, linkedContacts: {row["linkedContacts"]}");
            }

            List<Contact> contacts = new List<Contact>();
            foreach (DataRow row in dataTable.Rows)
            {
                contacts.Add((Contact)row["contactID"]);
                contacts.Add((Contact)row["firstName"]);
                contacts.Add((Contact)row["lastName"]);
                contacts.Add((Contact)row["companyName"]);
                contacts.Add((Contact)row["phoneNumber"]);
                contacts.Add((Contact)row["personalEmail"]);
                contacts.Add((Contact)row["workEmail"]);
                contacts.Add((Contact)row["personalAddress"]);
                contacts.Add((Contact)row["workAddress"]);
                contacts.Add((Contact)row["contactURL"]);
                contacts.Add((Contact)row["contactNotes"]);
                contacts.Add((Contact)row["sourceOfIntroduction"]);
                contacts.Add((Contact)row["linkedContacts"]);

            }
            connection.Close();
            return contacts;

        }


        public void Insert(Contact contact)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            string sqlCommandText = "INSERT INTO CONTACT VALUES ('1','Steven', 'Uhm', 'Microsoft', '905-354-7319', 'usteve@yahoo.ca', 'usteve@microsoft.ca', '888 Verity Ln', '1903 WestView Ave', 'usteve@portfolio.com', 'A employee studying about computer science', 'Workfriend through linkedIN', 'jimmyT@hotmail.com')";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandText, connection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            connection.Close();
        }

        public void Delete(string contactID)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            string sqlCommandText = $"DELETE FROM CONTACT WHERE contactID={contactID} Select * from CONTACT";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandText, connection);
            connection.Close();
        }

        public void Update(Contact contact)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            string sqlCommandText = $"UPDATE CONTACT set phoneNumber=236-905-3554 where contactID={contact} Select * from CONTACT";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandText, connection);
            connection.Close();
        }
    }
}
