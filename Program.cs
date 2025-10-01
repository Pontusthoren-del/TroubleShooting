using System.Collections;

namespace TroubleShooting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Case 1
            //int number = 2;

            //if (number > 3)
            //{
            //    Console.WriteLine("Talet är större än tre"); // ; was missing, putting it at the end made it work.
            //}
            //else if (number < 3)// elseif was put together, separate it and it was working.
            //{
            //    Console.WriteLine("Talet är mindre än tre");
            //}


            ////Case 2
            //for (int i = 1; i < 101; i++) // Changing the number from 100 to 101 will make it print the numbers right.
            //{
            //    Console.WriteLine(i);
            //}

            //Case 3
            //for (int i = 1; i <= 5; i++) // Add 1 each time until it reaches 5. I added ++ after the i.
            //{
            //    for (int j = 1; j <= i; j++) //Add 1 to j each time until it reaches i. Added ++ here aswell.
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}


            ////Case 4
            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");// Added j and "" . J is the number and "" for a space between the numbers. 
            //    }

            //    Console.WriteLine();
            //    i++;
            //}


            ////Case 5
            //int i = 1;

            //switch (i)
            //{
            //    case 1: //Adding a break; so it will not fall through to case 2. Now it wont write out anything.
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            ////Case 6
            //int i = 10;

            //if (i == 5) //Adding a == to see if "i" is 5, but "i" is 10 so it will not write out anything.
            //{
            //    Console.WriteLine("i är 5");
            //}

        }
    }
}
