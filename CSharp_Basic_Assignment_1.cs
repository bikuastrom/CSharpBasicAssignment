// See https://aka.ms/new-console-template for more information

using static System.Console;

static void RunExerciseOne()
{
    string firstName = "Victoria";
    string lastName = "Åström";

    WriteLine($"Hello {firstName} {lastName}! I’m glad to inform you that you are the test subject of my very first assignment!");

    ReadKey();
}

static void RunExerciseTwo()
{
    Write("First Name: ");
    string firstName = ReadLine();

    Write("Last Name: ");
    string lastName = ReadLine();

    WriteLine($"Hey {firstName} {lastName}! Have a nice day!");

    ReadKey();
}

static void RunExerciseThree()
{
    Write("Enter a number  ");
    int firstNumber = int.Parse(ReadLine());

    Write("Enter the consecutive number ");
    int secondNumber = int.Parse(ReadLine());

    if (firstNumber == secondNumber + 1 || secondNumber == firstNumber + 1)
    {
        WriteLine("The numbers are consecutive");
    }

    else
    {
        Write("The numbers are not consecutive");
    }

    ReadKey();
}

static void RunExerciseFour()
{
    DateTime todaysDate = DateTime.Now;
    WriteLine(todaysDate);
    WriteLine(todaysDate.ToString("dddd, dd MMMM yyyy"));
    WriteLine(todaysDate.ToString("ddd, dd MMM yyyy"));
    DateTime yesterdayDate = DateTime.Now.AddDays(-1);
    DateTime tomorrowDate = DateTime.Now.AddDays(1);
    WriteLine($"Yesterday was {yesterdayDate.ToString("d")} and tomorrow is {tomorrowDate.ToString("d")}");

    ReadKey();
}

static void RunExerciseFive()
{
    int integerOne = 5, integerTwo = 7;
    double sum = integerOne + integerTwo;

    double decimalOne = 5.6, decimalTwo = 7.3;
    int sumDecimal = Convert.ToInt32(decimalOne + decimalTwo);

    int oddNum = 19;
    double evenNum = 4;
    double sumOddEven = oddNum / evenNum;

    Write($"{integerOne} + {integerTwo} = {sum}\n{decimalOne} + {decimalTwo} = {sumDecimal}\n{oddNum} / {evenNum} = {sumOddEven}");

    ReadKey();
}

static void RunExerciseSix()
{
    int x = 40;
    int y = 20;
    int z = 25;
    int m = 15;
    int e, f, g, h;

    e = (x + y) * z / m;
    WriteLine(e);

    f = x + y * (z / m);
    WriteLine(f);

    g = x + y * z / m;
    WriteLine(g);

    h = (x + (y * z)) / m;
    WriteLine(h);

    ReadKey();
}

static void RunExerciseSeven()
{
    Write("Enter a whole number  ");
    int num = int.Parse(ReadLine());

    if (num % 2 == 0)
    {
        WriteLine("Number is even");
    }
    else
    {
        WriteLine("Number is odd");
    }

    ReadKey();
}

static void RunExerciseEight()
{
    Random randomNumber = new Random();
    List<int> listOddEven = new List<int>();
    List<int> listEven = new List<int>();
    List<int> listOdd = new List<int>();

    for (int i = 0; i < 20; i++)
    {
        listOddEven.Add(randomNumber.Next(500));
    }
    WriteLine("The numbers are: " + string.Join(", ", listOddEven));

    for (int i = 0; i < 20; i++)
    {
        if (listOddEven[i] % 2 == 0)
        {
            listEven.Add(listOddEven[i]);
        }
        else
        {
            listOdd.Add(listOddEven[i]);
        }
    }
    WriteLine("The even numbers are " + string.Join(", ", listEven));
    WriteLine("The odd numbers are " + string.Join(", ", listOdd));

    ReadKey();
}

static void RunExerciseNine()
{
    Write("Enter the radius of your circle or sphere  ");
    double radius, circleArea, sphereArea;
    radius = double.Parse(ReadLine());

    circleArea = radius * radius * Math.PI;
    WriteLine($"The area of your circle is {circleArea}");

    sphereArea = circleArea * 4;
    WriteLine($"The area of your sphere is {sphereArea}");
    ReadKey();
}

