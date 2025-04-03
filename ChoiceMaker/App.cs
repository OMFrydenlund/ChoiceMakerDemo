using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceMaker
{
    class App
    {
        public List<string> Choices { get; set; }
        public string Hatch { get; set; }

        public App()
        {
            Choices = new()
            {

            };

            Hatch = "";
            do
            {
                PromptForChoice();
            } while (Hatch.ToLower() != "start");

            Random rando = new Random();
            int index = rando.Next(0, Choices.Count); 

            string randomElement = Choices[index];

            Console.WriteLine("Today's activity: " + randomElement);
            Console.ReadLine();
        }

        public void ShowAllChoices()
        {
            foreach (string c in Choices)
            {
                if (Choices != null)
                {
                    Console.Clear();
                    Console.Write(c + "\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your list of choices is empty.");
                }
            }
        }

        public void PromptForChoice()
        {
            Console.Write("Add a selection (or type start to show choices): \n");
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
            if (toCheck.ToLower() != "start")
            {
                Choices.Add(toCheck);
            }else
            {
                Hatch = "start";
            }
        }
    }
}
