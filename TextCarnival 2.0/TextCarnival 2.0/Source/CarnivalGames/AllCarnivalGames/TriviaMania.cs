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
              
                String input = getInput();

                if (int.TryParse(input, out playerNum))
                    break;
                     else
                     {writeLine("You must enter a number of players.");}
            }

            // number of players
            writeLine("What's your name?");

            for (int i = 0; i < playerNum; i++)
            {
                writeLine("Player " + (i+1) + ": ");
                names.Add(getInput());
            }

            // ask category
            int categoryNum = 1;
            while (true)
            {
                writeLine("Which category would you like?: ");
                writeLine("[1] Movies");
                String category = getInput();

                if (int.TryParse(category, out categoryNum))
                    break;
                else
                {
                    writeLine("You must choose one of the available categories");
                }
            }

            // prompt user for category and level of difficulty
            int levelNum = 1;
            while (true)
            {
                writeLine("Which level of difficulty would you like?");
                writeLine("[1] Cake");
                writeLine("[2] Tough Shit");
                writeLine("[3] Hard as Balls");
                writeLine("[4] no");
                String level = getInput();

                if (int.TryParse(level, out levelNum))
                    break;

                else
                {
                    writeLine("You must choose one of the available levels");
                }
            }
            // levels of difficulty gate

            // movies cake
            /*if (level == "1")
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

            // list available prizes to choose one*/
        }

    }
}
