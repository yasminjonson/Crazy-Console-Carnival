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
            // CODE HERE

            // print name and promp user for name and available prizes
            writeLine(" Hello and welcome to Trivia Mania!!!" );
            writeLine(" Get five questions in a row right and win the ~Grand Prize~ ");
            writeLine(" How many players will be participating this round?  " );

            // show choices of number of players 
            writeLine(" [1] Single Player");
            writeLine(" [2] Player v. Player ");
            writeLine(" [3] Triple Threat ");
            writeLine(" [4] Quadruple Showdown ");

            String playerNum = getInput();

            // number of players

                if (playerNum == "1")
                {

                 // prompt names
                 writeLine("What's your name?");
                 String p1 = getInput();

                }
                else if (playerNum == "2")
                {

                // prompt names
                 writeLine("What're your names?");

                 writeLine("Player 1: ");
                 String p1 = getInput();

                 writeLine("Player 2: ");
                 String p2 = getInput();

                }

                else if (playerNum == "3")
                {

                 // prompt names
                 writeLine("What're your names");

                 writeLine("Player 1: ");
                 String p1 = getInput();

                 writeLine("Player 2: ");
                 String p2 = getInput();

                 writeLine("Player 3: ");
                 String p3 = getInput();

                }

                else if (playerNum == "4")
                {

                 // prompt names
                 writeLine("What're your names");

                 writeLine("Player 1: ");
                 String p1 = getInput();

                 writeLine("Player 2: ");
                 String p2 = getInput();

                 writeLine("Player 3: ");
                 String p3 = getInput();

                 writeLine("Player 4: ");
                 String p4 = getInput();

                }
                    else;
                

            // prompt user for category and level of difficulty

            // randomizer of those questions in each category and level

            // list available prizes to choose one
        }

    }
}
