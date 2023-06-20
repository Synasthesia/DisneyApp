using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyApp
{
    public class Princess : DisneyCharacter
    {
        public string LoveInterest { get; set; }
        public SideKick SideKick { get; set; }

        public Princess(string name, string story, string enemy, string loveInterest) : base(name, "Human", story, enemy)
        {
            LoveInterest = loveInterest;
        }
        public override void Sing()
        {
            Console.WriteLine("Do Re Mi");
        }
        public override void Greeting()
        {
            Console.WriteLine("Hello! So charmed to meet you! My name is " + Name + ".\n");
        }
        public void InitialDisplay()
        {
            Console.Clear();
            Console.WriteLine("You have chosen " + Name + "! Here is some info about her:");
            Console.WriteLine("----------------------------------------------------------");
            ToString();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A princess needs her sidekick!");
            Console.WriteLine(Name + "'s sidekick is " + SideKick.Name + " the " + SideKick.Species);
        }
        public void ToString()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Story: " + Story);
            Console.WriteLine("Enemy: " + Enemy);
            Console.WriteLine("Love Interest: " + LoveInterest);
        }
        public void PrincessMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose which princess to create:");
            Console.WriteLine("1: Cinderella" +
                "\n2: Snow White" +
                "\n3: Aurora" +
                "\n4: Jasmine" +
                "\n5: Belle" +
                "\n6: Tianna");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Name = "Cinderella";
                Story = "Happily Ever After";
                Enemy = "Wicked Stepmother";
                LoveInterest = "Prince Charming";
                SideKick = new SideKick("Jaque", "Mouse", Story, Enemy, Name);
            }
            else if (input == "2")
            {
                Name = "Snow White";
                Story = "Snow White and the Seven Dwarves";
                Enemy = "Evil Queen";
                LoveInterest = "Prince Florian";
                SideKick = new SideKick("Grumpy", "Dwarf", Story, Enemy, Name);
            }
            else if (input == "3")
            {
                Name = "Aurora";
                Story = "Sleeping Beauty";
                Enemy = "Maleficient";
                LoveInterest = "Prince Phillip";
                SideKick = new SideKick("Flora", "Fairy", Story, Enemy, Name);
            }
            else if (input == "4")
            {
                Name = "Jasmine";
                Story = "Aladdin";
                Enemy = "Jafar";
                LoveInterest = "Aladdin";
                SideKick = new SideKick("Rajah", "Tiger", Story, Enemy, Name);
            }
            else if (input == "5")
            {
                Name = "Belle";
                Story = "Beauty and the Beast";
                Enemy = "Gaston";
                LoveInterest = "Beast";
                SideKick = new SideKick("Lumiere", "Candlestick", Story, Enemy, Name);
            }
            else if (input == "6")
            {
                Name = "Tianna";
                Story = "Princess and the Frog";
                Enemy = "Dr. Facilier";
                LoveInterest = "Naveen";
                SideKick = new SideKick("Ray", "Firefly", Story, Enemy, Name);
            }
            else { Console.WriteLine("Please enter a valid option"); }

        }
    }
}
