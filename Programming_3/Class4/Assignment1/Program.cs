using System;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using DAL;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            Console.WriteLine("Customers:");
            foreach (Customer customer in customerDAO.GetAll())
                Console.WriteLine(customer);

            Console.Write("Find book of id: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine(customerDAO.GetById(customerId));

            BookDAO bookDAO = new BookDAO();
            Console.WriteLine("\n#####################\nBooks:");
            foreach (Book book in bookDAO.GetAll())
                Console.WriteLine(book);

            Console.Write("Find book of id: ");
            int bookId = int.Parse(Console.ReadLine());
            Console.WriteLine(bookDAO.GetById(bookId));

            ReservationDAO reservationDAO = new ReservationDAO();
            Console.WriteLine("\n#####################\nReservations:");
            foreach (Reservation reservation in reservationDAO.GetAll())
                Console.WriteLine(reservation);

            Console.Write("Find reservation of id: ");
            int reservationId = int.Parse(Console.ReadLine());
            Console.WriteLine(reservationDAO.GetById(reservationId));

            Console.Write("\nFind reservation of book id: ");
            int resBookId = int.Parse(Console.ReadLine());
            foreach (Customer customer in reservationDAO.GetAllForBook(bookDAO.GetById(resBookId)))
                Console.WriteLine(customer);

            Console.Write("\nFind reservation of customer id: ");
            int resCustomerId = int.Parse(Console.ReadLine());
            foreach (Book book in reservationDAO.getAllForCustomer(customerDAO.GetById(resCustomerId)))
                Console.WriteLine(book);
        }
    }
}