static void RunExerciseTen()
{
    int[] arrayPosNeg = new int[10];

    for (int i = 0; i < 10; i++)
    {
        Write("Enter a positive or negative number  ");
        arrayPosNeg[i] = int.Parse(ReadLine());
    }

    for (int i = 0; i < 10; i++)
    {
        if (arrayPosNeg[i] < 0)
            WriteLine(arrayPosNeg[i]);
    }

    ReadKey();
}

static void RunExerciseEleven()
{
    Write("Enter your body temperature in celsius  ");
    double temperature = double.Parse(ReadLine());

    if (temperature > 37.5)
        WriteLine("You have a fever");

    else
        WriteLine("You do not have a fever");

    ReadKey();
}

static void RunExerciseTwelve()
{
    Write("What is the current year?  ");
    int userYear = int.Parse(ReadLine());
    int currentYear = DateTime.Now.Year;

    if (userYear == currentYear)
        WriteLine($"Yes {userYear} is the current year");

    else
        WriteLine($"No {userYear} is not the current year. {currentYear} is the current year");

    ReadKey();
}

static void RunExerciseThirteen()
{
    Write("Enter an operator  +, -, *, /  ");
    char operatorUser = char.Parse(ReadLine());
    Write("Enter a number  ");
    int numOne = int.Parse(ReadLine());
    Write("Enter another number  ");
    int numTwo = int.Parse(ReadLine());


    switch (operatorUser)
    {
        case '+':
            WriteLine(numOne + numTwo);
            break;

        case '-':
            WriteLine(numOne - numTwo);
            break;

        case '*':
            WriteLine(numOne * numTwo);
            break;

        case '/':
            WriteLine(numOne / numTwo);
            break;

        default:
            WriteLine("Invalid input");
            break;
    }
    ReadKey();
}

static void RunExerciseFourteen()
{
    WriteLine("What grade did you get?");
    char userGrade = char.Parse(ReadLine().ToUpper());

    switch (userGrade)
    {
        case 'A':
            WriteLine("Good job! You got the top grade!");
            break;

        case 'B':
            WriteLine("Good job, a B is very good!");
            break;

        case 'C':
            WriteLine("Good job, you did pretty good");
            break;

        case 'D':
            WriteLine("Good job, I'm sure you did your best");
            break;

        case 'E':
            WriteLine("Good job, at least you passed!");
            break;

        case 'F':
            WriteLine("Oh no! Better luck next time!");
            break;

        default:
            WriteLine("That's not a grade");
            break;
    }
    ReadKey();
}

static void RunExerciseFifteen()
{
    Write("Enter a number below 100  ");
    byte ascendingDescending = byte.Parse(ReadLine());

    for (byte i = 1; i <= ascendingDescending; i++)
        WriteLine(i);

    for (byte i = ascendingDescending; i >= 1; i--)
        WriteLine(i);

    byte j = 1;
    while (j <= ascendingDescending)
        WriteLine(j++);

    j = ascendingDescending;
    while (ascendingDescending >= j && j > 0)
        WriteLine(j--);

    j = 1;
    do
        WriteLine(j++);
    while (j <= ascendingDescending);

    j = ascendingDescending;
    do
        WriteLine(j--);
    while (ascendingDescending >= j && j > 0);

    ReadKey();
}

static void RunExerciseSixteen()
{
    Write("Enter a date yyyy-mm-dd  ");
    DateTime userDate = DateTime.Parse(ReadLine());

    int userYear = userDate.Year;
    string cleanDate = userDate.ToString("d");

    DateTime todaysDate = DateTime.Now;

    if (userYear == DateTime.Now.Year)
        WriteLine($"{cleanDate} is in this year");

    else if (userYear < DateTime.Now.Year)
        WriteLine($"{cleanDate} was in a past year");

    else
        WriteLine($"{cleanDate} is in a future year");

    ReadKey();
}

