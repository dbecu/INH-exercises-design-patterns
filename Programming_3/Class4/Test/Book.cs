using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Book
    {

        private int id;

        public string Author
        {
            get; set;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
                 
            set
            {
                this.id = value;
            }
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
            return String.Format($"{Id}. '{Title}' by {Author}");
        }

    }
}
