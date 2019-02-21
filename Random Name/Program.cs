using System;

namespace Random_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] names = new string[30];
            int numberOfNames = 30;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Give me a name, please.");
                string name = Console.ReadLine(); 
                //if(name == "") 
                if (String.IsNullOrEmpty(name))
                {
                    numberOfNames = i;
                    break;
                }
                names[i] = name;                
            }

            int randomInt = new Random().Next(0, numberOfNames - 1);
            string nameWinner = names[randomInt];
            Console.WriteLine($"The winner is: {nameWinner}");
           
            //then list all the other names that didn't win


            Console.ReadLine();
            


        }
    }
}