static void RunExerciseSeventeen()
{
    DateTime todaysDate = DateTime.Now;
    int currentYear = todaysDate.Year;

    int i = 1990;
    while (i < currentYear)
    {
        if (DateTime.IsLeapYear(i))
            WriteLine(i);

        i++;
    }

    ReadKey();
}

static void RunExerciseEighteen()
{
    Random randomNumber = new Random();
    int secretNumber = randomNumber.Next();
    int responseY = 0;

    WriteLine("Guess a number");
    int userNumber = int.Parse(ReadLine());

    bool secretIsSecret = true;
    while (secretIsSecret)
    {

        if (userNumber == secretNumber || responseY == secretNumber)
        {
            WriteLine("That's correct!");
            secretIsSecret = false;
        }

        else
        {
            Write("Incorrect. Guess again or type \"N\"  ");
            string response = ReadLine();

            if (response == "N")
                break;

            else
                responseY = Convert.ToInt32(response);
        }
    }
    ReadKey();
}

static void RunExerciseNineteen()
{
    for (int i = 0; i < 5; i++)
    {
        for (int k = 0; k < i; k++)
        {
            Write(" ");
        }

        for (int j = 5; j > i; j--)
        {
            Write("* ");
        }
        WriteLine();
    }

    ReadKey();
}

static void RunExerciseTwenty()
{
    List<int> userNumbers = new List<int>();
    bool cont = true;

    while (cont == true)
    {
        Write("Enter a number or enter -1 to quit  ");
        int userInput = int.Parse(ReadLine());

        if (userInput == -1)
        {
            cont = false;
        }

        else
        {
            userNumbers.Add(userInput);
        }

    }
    int sum = userNumbers.Sum();
    double average = userNumbers.Average();
    WriteLine($"The sum is {sum}\nThe average is {average}");

    ReadKey();
}

static void RunExerciseTwentyone()
{
    int fibOne = 0;
    int fibTwo = 1;
    WriteLine(fibOne + "\n" + fibTwo);

    while (fibOne < byte.MaxValue && fibTwo < byte.MaxValue)
    {
        fibOne = fibOne + fibTwo;
        WriteLine(fibOne);

        fibTwo = fibTwo + fibOne;
        WriteLine(fibTwo);
    }

    ReadKey();
}

static void RunExerciseTwentytwo()
{
    double TriangleArea(double triangleHeight, double triangleWidth)
    {
        return triangleHeight * triangleWidth / 2;
    }

    Write("Enter your triangles height  ");
    double inputHeight = double.Parse(ReadLine());
    Write("Enter your triangles width  ");
    double inputWidth = double.Parse(ReadLine());

    WriteLine($"Area is {TriangleArea(inputHeight, inputWidth)}");

    ReadKey();
}

static void RunExerciseTwentythree()
{
    MyMethods.AddNumbers(2.643f, 2.345f, 5.342f);

    ReadKey();
}

static void RunExerciseTwentyfour()
{
    int CheckLargest(int a, int b, int c, int d, int e)
    {
        int[] largestArray = { a, b, c, d, e };

        int j = 0;
        for (int i = 0; i < largestArray.Length; i++)
        {
            if (largestArray[i] > j)
                j = largestArray[i];
        }
        return j;
    }

    int largestNum = CheckLargest(3, 7, 1, 2, 8);

    WriteLine($"Largest number in the array is {largestNum}");

    ReadKey();
}

static void RunExerciseTwentyfive()
{
    void Swap(int numberOne, int numberTwo)
    {
        int temp = numberOne;
        numberOne = numberTwo;
        numberTwo = temp;

        WriteLine($"The first number is {numberOne} and the second number is {numberTwo}");
    }

    Write("Input your first number  ");
    int nOne = int.Parse(ReadLine());

    Write("Input your second number  ");
    int nTwo = int.Parse(ReadLine());

    Swap(nOne, nTwo);
    WriteLine($"The first number is {nOne} and the second number is {nTwo}");


    ReadKey();
}

