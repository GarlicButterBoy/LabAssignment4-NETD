using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabAssignment4_NETD.Models
{
    public class Textbook
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The Textbook Title CANNOT be Empty.")]
        public string title { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "The ISBN CANNOT be Empty.")]
        public string isbn { get; set; }
        [Required]
        [Range((double)1, 5, ErrorMessage = "Version Number must be between 1 and 5.")]
        public double version { get; set; }
        [Required]
        [Range((double)0, 500, ErrorMessage = "Textbook cost must be between 0 and 500.")]
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

        //Calculate Method
        public double CalculateCost()
        {
            double appraisedPrice = 0;

            if (this.condition == "Bad")
            {
                appraisedPrice = this.price / 4;
            }
            else if (this.condition == "Okay")
            {
                appraisedPrice = this.price / 3;
            }
            else
            {
                appraisedPrice = this.price / 2;
            }
            return Math.Round(appraisedPrice, 2);
        }
    }
}
