using System;

namespace Invoice
{
    class App
    {
        public static void Main()
        {
            var invoice = new Invoice(50, "Lily", "McDonalds");
            invoice.Article = "Big Mac";
            invoice.SetQuantity(5);

            invoice.Print();
        }
    }
}
