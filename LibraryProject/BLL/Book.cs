using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Book
    {
        private string name;
        private string subject;
        private int year;
        private string summary;
        private int copies;

        public Book()
        {
        }
        public Book(string name,string subject,int year,string summary,int copies)
        {
            this.name = name;
            this.subject = subject;
            this.year = year;
            this.summary = summary;
            this.copies = copies;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public int Year { get { return year; } set { year = value; } }
        public string Summary { get { return summary; } set { summary = value; } }
        public int Copies { get { return copies; } set { copies = value; } }

        public override string ToString()
        {
            return name;
        }
    }
}
