﻿namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public void Present()
        {
            Console.WriteLine(this.Name + Environment.NewLine + this.Price);
        }
    }
}