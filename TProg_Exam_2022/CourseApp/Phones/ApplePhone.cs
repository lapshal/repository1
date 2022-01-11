namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ApplePhone : SmartPhone
    {
        public ApplePhone(string name, decimal price, float diagonal)
        {
            this.Price = price;
            this.Name = name;
            this.Diagonal = diagonal;
        }
    }
}
