namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Eshop
    {
        private readonly List<Product> products = new ();

        public void AddToProducts(Product product)
        {
            this.products.Add(product);
        }

        public void Present()
        {
            foreach (Product product in this.products)
            {
                product.Present();
            }
        }
    }
}

