using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabAssignment4_NETD.Models
{
    public class Textbook
    {
        public string title { get; set; }
        public string isbn { get; set; }
        public double version { get; set; }
        public double price { get; set; }
        public string condition { get; set; }

        //No Parameter (Default) Constructor
        public Textbook() {}

        //Parameterized Constructor
        public Textbook(string title, string isbn, double version, double price, string condition)
        {
            this.title = title;
            this.isbn = isbn;
            this.version = version;
            this.price = price;
            this.condition = condition;
        }

        //ToString Override
        public override string ToString()
        {
            string output;
            output = "=========================================" + Environment.NewLine;
            output += "Textbook Title    : " + this.title + Environment.NewLine;
            output += "Textbook ISBN     : " + this.isbn + Environment.NewLine;
            output += "Textbook Version  : " + this.version.ToString() + Environment.NewLine;
            output += "Textbook Price    : " + this.price.ToString() + Environment.NewLine;
            output += "Textbook Condition: " + this.condition + Environment.NewLine;
            output += "=========================================";
            return output;
        }


    }
}
