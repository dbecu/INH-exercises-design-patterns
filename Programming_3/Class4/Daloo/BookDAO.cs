using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Model;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class BookDAO
    {
        private SqlConnection dbConnection;

        public BookDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["secret"]       //database name
                .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }

            reader.Close();
            dbConnection.Close();

            return books;

        }

        public Book GetById(int bookId)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT * FROM Books WHERE Id = @Id", dbConnection);

            command.Parameters.AddWithValue("@Id", bookId);

            SqlDataReader reader = command.ExecuteReader();
            Book book = null;

            if (reader.Read())
            {
                book = ReadBook(reader);
            }

            reader.Close();
            dbConnection.Close();

            return book;

        }

       

        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            return new Book(id, title, author);
        }
    }
}
