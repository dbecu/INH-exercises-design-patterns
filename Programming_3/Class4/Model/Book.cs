using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Book
    {

        private int id;

        public string Author
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public Book(int id, string title, string author)
        {
            this.id = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
