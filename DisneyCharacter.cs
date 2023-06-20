using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyApp
{
    public abstract class DisneyCharacter
    {
        //Fields
        //string name;
        //string species;
        //string story;
        //string enemy;

        //Properties
        public string Name { get; protected set; }
        public string Species { get; protected set; }
        public string Story { get; protected set; }
        public string Enemy { get; protected set; }

        public static int charactersCreated = 0;

        //Constructor
        public DisneyCharacter(string name, string species, string story, string enemy)
        {
            Name = name;
            Species = species;
            Story = story;
            Enemy = enemy;
            charactersCreated++;
        }
        //Methods
        public abstract void Sing();

        public abstract void Greeting();
    }
}
