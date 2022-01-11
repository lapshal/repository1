namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Phone : Product, ICanDial, ICanAcceptCall
    {
        public string AcceptCall()
        {
            return "Accepting call";
        }

        public string Dial()
        {
            return "Dialing person";
        }
    }
}