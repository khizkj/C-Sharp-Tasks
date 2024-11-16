using System;
class HelloWorld {
  static void Main() {
        Console.WriteLine("Welcome " + "Khizer");
        Console.WriteLine("The following questions range from 1 - 30. Which question would you like to attempt first?");
        string choose;
        choose = Console.ReadLine();
        switch(choose){
            
            case "1": case "one":
            Console.WriteLine("Write a program that takes an integer input and checks if it's positive, negative, or zero.");
            int integer;
            Console.WriteLine("Enter a integer value. ");
            integer = Convert.ToInt32(Console.ReadLine());
            
            if(integer > 0)
            {
                Console.WriteLine("The Integer you wrote is positive.");
            }
            else
            {
                Console.WriteLine("The integer is negative.");
            }
            break;
            
            
            
            case "2": case "two":
            Console.WriteLine("Create a program to check if a given integer is even or odd.");
            int integer1;
            Console.WriteLine("Enter a integer value.");
            integer1 = Convert.ToInt32(Console.ReadLine());
            if(integer1%2 == 0)
            {
                Console.WriteLine("The Integer you put is Even.");
            }
            else
            {
                Console.WriteLine("The Integer you have put is odd.");
            }
            break;
            
            
            case "3": case "three":
            Console.WriteLine("Write a program that takes two integers and prints the greater of the two using if-else.");
            int num1,num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if(num1 > num2)
            {
                Console.WriteLine(num1 +" Is Greater Then "+num2);
            }
            else
            {
                Console.WriteLine(num2 +" Is Greater Then "+num1);
            }
            
            break;
            
            
            
            case "4": case "four":
            Console.WriteLine("Write a program to check if a person is eligible to vote based on their age (age should be 18 or older).");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 18)
            {
                Console.WriteLine("You are Eligible to vote");
            }
            else
            {
                Console.WriteLine("You are far too young to be voting go play video games.");
            }
            break;
            
            
            case "5": case "five":
            Console.WriteLine("Create a program to determine if a given year is a leap year using if-else");
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4 == 0)
            {
                Console.WriteLine("The year you have entered is in fact a leap year");
            }
            else
            {
                Console.WriteLine("The year you have entered is not a leap year");
            }
            break;
            
            
            case "6": case "six":
            Console.WriteLine("Write a program to check whether a given number is positive, negative, or zero using if-else.");
            int integer2;
            integer2 = Convert.ToInt32(Console.ReadLine());
            if(integer2 > 0)
            {
                Console.WriteLine("The integer you wrote is positive.");
            }
            else if(integer2 == 0)
            {
                Console.WriteLine("The integer you wrote is 0");
            }
            else
            {
                Console.WriteLine("The integer you wrote is negative.");
            }
            break;
            
            case "7": case "seven":
            Console.WriteLine("Write a program to assign a grade based on marks (A, B, C, D, or F) using if-else.");
            int grade = Convert.ToInt32(Console.ReadLine());
            if(grade > 80)
            {
                Console.WriteLine("Your Grade is A.");
            }
            else if(grade > 70)
            {
                Console.WriteLine("Your Grade is B.");
            }
            else if(grade > 60)
            {
                Console.WriteLine("Your Grade is C.");
            }
            else if(grade > 50)
            {
                Console.WriteLine("Your Grade is D.");
            }
            else
            {
                Console.WriteLine("Your Grade is F.");
            }
            break;
            
            case "8": case "eight":
            Console.WriteLine(" Develop a calculator program using switch-case to perform basic arithmetic operations (+, -, *, /) on two numbers.");
            int numb1 , numb2;
            Console.WriteLine("Enter the first number");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operations (+, -, *, /) you want to use.");
            string opr = Console.ReadLine();
            switch(opr){
                case "+":
                Console.WriteLine(numb1 +" + "+numb2 +" = " + (numb1+numb2));
                break;
                case "-":
                Console.WriteLine(numb1 +" - "+numb2 +" = " + (numb1-numb2));
                break;
                case "*":
                Console.WriteLine(numb1 +" * "+numb2 +" = " + (numb1*numb2));
                break;
                case "/":
                Console.WriteLine(numb1 +" / "+numb2 +" = " + (numb1/numb2));
                break;
                default:
                Console.WriteLine("Incorrect operation.");
                break;
            }
            
