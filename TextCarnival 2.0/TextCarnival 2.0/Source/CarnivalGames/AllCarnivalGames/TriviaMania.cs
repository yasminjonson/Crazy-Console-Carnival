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
            List<String> names = new List<string>();

            // print name and promp user for name and available prizes
            writeLine(" Hello and welcome to Trivia Mania!!!" );
            writeLine(" Get five questions in a row right and win the ~Grand Prize~ ");

            int playerNum = 1;

            while (true)
            {

                writeLine(" How many players will be participating this round?  ");

                // show choices of number of players 
                writeLine(" [1] Single Player");
                writeLine(" [2] Player v. Player ");
                writeLine(" [3] Triple Threat ");
                writeLine(" [4] Quadruple Showdown ");

                String input = getInput();

                if (int.TryParse(input, out playerNum))
                    break;
                else
                {
                    writeLine("You must enter a number of players.");
                }
            }

            // number of players
            writeLine("What's your name?");

            for (int i = 0; i < playerNum; i++)
            {
                writeLine("Player " + (i+1) + ": ");
                names.Add(getInput());
            }

            
            // ask category
            writeLine("Which category would you like?: ");
            writeLine("[1] Movies");

            // prompt user for category and level of difficulty
            writeLine("Which level of difficulty would you like?");
            writeLine("[1] Cake");
            writeLine("[2] Tough Shit");
            writeLine("[3] Hard as Balls");
            writeLine("[4] no");
            String level = getInput();

            // levels of difficulty gate

            // movies cake
            if (level == "1")
            {
                // print question
                writeLine("Which production company made Monters Ink?");
                String answer1 = getInput();

                // check if its right

                // show -/5

                // next question if right
            }

            else if (level == "2")
            {

            }

            else if (level == "3")
            {

            }

            else if (level == "4")
            {

            }

            // randomizer of those questions in each category and level

            // list available prizes to choose one
        }

    }
}
