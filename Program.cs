﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                 Deck deck1 = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card card0 =  deck1.TakeTopCard();
                Card card1 = deck1.TakeTopCard();
                Card card2 = deck1.TakeTopCard();
                Card card3 = deck1.TakeTopCard();
                Card card4 = deck1.TakeTopCard();
                Card card5 = deck1.TakeTopCard();
                Card card6 = deck1.TakeTopCard();
                Card card7 = deck1.TakeTopCard();




                // deal 1 more card to players 2 and 3
                Card card8 = deck1.TakeTopCard();
                Card card9 = deck1.TakeTopCard();

                // flip all the cards over
                card0.FlipOver();
                card1.FlipOver();
                card2.FlipOver();
                card3.FlipOver();
                card4.FlipOver();
                card5.FlipOver();
                card6.FlipOver();
                card7.FlipOver();
                card8.FlipOver();
                card9.FlipOver();



                // print the cards for player 1
                Console.WriteLine(card0.Rank + "," + card0.Suit);
                Console.WriteLine(card4.Rank + "," + card4.Suit);

                // print the cards for player 2

                Console.WriteLine(card1.Rank + "," + card1.Suit);
                Console.WriteLine(card5.Rank + "," + card5.Suit);
                Console.WriteLine(card8.Rank + "," + card8.Suit);

                // print the cards for player 3

                Console.WriteLine(card2.Rank + "," + card2.Suit);
                Console.WriteLine(card6.Rank + "," + card6.Suit);
                Console.WriteLine(card9.Rank + "," + card9.Suit);

                // print the cards for player 4

                Console.WriteLine(card3.Rank + "," + card3.Suit);
                Console.WriteLine(card7.Rank + "," + card7.Suit);

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
