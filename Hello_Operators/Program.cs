using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            // 3 8 2 71 8 3
            // 3 8 1 7 2 8 3 
            byte v1, v2, v3, v4, v5, v6, v7, v8;
            byte tfw = 1; tfc = 2; tfg = 3; tf = 4; // t - there; b - back; f - farmer; g - goat;
            bfw = 5; bfc = 6; bfg = 7; bf = 8;

            bool Flag;


            Console.WriteLine("Enter sequence of numbers representing algorithm to solve the task");

            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
                                   At the same time can neither carry nor leave together on the banks of a wolf and a goat, a goat and cabbage.
                                   You can only carry a wolf with cabbage or as each passenger separately. You can do whatever how many flights
                                   How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("Each number from one to seven is associated with following combination");

            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.WriteLine("Please, type step by step");

            string custString = "Type next number";




            v1 = int.Parse(Console.ReadLine());

            if (v1 == tfg)

            {
                Console.WriteLine(custString);

                v2 = int.Parse(Console.ReadLine());

                if (v1 == bf)

                {
                    Console.WriteLine(custString);

                    v3 = int.Parse(Console.ReadLine());

                    Flag = (v3 == tfc) || (v3 == tfw);

                    if (Flag)

                    {

                        Console.WriteLine(custString);

                        v4 = int.Parse(Console.WriteLine());

                        if (v4 == bfg)

                        {
                            Console.WriteLine(custString);
                            v5 = int.Parse(Console.WriteLine());
                            v6 = int.Parse(Console.WriteLine());
                            Flag = (v5 == tfw) && (v5 == tfc) || (v6 == bf);

                            if (Flag)

                            {
                                Console.WriteLine(custString);
                                v7 = int.Parse(Console.WriteLine(custString));

                                if (v7 == tfg)

                                {

                                    Console.WriteLine("Succed!");

                                }

                                else

                                {

                                    Console.WriteLine("Failure :(");
                                }
                            }

                            else
                            {
                                Console.WriteLine("Failure :(");

                            }
                        }

                        else

                            Console.WriteLine("Failure :(");
                    }
                    else

                        Console.WriteLine("Failure :(");
                }

                else
                {
                    Console.WriteLine("Failure :(");


                }





            }


        }
    }


}










//switch (v1)
//{
//    case 3:

//        v1 == tfg;
//        Console.WriteLine(custString);

//         switch (v2)
//        {

//            case 8:
//                v2 == tfc;
//                Console.WriteLine(custString);

//                switch (v3) 

//                    {

//                    case 2:

//                        v3 == tfg; 
//                        Console.WriteLine(custString);

//                    case 1:

//                        v3 == 

//                        switch (v4)

//                        {
//                            case 4:

//                                v4 == 

//                        }











#endregion

#region calculator
static void Calculator()
{


    Console.WriteLine("Enter first digit");
    double a;
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter an operator");
    Console.WriteLine("For exponentiation operation put '!'");
    string action = "";
    action = Console.ReadLine();
    Console.WriteLine("Enter second digit");
    double b;
    b = double.Parse(Console.ReadLine());
    double res;

    if (b == 0)

    {

        Console.WriteLine("Error! You can't divide by null");
    }
    switch (action)
    {

        case "+":

            res = a + b;
            Console.WriteLine(res);
            break;

        case "-":

            res = a - b;
            Console.WriteLine(res);
            break;

        case "/":

            res = a / b;
            Console.WriteLine(res);
            break;

        case "*":

            res = a * b;
            Console.WriteLine(res);
            break;
        case "!":
            res = Math.Pow(a, b);
            Console.WriteLine(res);
            break;



        default:
            Console.WriteLine("Wrong operator");
            break;
    }



}
#endregion

#region Factorial
static void Factorial_calculation()
{

    int n;
    Console.WriteLine("Plaese enter digit");

    n = int.Parse(Console.ReadLine());
    int res = 1;
    if (n < 0)

    {

        throw new ArgumentException("Number can't be negative");
    }

    while (n > 1)

    {

        res *= n--;

    }
    Console.WriteLine(res);
}
#endregion
