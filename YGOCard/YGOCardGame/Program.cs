﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Card[] deck = new Card[2];

            deck[0] = new Card("Blue-Eyes White Dragon", "This legendary dragon is a powerful engine of destruction. Virtually invincible, very few have faced this awesome creature and lived to tell the tale.", 89631139, "Dragon");
            //deck[0].setName("Red-Eyes Black Dragon");
            deck[1] = new Card("Dark Magician", "The ultimate wizard in terms of attack and defense.", 46986414, "Spellcaster");

            // Describe cards in deck.
            for (int i = 0; i < deck.Length; i++)
            {
                Console.WriteLine(deck[i].getName());
                Console.WriteLine(deck[i].getDesc());
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}