static void RunExerciseTwentysix()
{
    void Swap(ref int numberOne, ref int numberTwo)
    {
        int temp = numberOne;
        numberOne = numberTwo;
        numberTwo = temp;

        WriteLine($"The first number is {numberOne} and the second number is {numberTwo}");
    }

    Write("Input your first number  ");
    int nOne = int.Parse(ReadLine());

    Write("Input your second number  ");
    int nTwo = int.Parse(ReadLine());

    Swap(ref nOne, ref nTwo);
    WriteLine($"The first number is {nOne} and the second number is {nTwo}");

    ReadKey();
}

static void RunExerciseTwentyseven()
{
    WriteLine("Enter a word or sentence");
    string userInput = ReadLine();
    string noSpaceInput = userInput.Replace(" ", "");
    int inputLength = noSpaceInput.Length;
    bool isPalindrome = true;

    for (int i = 0; i < inputLength / 2; i++)
        if (noSpaceInput[i] != noSpaceInput[inputLength - i - 1])
            isPalindrome = false;

    if (isPalindrome == true)
        WriteLine($"{userInput} is a palindrome");

    else
        WriteLine($"{userInput} is not a palindrome");


    ReadKey();
}

static void RunExerciseTwentyeight()
{
    WriteLine("Enter 12 positive integers separated with \",\"");
    string numbersString = ReadLine();
    string[] stringArray = numbersString.Split(",");
    int[] intArray = Array.ConvertAll(stringArray, int.Parse);
    int l = 0, m = 0;

    for (int i = 0; i < 12; i++)
    {
        if (intArray[i] % 2 == 0)
            l++;
        else
            m++;
    }

    int[] arrayEven = new int[l];
    int[] arrayOdd = new int[m];

    for (int i = 0, j = 0, k = 0; i < 12; i++)
    {
        if (intArray[i] % 2 == 0)
        {
            arrayEven[j] = intArray[i];
            j++;
        }
        else
        {
            arrayOdd[k] = intArray[i];
            k++;
        }
    }
    WriteLine("The even numbers are " + string.Join(", ", arrayEven));
    WriteLine("The odd numbers are " + string.Join(", ", arrayOdd));
    ReadKey();
}

static void RunExerciseTwentynine()
{
    int[] randomArray = new int[8];
    int[] sortedArray = new int[8];
    int j = 0;
    Random randomNumber = new Random();

    for (int i = 0; i < 8; i++)
        randomArray[i] = randomNumber.Next(100);

    for (int i = 0; i < 8; i++)
    {
        if (randomArray[i] % 2 == 0)
        {
            sortedArray[j] = randomArray[i];
            j++;
        }
    }

    for (int i = 0; i < 8; i++)
    {
        if (randomArray[i] % 2 != 0)
        {
            sortedArray[j] = randomArray[i];
            j++;
        }
    }

    WriteLine(string.Join(", ", randomArray));
    WriteLine(string.Join(", ", sortedArray));

    ReadKey();
}

static void RunExerciseThirty()
{
    Random randomNumber = new Random();
    int l = randomNumber.Next(5, 15);
    int[] sortingArray = new int[l];
    int[] sortedArray = new int[l];

    for (int i = 0; i < l; i++)
        sortingArray[i] = randomNumber.Next(1, 50);

    for (int i = 0, j = 0; j < l; i++)
    {
        for (int k = 0; k < l; k++)
        {
            if (sortingArray[k] == i)
            {
                sortedArray[j] = sortingArray[k];
                j++;
            }
        }
    }

    WriteLine(string.Join(", ", sortingArray));
    WriteLine(string.Join(", ", sortedArray));
    ReadKey();
}

static void RunExerciseThirtyone()
{
    Random randomNumber = new Random();
    int l = randomNumber.Next(1, 16);
    int[] randomArray = new int[l];
    int[] sqrCubeArray = new int[l];

    for (int i = 0; i < l; ++i)
    {
        int num = randomNumber.Next(1, 100);

        if (randomArray.Contains(num))
        {
            i--;
        }

        else
            randomArray[i] = num;
    }

    WriteLine(string.Join(", ", randomArray));
    Write("Do you want to square or cube the array?  ");
    string response = ReadLine();

    if (response == "square")
        for (int i = 0; i < l; ++i)
            sqrCubeArray[i] = randomArray[i] * randomArray[i];


    else if (response == "cube")
        for (int i = 0; i < l; ++i)
            sqrCubeArray[i] = randomArray[i] * randomArray[i] * randomArray[i];

    WriteLine(string.Join(", ", sqrCubeArray));

    ReadKey();
}

