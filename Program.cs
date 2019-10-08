using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            List<TeamMember> team = new List<TeamMember>();
            
            // Get the first team members name
            Console.WriteLine("Name>");
            string name = Console.ReadLine();

            while (name != "") {

                Console.WriteLine("Skill Level>");
                string skillLevel = Console.ReadLine();

                Console.WriteLine("Courage Factor>");
                string courageFactor = Console.ReadLine();

                // Dictionary<string, string> member = new Dictionary<string, string> () {
                //     {"Name", name},
                //     {"SkillLevel", skillLevel},
                //     {"CourageFactor", courageFactor}
                // };
                
                TeamMember member = new TeamMember();
                member.Name = name;
                member.SkillLevel = int.Parse(skillLevel);
                member.CourageFactor = double.Parse(courageFactor);

                team.Add(member);


                // get the next team members name
                Console.WriteLine("Name> ");
                name = Console.ReadLine();


        }
            Console.WriteLine(
                $"Team Size: {team.Count}"
            );
            Console.WriteLine("Team Members");
            foreach(TeamMember member in team) {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Name: {member.Name}");
                Console.WriteLine($"Skill: {member.SkillLevel}");
                Console.WriteLine($"Courage: {member.CourageFactor}");            
            };
        }
    }
}
