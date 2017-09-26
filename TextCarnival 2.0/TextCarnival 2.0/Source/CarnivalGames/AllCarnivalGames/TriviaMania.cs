using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TriviaMania : CarnivalGame
    {
        public TriviaMania() : base()
        {
        }

        public override string getName()
        {return "Trivia Mania";}
        
        public override void play()
        {
            // code here

            // print name and promp user for name and available prizes

            // numer of players
            Console.WriteLine("Hello and welcome to Trivia Mania!!!" +
                "Please select number of players: ");



            // prompt user for category and level of difficulty

            // randomizer of those questions in each category and level

            // list available prizes to choose one
        }

    }
}
