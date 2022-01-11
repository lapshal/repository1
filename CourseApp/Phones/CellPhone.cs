namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CellPhone : Phone, ICanDeclineCall, ICanReadText, ICanSendText
    {
        public CellPhone(string name, decimal price)
        {
            this.Price = price;
            this.Name = name;
        }

        public string SendText()
        {
            return "Sending Text";
        }

        public string ReadText()
        {
            return "Reading Text";
        }

        public string DeclineCall()
        {
            return "Declining call";
        }
    }
}