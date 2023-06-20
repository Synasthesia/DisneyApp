using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyApp
{
    public class Villain : DisneyCharacter
    {
        public string Motive { get; set; }
        public int IrritationLevel { get; set; } = 25;
        public string AttackMethod { get; set; }

        public Villain(string name, string species, string story, string enemy) : base(name, species, story, enemy)
        {

        }
        public override void Greeting()
        {
            Console.WriteLine("Muahahahahaha");
        }
        public override void Sing()
        {
            Console.WriteLine("Leave me alone idiot! " + Name + " doesn't have time to waste on you!");
        }
        public void InitialDisplay()
        {
            Console.Clear();
            Console.WriteLine("You have chosen " + Name + "! Here's some info about them:");
            Console.WriteLine("----------------------------------------------------------");
            ToString();
            Console.ReadLine();
        }
        public void ToString()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Story: " + Story);
            Console.WriteLine("Enemy: " + Enemy);
            Console.WriteLine("Motive: " + Motive);
            Console.WriteLine("Irritation Level: " + IrritationLevel);
        }
        public void DisplayIrritation()
        {
            Console.WriteLine("Be careful! " + Name + "'s irritation level is " + IrritationLevel);
        }
        public void Attack()
        {
            Console.WriteLine(Name + " " + AttackMethod);
            IrritationLevel += 17;
            DisplayIrritation();
        }
        public void VillainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a villain to create");
            Console.WriteLine("1: Cid" +
                "\n2: Maleficient" +
                "\n3: Jafar" +
                "\n4: Cap'n Hook" +
                "\n5: Ursula" +
                "\n6: Scar");
            string input = Console.ReadLine();
            if(input == "1")
            {
                Name = "Cid";
                Story = "Toy Story";
                Enemy = "All Toys";
                Motive = "To cause chaos and misery to all toys";
                Species = "Human";
                AttackMethod = "raises a magnifying glass to the sun and burns a hole in your forehead";
            }
            else if (input == "2")
            {
                Name = "Maleficient";
                Story = "Sleeping Beauty";
                Enemy = "Aurora";
                Motive = "Seek revenge on Stefan because he stole her wings";
                Species = "Fairy";
                AttackMethod = "raises her golden scepter and casts a tranmorgriphication spell turning you into a toad";
            }
            else if (input == "3")
            {
                Name = "Jafar";
                Story = "Aladdin";
                Enemy = "Jasmine";
                Motive = "Power hungry sorcerer who wants to rule the world";
                Species = "Grand Vizier";
                AttackMethod = "turns into a massive cobra and bites";
            }
            else if (input == "4")
            {
                Name = "Captain Hook";
                Story = "Peter Pan";
                Enemy = "Peter Pan";
                Motive = "get revenge on Peter Pan for feeding his hand to the crocodile";
                Species = "Human";
                AttackMethod = "slashes at you with his sabre";
            }
            else if (input == "5")
            {
                Name = "Ursula";
                Story = "Little Mermaid";
                Enemy = "King Triton";
                Motive = "banished from Atlantica";
                Species = "Cecaelia";
                AttackMethod = "makes a deal for your soul";
            }
            else if (input == "6")
            {
                Name = "Scar";
                Story = "Lion King";
                Enemy = "Mufasa";
                Motive = "To be king";
                Species = "Lion";
                AttackMethod = "swipes at your face";
            }
            else { Console.WriteLine("Enter a valid input"); }
        }

    }
}