static void RunExerciseThirtytwo()
{
    WriteLine("Enter several numbers separated with \",\"");
    string numbersString = ReadLine();
    string[] stringArray = numbersString.Split(",");
    int[] intArray = Array.ConvertAll(stringArray, int.Parse);

    WriteLine($"The smallest number is {intArray.Min()}");
    WriteLine($"The largest number is {intArray.Max()}");
    WriteLine($"The average of all numbers is {intArray.Average()}");

    ReadKey();
}

static void RunExerciseThirtythree()
{
    string quickFox = "The quick fox Jumped Over the DOG";

    string brownFox = quickFox.Replace("quick", "brown").Replace("J", "j").Replace("DOG", "lazy dog").Replace("O", "o");

    WriteLine(brownFox);


    Write("Enter a word  ");
    string firstWord = ReadLine();

    Write("Enter a second word  ");
    string secondWord = ReadLine();

    string firstLower = firstWord.ToLower();
    string secondLower = secondWord.ToLower();

    if (firstLower == secondLower)
        WriteLine($"{firstWord} and {secondWord} are the same word");

    else
        WriteLine($"{firstWord} and {secondWord} are not the same word");


    Write("Type Donkey  ");
    string donkeyToMonkey = ReadLine();
    string monkey;
    bool donkeyCheck = false;

    while (donkeyCheck == false)
    {
        if (donkeyToMonkey == "Donkey")
        {
            monkey = donkeyToMonkey.Replace("D", "M");
            WriteLine(monkey);
            donkeyCheck = true;
        }

        else
        {
            Write("Word is not Donkey, type Donkey  ");
            donkeyToMonkey = ReadLine();
        }


    }


    string kolmardenText = "I am going to visit Kolmården zoo tomorrow. I am a big fan of the dolphin show. I may watch all dolphin shows during the day. I would like to take a gondola safari as well. I wish to visit Bamse and his team there.";
    string newKolmardenText = kolmardenText.Replace("I", "We").Replace(" am", " are");

    WriteLine(newKolmardenText);


    string popularSinger = "She is the popul\nar singer.";
    string fixedPopular = popularSinger.Replace("the", "the most").Replace("\n", "");

    WriteLine(fixedPopular);


    string friendString = "A friend is the asset of your life.";
    string trueFriendString = friendString.Replace("friend", "true friend").Replace("asset", "greatest asset").Replace(".", "");

    WriteLine(trueFriendString);


    string teacherIntro = "My name is Nalini Phopase.";
    string teacherName = teacherIntro.Substring(11, 14);

    WriteLine(teacherName);


    string arraysText = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
    string newArraysText = arraysText.Replace("[1,2,3,4,5]", "[1,4,5,6,7,8]");

    WriteLine(newArraysText);

    ReadKey();
}

static void RunExerciseThirtyfour()
{
    Write("What is your birth date in format yyyy/mm/dd?  ");
    var birthDate = DateTime.Parse(ReadLine());
    var age = DateTime.Now.Year - birthDate.Year;

    if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
        age = age - 1;

    WriteLine($"You are currently {age} years old");

    ReadKey();
}

static int CalculateAge(string birthDate)
{
    birthDate = birthDate.Replace("/", "");

    DateTime todayDate = DateTime.Today;

    string dateNow = todayDate.ToString("d");
    dateNow = dateNow.Replace("-", "");

    int age = (Convert.ToInt32(dateNow) - Convert.ToInt32(birthDate)) / 10000;

    return age;
}

