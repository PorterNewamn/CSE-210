using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture();
        Reference r = new Reference();
    
        string userRespons = "continue";
        s.SetWordCount();

        while (userRespons != "quit")
        {
            Console.Clear();
            Console.Write(s.WordCount());
            Console.WriteLine($"\n\n{r.Refer()} - {s.GetList()}");
            if (s.HiddenAllWords())
            {       
                break;
            }


            Console.WriteLine("\nPress 'enter' to vanish words or 'quit' to finish");
            string respons = Console.ReadLine();
            if (respons == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine($"{r.Refer()} - {s.GetList()}");
                s.SetBlank();
                s.SetBlank();
                s.SetBlank();
            }

            Console.Write(s.WordCount());

        }
    }
}