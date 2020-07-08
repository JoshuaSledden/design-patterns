using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Item toy = new Toy();
            Item book = new Book();

            toy.Attach(new Customer("Josh"));
            toy.Attach(new Customer("Jenna"));

            book.Attach(new Customer("Bill"));
            book.Attach(new Customer("Ben"));

            toy.Price = 15.0;
            toy.Price = 25.0;
            toy.Price = 5.0;

            book.Price = 10.0;
            book.Price = 20.0;
            book.Price = 30.0;
        }
    }
}
