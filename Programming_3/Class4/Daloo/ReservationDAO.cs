using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Model;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class ReservationDAO
    {
        private SqlConnection dbConnection;

        public ReservationDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["secret"]       //database name
                .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        //public List<Reservation> GetAll()
        //{
        //    dbConnection.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Reservations", dbConnection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<Reservation> reservations = new List<Reservation>();

        //    while (reader.Read())
        //    {
        //        Reservation reservation = ReadReservation(reader);
        //        reservations.Add(reservation);
        //    }

        //    reader.Close();
        //    dbConnection.Close();

        //    return reservations;

        //}

        public Reservation GetById(int reservationId)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT * FROM Reservations WHERE Id = @Id", dbConnection);

            command.Parameters.AddWithValue("@Id", reservationId);

            SqlDataReader reader = command.ExecuteReader();
            Reservation reservation = null;

            if (reader.Read())
            {
                reservation = ReadReservation(reader);
            }

            reader.Close();
            dbConnection.Close();

            return reservation;

        }

        public List<Reservation> GetAll()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            BookDAO bookDAO = new BookDAO();

            dbConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Reservations", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Reservation> reservations = new List<Reservation>();

            while (reader.Read())
            {
                int id = (int)reader["Id"];
                int customerId = (int)reader["CustomerId"];
                int bookId = (int)reader["BookId"];

                Customer customer = customerDAO.GetById(customerId);
                Book book = bookDAO.GetById(bookId);
                Reservation reservation = new Reservation(id, customer, book);

                reservations.Add(reservation);
            }

            reader.Close();
            dbConnection.Close();

            return reservations;
        }

        public List<Customer> GetAllForBook(Book book)
        {
            CustomerDAO customerDAO = new CustomerDAO();

            dbConnection.Open();

            SqlCommand command = new SqlCommand(
            "SELECT * FROM Reservations " +
            "WHERE BookId = @BookId", dbConnection);

            command.Parameters.AddWithValue("@BookId", book.Id);
            SqlDataReader reader = command.ExecuteReader();
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                int customerId = (int)reader["CustomerId"];
                Customer customer = customerDAO.GetById(customerId);
                customers.Add(customer);
            }

            reader.Close();
            dbConnection.Close();

            return customers;
        }

        public List<Book> getAllForCustomer(Customer customer)
        {
            BookDAO bookDAO = new BookDAO();

            dbConnection.Open();

            SqlCommand command = new SqlCommand(
            "SELECT * FROM Reservations " +
            "WHERE CustomerId = @CustomerId", dbConnection);

            command.Parameters.AddWithValue("@CustomerId", customer.Id);
            SqlDataReader reader = command.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                int bookId = (int)reader["BookId"];
                Book book = bookDAO.GetById(bookId);
                books.Add(book);
            }

            reader.Close();
            dbConnection.Close();

            return books;
        }



        private Reservation ReadReservation(SqlDataReader reader)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            BookDAO bookDAO = new BookDAO();

            int id = (int)reader["Id"];
            int customerId = (int)reader["CustomerId"];
            int bookId = (int)reader["BookId"];

            Customer customer = customerDAO.GetById(customerId);
            Book book = bookDAO.GetById(bookId);

            return new Reservation(id, customer, book);
        }
    }
}
