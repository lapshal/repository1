namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LandLinePhone : Phone
    {
        public LandLinePhone(string name, decimal price)
        {
            this.Price = price;
            this.Name = name;
        }
    }
}