namespace Exam
{
    internal class Program
    {
        private static void Main()
        {
            Eshop eshop = new ();

            LandLinePhone landLinePhone = new ("Domaschniy", 4999.99M);
            eshop.AddToProducts(landLinePhone);
            LandLinePhone cellPhone = new ("BabushkaPhone", 3999.99M);
            eshop.AddToProducts(cellPhone);
            AndroidPhone phone = new ("Android", 13999.99M, 5.5f);
            eshop.AddToProducts(phone);
            AndroidPhone iphone = new ("iPhone", 59999.99M, 7.5f);
            eshop.AddToProducts(iphone);

            eshop.Present();
        }
    }
}