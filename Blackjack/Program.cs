/*
 * Nolan Pawelski & Toaster914
 * Blackjack
 * 3/6/2023
 */

using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("Welcome to Blackjack!");
            string repeat;
            do
            {
                Hand player = GenerateHand(rng);
                Hand computer = GenerateHand(rng);

                // Player turn
                Console.WriteLine("Player's Total: " + player.GetHandValue());
                Console.Write("Hit or stand >> ");
                string response = Console.ReadLine().ToLower();
                while (response == "hit")
                {
                    player.AddCard(GenerateCard(1, rng));
                    Console.WriteLine("Player's Total: " + player.GetHandValue());
                    if (player.GetHandValue() <= 21)
                    {
                        Console.Write("Hit or stand >> ");
                        response = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        Console.WriteLine("You have busted!");
                        break;
                    }
                }
                Console.WriteLine();

                // Computer turn
                Console.WriteLine("Computer's Total: " + computer.GetHandValue());
                while (computer.GetHandValue() < 17)
                {
                    Console.WriteLine("The computer hit!");
                    computer.AddCard(GenerateCard(1, rng));
                    Console.WriteLine("Computer's Total: " + computer.GetHandValue());

                }
                if (computer.GetHandValue() <= 21)
                {
                    Console.WriteLine("The computer stands!");
                }
                Console.WriteLine();

                // Find winner
                if (player.GetHandValue() <= 21
                    && player.GetHandValue() > computer.GetHandValue())
                {
                    Console.WriteLine("The player has won!");
                }
                else if (computer.GetHandValue() <= 21
                    && computer.GetHandValue() > player.GetHandValue())
                {
                    Console.WriteLine("The computer has won!");
                }
                else if (player.GetHandValue() > 21
                    && computer.GetHandValue() <= 21)
                {
                    Console.WriteLine("The computer has won!");
                }
                else if (computer.GetHandValue() > 21
                    && player.GetHandValue() <= 21)
                {
                    Console.WriteLine("The player has won!");
                }
                else
                {
                    Console.WriteLine("It is a tie!");
                }

                Console.Write("Would you like to play again? (Y/N) >> ");
                repeat = Console.ReadLine().ToLower();
                Console.WriteLine();
            } while (repeat == "yes" || repeat == "y");
        }

        /// <summary>
        /// Generates a new hand for either the player or computer.
        /// </summary>
        /// <param name="rng">Random object.</param>
        /// <returns>A Hand object with 2 cards.</returns>
        private static Hand GenerateHand(Random rng)
        {
            Hand temp = new Hand();
            for (int i = 0; i < 2; i++)
            {
                temp.AddCard(GenerateCard(1, rng));
            }
            return temp;
        }

        /// <summary>
        /// Generates a one or more random cards.
        /// </summary>
        /// <param name="amount">The amount of cards to generate.</param>
        /// <param name="rng">Random object.</param>
        /// <returns>A Card object.</returns>
        private static Card GenerateCard(int amount, Random rng)
        {
            Suit suit = (Suit)rng.Next(0, 4);
            Face face = (Face)rng.Next(1, 14);
            Card temp = new Card(suit, face);
            return temp;
        }
    }
}
