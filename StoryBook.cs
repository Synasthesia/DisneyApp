using System.Net;

namespace DisneyApp
{
    public class StoryBook
    {
        public List<DisneyCharacter> Characters { get; set; }

        public StoryBook()
        {
            Characters = new List<DisneyCharacter>();
        }
        public void AddCharacter(DisneyCharacter character)
        {
            Characters.Add(character);
        }
        public Villain GetVillain(string name)
        {
            List<Villain> vList = GetAllVillains(); // assigns local list of villains using GetAllVillains
            foreach (Villain v in vList)
            {
                if (v.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return v;
                }
            }
            return null;
        }
        public List<Villain> GetAllVillains()
        {
            List<Villain> villainList = new List<Villain>();
            foreach (DisneyCharacter character in Characters)
            {
                if (character is Villain villain) //If character is a type villain
                {
                    villainList.Add(villain); //add to the list of villain objects
                }
            }
            return villainList;
        }
        public void DisplayAllVillains()
        {
            foreach (Villain v in GetAllVillains())
            {
                Console.WriteLine(v.Name);
            }
        }
        public Princess GetPrincess(string name)
        {
            foreach (Princess p in GetAllPrincesses())
            {
                if (p.Name.Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    return p;
                }
            }
            return null;
        }
        public List<Princess> GetAllPrincesses()
        {
            List<Princess> pList = new List<Princess>();
            foreach (DisneyCharacter character in Characters) 
            {
                if (character is Princess princess) //if character is a type princess
                {
                    pList.Add(princess); //add to the list of princess objects
                }
            }
            return pList;
        }
        public void DisplayAllPrincesses()
        {
            foreach (Princess p in GetAllPrincesses())
            {
                Console.WriteLine(p.Name);
            }
        }





    }
}
