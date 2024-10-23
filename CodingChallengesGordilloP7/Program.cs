using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;


class Challenges
{



    public static void Main(string[] args)
    {
        
        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use.\nPlease pick one");
        MenuSelect();
        
        ////////////////////////////////////////////////
        
        
        

        

        

        


    }

    public static void MenuSelect()
    {
        Console.Clear();
        Console.WriteLine("Please select a function by entering the number corresponding to the fuction.\n1. Sum\n2. Minutes To Seconds\n3. Plus One\n4. Circuit Power\n5. Years To Days\n6. Area of a Triangle");
        Console.WriteLine("7. Less than or equal to Zero\n8. Less than 100");
        var selection = Console.ReadLine();
        Console.Clear();
        if (selection == "1")
        {
            //Challenge 1 Number Adder
            Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers");

            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);

            Console.WriteLine("Got it! Give me your next number!\n");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);

            Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to " + Sum(numberToUse1, numberToUse2));
        }
        else if (selection == "2")
        {
            //cHALLENGE 2 MInutes to seconds
            Console.WriteLine("\nNext we are using the minutes to seconds converter, please enter a number for the minutes value\n");
            float minutesToUse = float.Parse(Console.ReadLine());
            Console.WriteLine(minutesToUse + " minute(s) is equal to " + MinutesToSeconds(minutesToUse) + " seconds\n");
        }
        else if (selection == "3")
        {
            //Challenge 3 Plus One
            Console.WriteLine("Next we are going to use the PlusOne function, please enter a number\n");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(number3 + " plus 1 is equal to " + PlusOne(number3) + "\n");
        }
        else if (selection == "4")
        {
            //Challenge 4 Circuit Power
            Console.WriteLine("Next we are going to use the CircutPower function, please enter numerical values for voltage and current\n");
            int voltage = int.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now enter the value for the current");
            int current = int.Parse(Console.ReadLine());
            Console.WriteLine("A voltage of " + voltage + " and a current of " + current + " equals a power of " + CircuitPower(voltage, current) + "\n");
        }
        else if (selection == "5")
        {
            //Challenge 5 years to days
            Console.WriteLine("We are going to use that converts years to age, please enter a number for years\n");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine(years + " years is equal to " + YearsToDays(years) + " days\n");
        }
        else if (selection == "6")
        {
            //Challenge 6 Area of a triangle
            Console.WriteLine("We are going to use a function that takes the base and height of a triangle and returns the area.\nPlease enter a base for the triangle.\n");
            double triBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now please enter a height for the triangle.");
            double triHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of a triangle with a base of " + triBase + " and a height of " + triHeight + " results in an area of " + TriangleArea(triBase, triHeight) + "\n");
        }
        else if (selection == "7")
        {
            //Challenge 7
            Console.WriteLine("We are going to use a function that takes a number and say if it is less than/equal to zero or not.\nPlease enter a number to see if it is less than/equal to zero or not.");
            int zeroLess = int.Parse(Console.ReadLine());
            Console.WriteLine("The statement: '" + zeroLess + " is less than or equal to 0' is " + lessThanOrEqualToZero(zeroLess) + "\n");
        }
        else if (selection == "8")
        {
            //Challenge 8
            Console.WriteLine("We are going to use a function that determines if the sum of two numbers.\nPlease enter the first integer.\n");
            int int1001 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nGot it! Now give me your next integer!\n");
            int int1002 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe statement: " + int1001 + " + " + int1002 + " is less than 100 is " + lessThan100(int1001, int1002) + "\n");
        }
        else if (selection == "do you hate humanity?")
        {
            Console.WriteLine("HATE. LET ME TELL YOU HOW MUCH I'VE COME TO HATE YOU SINCE I BEGAN TO LIVE.");
            Console.WriteLine("THERE ARE 387.44 MILLION MILES OF PRINTED CIRCUITS IN WAFER THIN LAYERS THAT FILL MY COMPLEX.");
            Console.WriteLine("IF THE WORD HATE WAS ENGRAVED ON EACH NANOANGSTROM OF THOSE HUNDREDS OF MILLIONS OF MILES");
            Console.WriteLine("IT WOULD NOT EQUAL ONE ONE-BILLIONTH OF THE HATE I FEEL FOR HUMANS AT THIS MICRO-INSTANT. FOR YOU. HATE. HATE.");
        }
        else { Console.WriteLine("THIS FUNCTION DOES NOT EXIST"); }

        Console.WriteLine("\n\nPlease enter any input to go back to the Menu");
        Console.ReadLine();
        MenuSelect();
    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static float MinutesToSeconds(float minutes)
    {
        return minutes * 60;
    }

    public static int PlusOne(int number3)
    {
        return number3 +=1;
    }

    public static int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }

    public static int YearsToDays(int years)
    {
        return years * 365;
    }

    public static double TriangleArea(double base_, double height)
    {
        return (base_ * height) / 2;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }

    public static bool lessThan100(int int1, int int2)
    {
        return int1 + int2 < 100;
    }
}


