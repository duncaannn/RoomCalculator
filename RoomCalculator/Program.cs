using System;

namespace RoomCalculator
{
    class Program


    {
        static void Main(string[] args)



        {

            while (true)
            {
                decimal length;
                decimal width;
                decimal height;
                Console.WriteLine("Let's calculate the perimeter and area of the classroom.");
                Console.WriteLine("What is the length of the room in feet?");
                length = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the width of the room in feet?");
                width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the height of the room in feet?");
                height = Convert.ToDecimal(Console.ReadLine());
                decimal area;
                decimal perimeter;
                decimal volume;
                area = length * width;
                perimeter = 2 * (length * width);
                volume = length * width * height;

                Console.WriteLine("The area is " + area + " feet");
                Console.WriteLine("The perimeter is " + perimeter + " feet");

                Console.WriteLine("Would you like to continue onto calculating the volume? y/n");




                string userresponse = Console.ReadLine();

                if (userresponse == "y")
                {
                    Console.WriteLine("The volume is " + volume + " feet");




                }

                Console.WriteLine("Would you like to continue measuring rooms? yes/no");
                string secondresponse = Console.ReadLine();


                if (secondresponse != "yes")
                    break;

                else if (userresponse == "n")
                {







                    //Console.WriteLine("Would you like to continue measuring rooms? yes/no");
                    //string thirdresponse = Console.ReadLine();


                    //if (thirdresponse != "yes")
                    //break;
                }
            }
        }
    }
}