            break;
            case "9": case "nine":
            Console.WriteLine("Write a program to display the day of the week based on an integer (1 for Monday, 2 for Tuesday, etc.) using switch-case.");
            int day = Convert.ToInt32(Console.ReadLine());
            switch(day){
                case 1:
                Console.WriteLine("Today is Monday");
                break;
                case 2:
                Console.WriteLine("Today is Tuesday");
                break;
                case 3:
                Console.WriteLine("Today is Wednesday");
                break;
                case 4:
                Console.WriteLine("Today is Thursday");
                break;
                case 5:
                Console.WriteLine("Today is Friday");
                break;
                case 6:
                Console.WriteLine("Today is Saturday");
                break;
                case 7:
                Console.WriteLine("Today is Sunday");
                break;
                default:
                Console.WriteLine("The Integer Should be in the range of 1 - 7.");
                break;
            }
            
            break;
            case "10": case "ten":
            Console.WriteLine("Create a program to display the name of a month based on a number (1 for January, 2 for February, etc.) using switch-case.");
            int month = Convert.ToInt32(Console.ReadLine());
            switch(month){
                case 1:
                Console.WriteLine("The Month is January");
                break;
                case 2:
                Console.WriteLine("The Month is February");
                break;
                case 3:
                Console.WriteLine("The Month is March");
                break;
                case 4:
                Console.WriteLine("The Month is April");
                break;
                case 5:
                Console.WriteLine("The Month is May");
                break;
                case 6:
                Console.WriteLine("The Month is June");
                break;
                case 7:
                Console.WriteLine("The Month is July");
                break;
                case 8:
                Console.WriteLine("The Month is August");
                break;
                case 9:
                Console.WriteLine("The Month is September");
                break;
                case 10:
                Console.WriteLine("The Month is October");
                break;
                case 11:
                Console.WriteLine("The Month is November");
                break;
                case 12:
                Console.WriteLine("The Month is December");
                break;
                default:
                Console.WriteLine("The Integer Should be in the range of 1 - 12.");
                break;
            }
            break;
            case "11": case "eleven":
            Console.WriteLine("Write a program that checks if a number is divisible by 5 and 11 using if-else.");
            Console.WriteLine("Enter an integer.");
            int inz = Convert.ToInt32(Console.ReadLine());
            if(inz / 5 == 0 && inz / 11 == 0)
            {
                Console.WriteLine("The integer you typed is divisible by 5 and 11.");
            }
            else
            {
                Console.WriteLine("The integer you typed is not at all divisible by 5 and 11.");
            }
            break;
            case "12": case "twelve":
            Console.WriteLine("Write a program to check if a given character is a vowel or consonant using switch-case");
            Console.WriteLine("Write a character that is a vowel");
            string character = Console.ReadLine();
            switch(character){
                case "a":case "A":
                case "e":case "E":
                case "i":case "I":
                case "o":case "O":
                case "u":case "U":
                Console.WriteLine("The character you typed is a vowel.");
                break;
                default:
                Console.WriteLine("The character you typed is not a vowel.");
                break;
            }
            
            break;
            case "13": case "thirteen":
            Console.WriteLine("Extend the calculator program to include modulus operation (%) using switch-case");
            int numb3,numb4;
            Console.WriteLine("Enter the first number");
            numb3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            numb4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operations (+, -, *, /,%) you want to use.");
            string oprz = Console.ReadLine();
            switch(oprz){
                case "+":
                Console.WriteLine(numb3 +" + "+numb4 +" = " + (numb3+numb4));
                break;
                case "-":
                Console.WriteLine(numb3 +" - "+numb4 +" = " + (numb3-numb4));
                break;
                case "*":
                Console.WriteLine(numb3 +" * "+numb4 +" = " + (numb3*numb4));
                break;
                case "/":
                Console.WriteLine(numb3 +" / "+numb4 +" = " + (numb3/numb4));
                break;
                case "%":
                Console.WriteLine(numb3 +" % "+numb4 +" = " + (numb3%numb4));
                break;
                default:
                Console.WriteLine("Incorrect operation.");
                break;
            }
            break;
            case "14": case "fourteen":
            Console.WriteLine("Write a program to find the largest of three numbers using nested if-else.");
            int one , two , three;
            Console.WriteLine("Write The first number");
            one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write The Second number");
            two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write The Third number");
            three = Convert.ToInt32(Console.ReadLine());
            
