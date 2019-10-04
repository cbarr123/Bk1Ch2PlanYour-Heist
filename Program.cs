using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            List<Dictionary<string, string>> team = 
                new List<Dictionary<string, string>>();
            
            Console.WriteLine("Name>");
            string name = Console.ReadLine();

            while (name != "") {

                Console.WriteLine("Skill Level>");
                string skillLevel = Console.ReadLine();

                Console.WriteLine("Courage Factor>");
                string courageFactor = Console.ReadLine();

                Dictionary<string, string> member = new Dictionary<string, string> () {
                    {"Name", name},
                    {"SkillLevel", skillLevel},
                    {"CourageFactor", courageFactor}
                };
                team.Add(member);

                Console.WriteLine("Name> ");
                name = Console.ReadLine();


        }
            Console.WriteLine(
                $"Team Size: {team.Count}"
                
            );
        }
    }
}
