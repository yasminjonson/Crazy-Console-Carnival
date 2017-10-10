using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCarnivalV2.Source.CarnivalGames.AllCarnivalGamesClasses;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGamesClasses
{
    class Question
    {
        public String question;
        public String[] answers;
        public int correctAnswer;

        public int category;
        public int level;
        // public int x;

        public Question(int category, int level, String q, String[] a, int correct)
        {
            this.category = category;
            this.question = q;
            this.level = level;
            // this.x = x;

            this.answers = a;
            this.correctAnswer = correct;
        }
    }
}

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{

    class TriviaMania : CarnivalGame
    {
        private List<Question> questions = new List<Question>();

        public TriviaMania() : base()
        {
            //this.questions = new List<Question>();

            // questions go here

            // movies
            // make 5 1,1
            this.questions.Add(new Question(1, 1, "In the movie \" The Wizard of Oz\", what did the Scarecrow want from the wizard?", new String[] { "[A] a heart", "[B] a brain", "[C] courage", "[D] some succ" }, 1));
            this.questions.Add(new Question(1, 1, "Who does th evoiceover for Dory in \"Finding Nemo\"?",                             new String[] { "[A] that gay celebrity", "[B] Canada", "[C] an actual bear", "[D] Maddie" }, 2));
            this.questions.Add(new Question(1, 1, "In what year was the original \"Jurassic Park\" film released?",                   new String[] { "[A] 23867", "[B] 414", "[C] 1993", "[D] 2398" }, 3));

            // make 5 1,2
            this.questions.Add(new Question(1, 2, "What was the name of the whale in the 1993 movie, \"Free Willy\"?",                new String[] { "[A] Suni", "[B] Bobbi", "[C] Pickle", "[D] Keiko" }, 4));

            // make 5 1,3
            this.questions.Add(new Question(1, 3, "Infamous English prisoner, Charels Bronson, was played by what actor in the 2008 film \"Bronson\"?", new String[] { "[A] your brother's jizz sock", "[B] Tom Hardy", "[C] that deer you hit earlier this month", "[D] Ron Swanson" }, 2));

            // make 5 1,4
            this.questions.Add(new Question(1, 4, "In the movie Mean Girls, where is Caty originally from?",                                            new String[] { "[A] an anus", "[B] where all those starving kid commercials are filmed", " [C] Switzerland", "[D] Kentucky", }, 2));
        }

        public override string getName()
        { return "Trivia Mania"; }

        public override void play()
        {
            // CODE HERE
            List<String> names = new List<string>();

            // print name and promp user for name and available prizes
            writeLine(" Hello and welcome to Trivia Mania!!!");
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
                { writeLine("You must enter a number of players."); }
            }

            // number of players
            writeLine("What's your name?");

            for (int i = 0; i < playerNum; i++)
            {
                writeLine("Player " + (i + 1) + ": ");
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
                {
                    if (categoryNum == 1)
                        break;
                }
                else
                { writeLine("You must choose one of the available categories"); }
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
                {
                    if (levelNum <= 4)
                    {break;}}



                else
                { writeLine("You must choose one of the available levels"); }


            }
            // random int
            Random rnd = new Random();

            List<Question> possible = this.questions.Where(n => n.category == categoryNum && n.level == levelNum).ToList();

            int qnum = rnd.Next(0, possible.Count - 1);

            Question q = possible[qnum];

            writeLine(q.question);

            foreach (String answer in q.answers)
            {writeLine(answer);}

            write("What is your answer? : ");
            String choice = getInput().ToUpper();
            int answerIndex = choice[0] - 'A';


        }

    }
}
