using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceMaker
{
    class App
    {
        //JESUS PLS
        public List<string> Choices { get; set; }
        public string TakeTheWheel { get; set; }

        public App()
        {
            Choices = new();
            TakeTheWheel = "";
            Console.Write("Enter an activity, or type 'go' for a random one from your list.\n\n") ;

            do
            {

                PromptForChoice();
            } while (TakeTheWheel.ToLower() != "go");

            if (EmptyListCheck())
            {
                Remark("No choices found. Convenient.");
                return;
            }

            Random rando = new Random();
            int index = rando.Next(0, Choices.Count); 
            string activity = Choices[index];

            ShowEndChoice(activity);
            //FOMO();
        }

        private void PromptForChoice()
        {          
            string selection = ReadChoice();
            AddOrStart(selection);          
        }

        private string ReadChoice()
        {
            string selectionForList = Console.ReadLine();
            return selectionForList;
        }

        private void AddOrStart(string toCheck)
        {
            if (toCheck.ToLower() != "go")
            {
                Choices.Add(toCheck);
            }else
            {
                TakeTheWheel = "go";
            }
        }

        private bool EmptyListCheck()
        {
            return Choices.Count == 0;
        }

        private void Remark(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadLine();
        }

        private void ShowEndChoice(string activity)
        {
            Console.Clear();
            Console.WriteLine("Chosen activity: " + activity + ".");
            Console.ReadLine();
        }

        private void FOMO()
        {
            Console.WriteLine("In case you forgot what you won't be doing.");
            foreach (string c in Choices)
            {
                Console.Write(c + "\n");
            }
            Console.ReadLine();
        }
    }
}
