using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {

            
            Console.WriteLine(" Welcome to the Grand Circus window store!\n ");
            Console.WriteLine("Let's first Calculate the material you are going to  need for your window.\n ");
            Console.Write("Please enter your name here : ");
            string clientOftheStore = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter the (Length) of your windows: ");
            double windowlength = double.Parse(Console.ReadLine());

            Console.Write("Now please enter the (Width)of your windows: ");
            double windowWidth = double.Parse(Console.ReadLine());


            double areaOfWindow = windowlength * windowWidth;
            double perimeterOfWindow = (2 *(windowlength + windowWidth));
            Console.WriteLine();
            Console.WriteLine($"Hola amigo {clientOftheStore}. For this job you will need\n" +
                $"{areaOfWindow} square centimeters of glass for your window. ");
            Console.WriteLine();
            Console.WriteLine($" And for this window you will need\n" +
               $"{perimeterOfWindow} centimeters of wood to make the frame  ");
                Console.WriteLine();
                bool isInvalid;
                do
                {
                    Console.Write("Would you like to continue (y/n): ?");
                    answer = Console.ReadLine();
                    isInvalid = answer != "y" && answer != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("OOPS! Your input is incorrect try again please ");
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Gracias por la visita, Adios Amigo! ");
                    }
                   
                    //Console.WriteLine();

                } while (isInvalid);
               // Console.WriteLine("Adios Amigo! ");

                
            } while (answer == "y");


            Console.ReadKey();
        }
    }
}
