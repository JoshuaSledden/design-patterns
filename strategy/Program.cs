using System;

/* The Strategy Pattern.
 * Defines a family of algorithms, encapsulates each one and makes them interchangeable. 
 * Strategy lets the algorithm vary independently from the clients that use it thus decoupling it.
 */

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating 3 players using derived classes.");

            Player player1 = new Warrior();
            Player player2 = new Mage();
            Player player3 = new Ranger();

            Console.WriteLine("All players attack using different algorithms depending on their derived class type.");

            player1.Attack(25);
            player2.Attack(25);
            player3.Attack(25);
        }
    }
}
