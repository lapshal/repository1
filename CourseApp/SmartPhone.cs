namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class SmartPhone : Phone, ICanDeclineCall, ICanReadText, ICanSendText
    {
        public float Diagonal { get; set; }

        public virtual string DeclineCall()
        {
            return "Call Declined";
        }

        public virtual string ReadText()
        {
            return "Reading text";
        }

        public virtual string SendText()
        {
            return "Sending text";
        }
    }
}