            if(one > two)
            {
                if (one > three)
                {
                    Console.WriteLine(one +" Is the greater number among the three");
                }
                else
                {
                    Console.WriteLine(three +" Is the greater number among the three");
                }
            }
            else if(two > one)
            {
                if(two > three)
                {
                    Console.WriteLine(two +" Is the greater number among the three");
                }
                else
                {
                    Console.WriteLine(three +" Is the greater number among the three");
                }
            }
            else if(three > one)
            {
                if(three > two)
                {
                    Console.WriteLine(three +" Is the greater number among the three");
                }
                else
                {
                    Console.WriteLine(two +" Is the greater number among the three");
                }
            }
            else
            {
                Console.WriteLine("Its just zero");
            }
            
            
            break;
            case "15": case "fifteen":
            Console.WriteLine("Write a program to classify a character as uppercase, lowercase, digit, or special character using if-else.");
            Console.WriteLine("Write a character");
            char character1 = Convert.ToChar(Console.ReadLine());
            if(char.IsUpper(character1))
            {
                Console.WriteLine("The character is in uppercase");
            }
            else if(char.IsLower(character1))
            {
                Console.WriteLine("The character is in lowercase");
            }
            else
            {
                Console.WriteLine("it is spacial character");
            }
            
            break;
            case "16": case "sixteen":
            Console.WriteLine(" Write a program to check if a person is eligible for a driving license based on age and a test result using if-else.");
            Console.WriteLine("Enter your age.");
            int agee = Convert.ToInt32(Console.ReadLine());
            if(agee >18)
            {
                Console.WriteLine("You are Eligible for a driving license test.");
                Console.WriteLine("Did you pass or fail the test");
                string test = Console.ReadLine();
                if(test == "pass" )
                {
                    Console.WriteLine("Congrats you shall recieve your driving license");
                }
                else
                {
                    Console.WriteLine("You failed try again next time.");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible for a driving license test because u are too young.");
            }
            
            
            break;
            case "17": case "seventeen":
            Console.WriteLine("Write a program to calculate a bonus for employees based on years of service using if-else (e.g., 5+ years gets a 10% bonus, others get 5%).");
            Console.WriteLine("Enter Your years of service");
            int service_years = Convert.ToInt32(Console.ReadLine());
            if(service_years >= 5)
            {
                Console.WriteLine("You shall receive a bonus of 10%");
            }
            else
            {
                Console.WriteLine("You shall receive a bonus of 5%");
            }
            
            break;
            case "18": case "eighteen":
            Console.WriteLine("Write a program to calculate BMI and categorize it (Underweight, Normal, Overweight, Obese) using if-else.");
            double bmi, height, weight;
            Console.WriteLine("Enter Your Weight in kilograms");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters");
            height = Convert.ToDouble(Console.ReadLine());
            bmi = weight / (height * height);
            if(bmi < 18.5)
            {
                Console.WriteLine("You are Underweight Your bmi is "+ bmi);
            }
            else if(bmi < 25)
            {
                Console.WriteLine("You are Healthy weight Your bmi is "+ bmi);
            }
            else if(bmi < 30)
            {
                Console.WriteLine("You are Overweight your bmi is " + bmi);
            }
            else if(bmi > 30)
            {
                Console.WriteLine("You are Obese your bmi is " + bmi);
                if (bmi > 30 && bmi < 35)
                {
                    Console.WriteLine("your obesity class is 1");
                }
                else if (bmi >35 && bmi < 40)
                {
                    Console.WriteLine("Your obesity class is 2");
                }
                else
                {
                    Console.WriteLine("Your obesity class is 3");
                }
            }
            else
            {
                Console.WriteLine("You are a spacial case.");
            }
            
            break;
            case "19": case "nineteen":
            Console.WriteLine("");
            Console.WriteLine("Write a program to find the largest of three numbers using nested if-else.");
            int ones , twos , threes;
            Console.WriteLine("Write The first number");
            ones = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write The Second number");
            twos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write The Third number");
            threes = Convert.ToInt32(Console.ReadLine());
            
            if(ones < twos)
            {
                if (ones < threes)
                {
                    Console.WriteLine(ones +" Is the smallest number among the three");
                }
                else
                {
                    Console.WriteLine(threes +" Is the smallest number among the three");
                }
            }
            else if(twos < ones)
            {
                if(twos < threes)
                {
                    Console.WriteLine(twos +" Is the smallest number among the three");
                }
                else
                {
                    Console.WriteLine(threes +" Is the smallest number among the three");
                }
            }
            else if(threes < ones)
            {
                if(threes < twos)
                {
                    Console.WriteLine(threes +" Is the smallest number among the three");
                }
                else
                {
                    Console.WriteLine(twos +" Is the smallest number among the three");
                }
            }
            else
            {
                Console.WriteLine("Its just zero");
            }
            break;
            case "20": case "twenty":
            Console.WriteLine("Write a program that takes an integer and checks if it’s odd or even using switch-case.");
            Console.WriteLine("Enter a integer");
            int numz = Convert.ToInt32(Console.ReadLine());
            
            switch(numz % 2){
                case 0:
                Console.WriteLine("the integer is Even");
                break;
                case 1:
                Console.WriteLine("the integer is odd");
                break;
                default:
                Console.WriteLine("Erro occured retry");
                break;
            }
            
            break;
            case "21": case "twenty-one":
            Console.WriteLine("Write a currency converter program using switch-case to convert between dollars, euros, and pounds.");
            string convertor;
            convertor = Console.ReadLine();
        
            switch(convertor){
                case "dollar":
                Console.WriteLine("Enter your pkr rupees to convert it into dollars");
                double money = Convert.ToDouble(Console.ReadLine());
                money = money * 0.0034;
                Console.WriteLine("Your Money in dollars is "+money);
                break;
                case "euro":
                Console.WriteLine("Enter your pkr rupees to convert it into dollars");
                double money1 = Convert.ToDouble(Console.ReadLine());
                money = money1 * 0.0031;
                Console.WriteLine("Your Money in euros is "+money1);
                break;
                case "pound":
                Console.WriteLine("Enter your pkr rupees to convert it into dollars");
                double money2 = Convert.ToDouble(Console.ReadLine());
                money = money2 * 0.0026;
                Console.WriteLine("Your Money in euros is "+money2);
                break;
                default:
                Console.WriteLine("retry");
                break;
                
            }
            break;
            case "22": case "twenty-two":
            Console.WriteLine("Updating soon...");
            break;
            case "23": case "Write a program to check if a number is positive and even, positive and odd, negative and even, or negative and odd using if-else.":
            
            Console.WriteLine("Write an integer.");
            int inta = Convert.ToInt32(Console.ReadLine());
            if(inta > 0 && inta%2 == 0)
            {
                Console.WriteLine("The above integer is positive and Even");
            }
            else if(inta > 0 && inta%2 != 0)
            {
                Console.WriteLine("The above integer is positive and odd");
            }
            else if (inta < 0 && inta%2 == 0)
            {
                Console.WriteLine("The above integer is negative and Even");
            }
            else if (inta < 0 && inta%2 != 0)
            {
                Console.WriteLine("The above integer is negative and odd");
            }
            else
            {
                Console.WriteLine("just zero");
            }
            break;
            case "24": case "twenty-four":
            Console.WriteLine("Write a program to identify the quadrant of a point (x, y) using if-else.");
            double x, y;
            Console.Write("Enter the x-coordinate: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y-coordinate: ");
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant 1.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant 2.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant 3.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant 4.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("The point is on the Y-axis.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("The point is on the X-axis.");
            }
            else
            {
                Console.WriteLine("The point is at the origin.");
            }
            
            break;
            case "25": case "twenty-five":
            Console.WriteLine("updating soon...");
            break;
            case "26": case "twenty-six":
            Console.WriteLine("updating soon...");
            break;
            case "27": case "twenty-seven":
            Console.WriteLine("updating soon...");
            break;
            case "28": case "twenty-eight":
            Console.WriteLine("updating soon...");
            break;
            case "29": case "twenety-nine":
            Console.WriteLine("updating soon...");
            break;
            case "30": case "thirty":
            Console.WriteLine("updating soon...");
            break;
            default:
            Console.WriteLine("The Number should be between the range of 1-39.");
            break;
        }
  }
}
