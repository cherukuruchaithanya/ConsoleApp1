using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------FIRE, WATER AND ROCK  ---------------------------------------------");
            Double at1;
            Double at3;
            Console.WriteLine("enter a number");
            var input7 = Console.ReadLine();
            at1 = Convert.ToDouble(input7);

            Console.WriteLine("enter a number");
            var input8 = Console.ReadLine();
            at3 = Convert.ToDouble(input8);

            Double add(double ar, double ad)
            {
                return ar + ad;


            }

            double cv = add(at1, at3);
            double fg = cv / 2;
            var f = "";
            if (fg == 0)
            {
                f = "even";

            }
            else
            {
                f = "odd";
            }
            var c = Console.ReadLine();
            switch (f)
            {
                case "odd":
                    Console.WriteLine("Nunber is odd");
                    break;
                case "even":
                    Console.WriteLine("Nunber is even");
                    break;


            }
            Console.WriteLine("Enter the palyerName1");
            string name1;

            var input1 = Console.ReadLine();
            name1 = Convert.ToString(input1);

            Console.WriteLine("Enter the palyerName2");
            string name2;

            var input2 = Console.ReadLine();
            name2 = Convert.ToString(input2);
            string pokemon1 = "fire";
            string pokemon2 = "water";
            string pokemon3 = "rock";
            double attemps;
            double attemps2;
            Console.WriteLine("Select one number btw 1 to 3");

            var input = Console.ReadLine();
            attemps = Convert.ToDouble(input);
            Console.WriteLine("Select one number btw 1 to 3");

            var input3 = Console.ReadLine();
            attemps2 = Convert.ToDouble(input3);

            bool d = true;


            if (attemps > 0 && attemps < 4)
            {
                if (attemps2 > 0 && attemps < 4)
                {
                    {
                        d = true;
                        
                    }
                }
            }
            else
            {
                d = false;
                Console.WriteLine("enter smaller number");
            }



            

            while (d =! false)
            {
                if (attemps == 1)
                {
                    if (attemps2 == 2)
                    {

                        Console.WriteLine(name2 + " wins");
                        Console.WriteLine(pokemon1 + " beats " + pokemon2);
                        d = false;
                    }
                    if (attemps2 == 3)
                    {
                        Console.WriteLine(name1 + " wins");
                        Console.WriteLine(pokemon2 + " beats " + pokemon3);
                        d = false;
                    }
                    if (attemps2 == 1)
                    {
                        Console.WriteLine("Draw");
                        d = false;
                    }
                    d = false;
                }

                if (attemps == 2)
                {
                    if (attemps2 == 2)
                    {
                        Console.WriteLine("Draw");

                        d = false;
                    }
                    if (attemps2 == 3)
                    {
                        Console.WriteLine(name2 + " wins ");
                        Console.WriteLine(pokemon3 + " beats " + pokemon2);
                        d = false;
                    }
                    if (attemps2 == 1)
                    {
                        Console.WriteLine(name1 + " wins");
                        Console.WriteLine(pokemon2 + " beats " + pokemon1);
                        d = false;
                    }
                    d = false;
                }
                if (attemps == 3)
                {
                    if (attemps2 == 2)
                    {
                        Console.WriteLine(name2 + " wins ");
                        Console.WriteLine(pokemon3 + " beats " + pokemon2);
                        d = false;


                    }
                    if (attemps2 == 3)
                    {
                        Console.WriteLine("Draw");
                        d = false;


                    }
                    if (attemps2 == 1)
                    {
                        Console.WriteLine(name1 + "wins");
                        Console.WriteLine(pokemon3 + " beats " + pokemon1);
                        d = false;
                    }
                    d = false;
                }







                

            }
        }
    }
}
