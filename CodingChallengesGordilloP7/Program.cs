using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


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
        Console.WriteLine("7. Less than or equal to Zero\n8. Less than 100\n9. Is equal to\n10. Something\n13. Sum of Internal Angles\n14. Edabit\n15. True&&\n16. Basketball");
        Console.WriteLine("17. Find Perimeter\n18. Hello User\n19. Animals\n20. Football Points\n21. Months");
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
        else if (selection == "9")
        {
            //Challenge 9
            Console.WriteLine("We are going to use a function that takes two integers and check if they're equal\nPlease enter the first integer.\n");
            int isEqual1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Got it! now enter the next integer!\n");
            int isEqual2 = int.Parse(Console.ReadLine());
            if (isEqual(isEqual1, isEqual2))
            {
                Console.WriteLine(isEqual1 + " and " + isEqual2 + " are equal\n");
            }
            else { Console.WriteLine(isEqual1 + " and " + isEqual2 + " are not equal\n"); }
        }
        else if (selection == "10")
        {
            //Challenge 10
            Console.WriteLine("We are going to use a function that takes a user input of text and puts that after the word something.\nPlease enter some text\n");
            string something = Console.ReadLine();
            Console.WriteLine("something " + something + "\n");
        }
        else if (selection == "11")
        {
            //Challenge 11
            Console.WriteLine("We are going use a function that switches the user's input 'true' to 'false' and vice versa.\n Please enter either true or false\n");

        }
        else if (selection == "12")
        {
            //Challenge 12
        }
        else if (selection == "13")
        {
            //Challenge 13
            Console.WriteLine("We will be using a function that takes the number of internal angles in a polygon\nand returns the sum of all the measures in that polygon.\nPlease enter the number of angles for your polygon\n");
            int polyAngles = int.Parse(Console.ReadLine());
            if (polyAngles > 2)
            {
                Console.WriteLine("A " + polyAngles + " sided polygon's sum of angles would be " + SumPolygon(polyAngles) + " degrees\n");
            }
            else { Console.WriteLine("A " + polyAngles + " sided polygon does not exist so therefore it would not have a sum of angles.\n"); }
        }
        else if (selection == "14")
        {
            //Challenge 14
            Console.WriteLine("We are going to use a function that takes a user input of text and puts that before the word Edabit.\nPlease enter some text\n");
            string Edabit = Console.ReadLine();
            Console.WriteLine(Edabit + "Edabit" + "\n");
        }
        else if (selection == "15")
        {
            //Challenge 15
            Console.WriteLine("We are going to use a function that determines if Boolean A and Boolean B are both true\nand the user will decide whether the booleans are true or not.\nPlease enter true or false for Boolean A\n");
            bool A = bool.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now enter either true or false for Boolean B");
            bool B = bool.Parse(Console.ReadLine());
            Console.WriteLine("And(" + A + ", " + B + ") --> " + TwoBoolean(A, B) + "\n");
        }
        else if (selection == "16")
        {
            //Challenge 16
            Console.WriteLine("We are using a function that takes the amount of two pointers and three pointers during a basketball game\nand adds up the total number of points.\nPlease enter an integer for two-pointers");
            int twoPointersValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now enter an integer value for three-pointers");
            int threePointersValue = int.Parse(Console.ReadLine());
            Console.WriteLine(twoPointersValue + " two pointers and " + threePointersValue + " three pointers adds up to a total of " + BasketBall(twoPointersValue, threePointersValue) + " points\n");
        }
        else if (selection == "17")
        {
            //Challenge 17
            Console.WriteLine("We are using a function that takes the length and width of a rectangle and calcucates a perimeter\nPlease enter an integer for the length");
            int lengthPeri = int.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now enter an integer for the width");
            int widthPeri = int.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of your rectangle is " + FindPerimeter(lengthPeri, widthPeri) + "\n");
        }
        else if (selection == "18")
        {
            //Challenge 18
            Console.WriteLine("We are using a function that takes thye user's name and greets them.\n Please enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
        }
        else if (selection == "19")
        {
            //Challenge 19
            Console.WriteLine("We are using a function that takes a number of pigs, chickens and cows and counts the total number of animal legs\nPlease enter a number of chickens");
            int chickenNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Now for cows");
            int cowNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Now for pigs");
            int pigNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("There is a total of " + Animals(chickenNumber, cowNumber, pigNumber) + " legs");
        }
        else if (selection == "20")
        {
            //Challenge 20
            Console.WriteLine("We are using a function that takes the number of wins, draws and and losses and calculates the number of points a football team has obtained so far.\n Please enter a number for wins");
            int footballWins = int.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now give me a number for draws");
            int footballDraws = int.Parse(Console.ReadLine());
            Console.WriteLine("Got it! Now give me a number for losses");
            int footballLosses = int.Parse(Console.ReadLine());
            Console.WriteLine(FootballPoints(footballWins, footballDraws, footballLosses));
        }
        else if (selection == "21")
        {
            //Challenge 21
            
            Console.WriteLine("We are using a function that takes a number between 1 through 12 and outputs the corresponding month of the year");
            Months();
            
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
        return number3 += 1;
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

    public static bool isEqual(int number1, int number2)
    {
        return number1 == number2;
    }

    public static int SumPolygon(int polyInt)
    {
        return (polyInt - 2) * 180;
    }

    public static bool TwoBoolean(bool one, bool two)
    {
        return one && two;
    }

    public static int BasketBall(int twoPointers, int threePointers)
    {
        return twoPointers * 2 + threePointers * 3;
    }

    public static int FindPerimeter(int length, int width)
    {
        return 2 * length + 2 * width;
    }

    public static int Animals(int chickens, int cows, int pigs)
    {
        if (chickens * 2 + cows * 4 + pigs * 4 < 0)
        {
            return 0;
        }
        else { return chickens * 2 + cows * 4 + pigs * 4; }
    }

    public static string FootballPoints(int wins, int draws, int losses)
    {
        if (wins < 0) { wins = 0; }
        if (draws < 0) { draws = 0; }
        if (losses < 0) { losses = 0; }
        int points = wins * 3 + draws;
        return "Football(" + wins + ", " + draws + ", " + losses + ") --> " + points;
    }

    public static string MonthsSafeCheck(string number)
    {
        if (number == "1") { return "janury"; }
        else if (number == "2") { return "february"; }
        else if (number == "3") { return "march"; }
        else if (number == "4") { return "april"; }
        else if (number == "5") { return "may"; }
        else if (number == "6") { return "june"; }
        else if (number == "7") { return "july"; }
        else if (number == "8") { return "august"; }
        else if (number == "9") { return "september"; }
        else if (number == "10") { return "october"; }
        else if (number == "11") { return "november"; }
        else if (number == "11") { return "december"; }
        else
        {
            return "error";
            Months();
        }
    }

    public static void Months()
    {
        var monnthNum = Console.ReadLine();
        if (MonthsSafeCheck(monnthNum) == "error")
        {
            Console.WriteLine("please enter a number 1 through 12");
            Months();
        }
        else
        {
            Console.WriteLine("MonthName(" + monnthNum + ") --> " + MonthsSafeCheck(monnthNum));
        }
    }
}