static void RunExerciseThirtyfive()
{
    Write("What is your name?  ");
    string userName = ReadLine();
    WriteLine($"Hello {userName}, welcome!");

    Write("What is your birth date in format yyyy/mm/dd?  ");
    string birthDate = ReadLine();

    int age = CalculateAge(birthDate);
    char response;

    if (age >= 18)
    {
        Write("Do you want to order beer? Y/N  ");
        response = char.Parse(ReadLine());

        if (response == 'Y')
            WriteLine("One beer coming right up");

        else
        {
            Write("Do you want to order a coke? Y/N  ");
            response = char.Parse(ReadLine());

            if (response == 'Y')
                WriteLine("One coke coming right up");

            else
                WriteLine("No other options available");
        }
    }

    else
    {
        Write("Do you want to order a coke? Y/N  ");
        response = char.Parse(ReadLine());

        if (response == 'Y')
            WriteLine("One coke coming right up");

        else
            WriteLine("No other options available");
    }
    ReadKey();
}

static void RunExerciseThirtysix()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Write(i * j);

            if (i * j < 100)
                Write(" ");
            if (i * j < 10)
                Write(" ");
        }
        WriteLine();
    }

    ReadKey();
}

bool keepAlive = true;
while (keepAlive)
{
    try
    {
        Write("Enter assignment number (or -1 to exit): ");
        var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
        ForegroundColor = ConsoleColor.Green;
        switch (assignmentChoice)
        {
            case 1:
                RunExerciseOne();
                break;
            case 2:
                RunExerciseTwo();
                break;
            case 3:
                RunExerciseThree();
                break;
            case 4:
                RunExerciseFour();
                break;
            case 5:
                RunExerciseFive();
                break;
            case 6:
                RunExerciseSix();
                break;
            case 7:
                RunExerciseSeven();
                break;
            case 8:
                RunExerciseEight();
                break;
            case 9:
                RunExerciseNine();
                break;
            case 10:
                RunExerciseTen();
                break;
            case 11:
                RunExerciseEleven();
                break;
            case 12:
                RunExerciseTwelve();
                break;
            case 13:
                RunExerciseThirteen();
                break;
            case 14:
                RunExerciseFourteen();
                break;
            case 15:
                RunExerciseFifteen();
                break;
            case 16:
                RunExerciseSixteen();
                break;
            case 17:
                RunExerciseSeventeen();
                break;
            case 18:
                RunExerciseEighteen();
                break;
            case 19:
                RunExerciseNineteen();
                break;
            case 20:
                RunExerciseTwenty();
                break;
            case 21:
                RunExerciseTwentyone();
                break;
            case 22:
                RunExerciseTwentytwo();
                break;
            case 23:
                RunExerciseTwentythree();
                break;
            case 24:
                RunExerciseTwentyfour();
                break;
            case 25:
                RunExerciseTwentyfive();
                break;
            case 26:
                RunExerciseTwentysix();
                break;
            case 27:
                RunExerciseTwentyseven();
                break;
            case 28:
                RunExerciseTwentyeight();
                break;
            case 29:
                RunExerciseTwentynine();
                break;
            case 30:
                RunExerciseThirty();
                break;
            case 31:
                RunExerciseThirtyone();
                break;
            case 32:
                RunExerciseThirtytwo();
                break;
            case 33:
                RunExerciseThirtythree();
                break;
            case 34:
                RunExerciseThirtyfour();
                break;
            case 35:
                RunExerciseThirtyfive();
                break;
            case 36:
                RunExerciseThirtysix();
                break;

            case -1:
                keepAlive = false;
                break;
            default:
                ForegroundColor = ConsoleColor.Red;
                WriteLine("That is not a valid assignment number!");
                break;
        }
        ResetColor();
        WriteLine("Hit any key to continue..");
        ReadKey();
        Clear();
    }
    catch (Exception e)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(e.Message);
        ResetColor();
    }
}

static class MyMethods
{
    static public float AddNumbers(float a)
    {
        WriteLine(a);
        return a;
    }
    static public float AddNumbers(float a, float b)
    {
        WriteLine(a + b);
        return a + b;
    }
    static public float AddNumbers(float a, float b, float c)
    {
        WriteLine(a + b + c);
        return a + b + c;
    }
}