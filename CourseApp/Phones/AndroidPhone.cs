namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AndroidPhone : SmartPhone
    {
        public AndroidPhone(string name, decimal price, float diagonal)
        {
            this.Price = price;
            this.Name = name;
            this.Diagonal = diagonal;
        }
    }
}
