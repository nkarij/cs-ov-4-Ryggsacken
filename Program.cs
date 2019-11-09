using System;
using System.Collections.Generic;

namespace cs_ov_4_Ryggsacken
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isRunning = true;
            List<string> stuff = new List<string>();
            // stuff.Add("tusser");
          
            while (isRunning)
            {
                Console.WriteLine("Welcome to Ryggsacken");
                Console.WriteLine("[1] Add an item");
                Console.WriteLine("[2] Print a list of stuff");
                // Console.WriteLine("[3] Clear the Ryggsack");
                Console.WriteLine("[3] Remove the last item");
                Console.WriteLine("[4] Close");
                Console.WriteLine("Type option:");
                string input = Console.ReadLine();
                int option = Convert.ToInt32(input);

                switch (option)
                {
                    case 1: 
                        Console.WriteLine("What would you like to add?");
                        string newItem = Console.ReadLine();
                        Console.WriteLine($"You have added: {newItem}");
                        if(stuff.Count < 6) {
                            stuff.Add(newItem);
                        }
                        break;
                    case 2:
                        Console.WriteLine("List of stuff in Ryggsack:");
                        for (int i = 0; i < stuff.Count; i++)
                        {
                            var item = stuff[i];
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        // stuff.Clear();
                        int count = stuff.Count;
                        int index = count-=1;
                        if(index >= 0){
                            stuff.RemoveAt(index);
                        }
                        break;
                    case 4:
                        Console.WriteLine("See you soon");
                        isRunning = false;
                        return;
                    default: 
                        Console.WriteLine("I dont quite understand...?");
                        break;
                }
                
            }


        }
    }
}
