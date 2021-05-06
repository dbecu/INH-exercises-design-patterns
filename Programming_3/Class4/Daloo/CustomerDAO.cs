using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Model;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class CustomerDAO
    {

        private SqlConnection dbConnection;

        public CustomerDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["secret"]       //database name
                .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Customer> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                Customer customer = ReadCustomer(reader);
                customers.Add(customer);
            }

            reader.Close();
            dbConnection.Close();

            return customers;

        }

        public Customer GetById(int customerId)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT * FROM Customers WHERE Id = @Id", dbConnection);

            command.Parameters.AddWithValue("@Id", customerId);

            SqlDataReader reader = command.ExecuteReader();
            Customer customer = null;

            if (reader.Read())
            {
                customer = ReadCustomer(reader);
            }

            reader.Close();
            dbConnection.Close();

            return customer;

        }

        private Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string emailAddress = (string)reader["EmailAddress"];

            return new Customer(id, firstName, lastName, emailAddress);
        }

    }
}
