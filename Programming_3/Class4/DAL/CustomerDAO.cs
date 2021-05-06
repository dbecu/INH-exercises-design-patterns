using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Model;
//using System.Data.SqlClient

namespace DAL
{
    public class CustomerDAO
    {

        private SqlConnection dbConnection;

        //public CustomerDAO()
        //{
        //    string connString = ConfigurationManager
        //        .ConnectionStrings["DBConnectionString"]
        //        .ConnectionString;
        //}

        public List<Customer> GetAll()
        {
            dbConnection.Open();

            SqlCommand
        }

    }
}
