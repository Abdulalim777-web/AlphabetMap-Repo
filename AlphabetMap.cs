
namespace AlphabetProgram
{
    class AlphabetMap
    {
        static Dictionary<char, string> alphabetMap = new Dictionary<char, string>()

        {
            {'A', "Ape"},
            {'B', "Boy"},
            {'C', "Cat"},
            {'D', "Dog"},
            {'E', "Egg"},
            {'F', "Fish"},
            {'G', "Gun"},
            {'H', "Hut"},
            {'I', "Ink"},
            {'J', "Jug"},
            {'K', "Kite"},
            {'L', "Lion"},
            {'M', "Mug"},
            {'N', "Note"},
            {'O', "Oar"},
            {'P', "Pen"},
            {'Q', "Queen"},
            {'R', "Run"},
            {'S', "Sun"},
            {'T', "Tree"},
            {'U', "Umbrella"},
            {'V', "Van"},
            {'W', "War"},
            {'X', "X-ray"},
            {'Y', "Yam"},
            {'Z', "Zip"}
        }; 
        
        public void MappingAlphatbet()
        {
            Console.Write("Enter your name: ");
            string input = (Console.ReadLine()!).ToUpper();

            foreach (char c in input)
            {
                if (alphabetMap.ContainsKey(c))
                {
                    Console.WriteLine($"{c} for {alphabetMap[c]}");
                }
                else
                {
                    Console.WriteLine($" {c} is not an ALPHABET!");
                }
            }

            Console.ReadKey();
        }
    }
}





