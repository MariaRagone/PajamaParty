////Pajama Party Planner

////Create a Pajama Party Planner application that allows users to manage their pajama party arrangements.
////The application should have the following features:

////Pajama Sets Catalog:
////Implement a catalog of different pajama sets that users can choose from.
////Each pajama set should have attributes such as style, size, and color.
////Guest List Management:

////Users should be able to create and manage a guest list for the pajama party.
////Each guest entry should include details like name, age, and pajama size.
////Party Agenda:

////Allow users to schedule activities for the pajama party, such as movie time, games, and snacks.
////Provide a view of the agenda with scheduled activities and timings.
////RSVP System:

////Implement an RSVP system where guests can confirm their attendance and specify any dietary restrictions or preferences.
////Pajama Party Dashboard:

////Create a dashboard that gives an overview of the party details, including the number of guests attending,
////scheduled activities, and pajama sets selected.
////Bonus:

////Implement a feature to automatically suggest pajama sets based on the guest's preferences.
////Allow users to share the party details via a unique link with their guests.
////Create a reminder system for scheduled activities.
////Feel free to choose any programming language or framework for this challenge. Consider the user experience,
////data structure efficiency, and code modularity in your solution.

////You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

////Merge nums1 and nums2 into a single array sorted in non-decreasing order.

////The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.



////Example 1:

////Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
////Output: [1,2,2,3,5,6]
////Explanation: The arrays we are merging are [1,2,3] and[2, 5, 6].
////The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
////Example 2:

////Input: nums1 = [1], m = 1, nums2 = [], n = 0
////Output: [1]
////Explanation: The arrays we are merging are [1] and[].
////The result of the merge is [1].
////Example 3:

////Input: nums1 = [0], m = 0, nums2 = [1], n = 1
////Output: [1]
////Explanation: The arrays we are merging are [] and[1].
////The result of the merge is [1].
////Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.


////Constraints:
////nums1.length == m + n
////nums2.length == n
////0 <= m, n <= 200
////1 <= m + n <= 200
////- 109 <= nums1[i], nums2[j] <= 109


//int[] nums1 = { 1, 2, 3, 0, 0, 0 };
//int[] nums2 = { 2, 5, 6 };
//int m = 3;
//int n = 3;
//Merge(nums1, m, nums2, n);
//CombineArray(nums1);

//static void Merge(int[] nums1, int m, int[] nums2, int n)
//{
//    int index = m + n - 1;  // Index to merge from the end of nums1
//    m--;  // Adjusting m to point to the last element in nums1

//    while (n > 0)
//    {
//        // Compare the last elements of nums1 and nums2, and add the larger one to the end of nums1
//        if (m >= 0 && nums1[m] > nums2[n - 1])
//        {
//            nums1[index] = nums1[m];
//            m--;
//        }
//        else
//        {
//            nums1[index] = nums2[n - 1];
//            n--;
//        }
//        index--;
//    }
//}

//static void CombineArray(int[] arr)
//{
//    Console.Write("Merged Array: ");
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write($"{arr[i]}, ");
//    }
//}

////ARRAYS

//// A simple definition for a DVD.
//public class DVD
//{
//    public string name;
//    public int releaseYear;
//    public string director;

//    // Constructor
//    public DVD(string name, int releaseYear, string director)
//    {
//        this.name = name;
//        this.releaseYear = releaseYear;
//        this.director = director;
//    }

//    // Display the movie details
//    public override string ToString()
//    {
//        return $"{name}, directed by {director}, released in {releaseYear}";
//    }
//}

//public partial class Program
//{
//    public static void Main()
//    {
//        // Create the DVD collection array of 15 slots
//        DVD[] dvdCollection = new DVD[15];

//        DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");
//        DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
//        DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
//        DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

//        // Put "The Incredibles" into the 4th place: index 3.
//        dvdCollection[3] = incrediblesDVD;

//        // Put "Finding Dory" into the 10th place: index 9.
//        dvdCollection[9] = findingDoryDVD;

//        // Put "The Lion King" into the 3rd place: index 2.
//        dvdCollection[2] = lionKingDVD;

//        // Next, we'll put it into the 8th place of the Array. Remember, because we
//        // started numbering from 0, the index we want is 7.
//        dvdCollection[7] = avengersDVD;

//        // Print the details of the DVD at index 7
//        Console.WriteLine(dvdCollection[7]);
//    }
//}



using Pajama_Party;
using System.ComponentModel;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using System.Runtime.CompilerServices;

string[] greeting = { "Hi", "Hello", "Ciao", "Hola" };
int[] grades = new int[5]; //there are 5 slots in this array
double[] GPAs = { 4.0, 3.0, 2.7, 3.6 };

Console.WriteLine(greeting);//prints out the object type System.String[]
Console.WriteLine(GPAs[2]); //prints 2.7
Console.WriteLine(greeting[0]); //prints Hi

foreach (string g in greeting)
{
    Console.WriteLine($"{g}, ");
}
Console.WriteLine();
for (int i = 0; i < greeting.Length; i++)
{
    Console.Write($"{greeting[i]}, ");
}

//Find and print the even numbers of an array
int[] numbers = { 1, 2, 4, 3, 5, 7, 9, 20 };

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}

//FIND THE AVERAGE AFTER DISCOUNT USING FOR LOOP
double discount = .25;
double discountedPrice = 0;
double[] prices = { 2.00, 3.00, 4.00, 5.00 };
double sum = 0; //holder variable 
for (int i = 0; i < prices.Length; i++)
{
    sum += prices[i];
    discountedPrice = sum * discount;
}
double averagePrice = discountedPrice / prices.Length;
Console.WriteLine(averagePrice); //prints 0.875

//FIND THE AVERAGE AFTER DISCOUNT USING FOREACH LOOP
double sum2 = 0;
double discountedPrice2 = 0;
foreach (int i in prices)
{
    sum2 += i;
    discountedPrice2 = (sum * discount);
}
double averagePrice2 = discountedPrice2 / prices.Length;
Console.WriteLine(averagePrice2); //prints 0.875
Console.WriteLine(prices[2]); //prints 4
prices[2] = 6; //changed 4.00 to 6
Console.WriteLine(prices[2]); //prints 6

//FIND THE SMALLEST VALUE IN THE ARRAY
double smallest = double.MaxValue;
foreach (double p in prices)
{
    if (p < smallest)
    {
        smallest = p;
    }
}
Console.WriteLine(smallest); //prints 2 
Console.WriteLine(prices.Min());

//FIND THE SMALLEST VALUE IN THE ARRAY
double largest = double.MinValue;

foreach (double p in prices)
{
    if (p > largest)
    {
        largest = p;
    }
}
Console.WriteLine(largest); //prints 6 because we changed the 4 to a 6
Console.WriteLine(prices.Max());

//STUDENT DATABASE---------------------------------------------------------------------
//string[] names = { "Maria", "Rayma", "Fred" };
//string[] hometowns = { "Detroit", "Tampa", "Atlanta" };
//string[] favoriteFoods = { "Pizza", "Burgers", "Ice Cream" };
//bool runProgram = true;
//Console.WriteLine("Welcome to the Student Database");
//while (runProgram)
//{
//    int menuChoice = DisplayMenu(names);
//    Console.WriteLine(menuChoice);

//    CategoryChoice(names, hometowns, favoriteFoods, menuChoice);
//    bool another = AnotherStudent();
//    if (another == false)
//    { 
//        break;
//    }
//}

////METHODS
//static int DisplayMenu(string[] names)
//{
//    Console.WriteLine("Choose a student to view:");
//    for (int i = 0; i < names.Length; i++)
//    {
//        var index = Array.IndexOf(names, names[i]);
//        index++;
//        Console.WriteLine($"{index}. {names[i]}");//prints 1. Maria ...
//    }
//    int menuChoice = int.Parse(Console.ReadLine());
//    return menuChoice;
//}

//static string CategoryChoice(string[] names, string[] hometowns, string[] favoriteFoods, int menuChoice)
//{
//    bool validChoice = true;
//    string categoryChoice = "";
//    while (validChoice)
//    {

//        Console.WriteLine("Which category would you like to see?");
//        Console.WriteLine("Hometown or Favorite Food?");
//        //LOGIC FOR CATEGORY CHOICE
//        categoryChoice = Console.ReadLine().ToLower().Trim();
//        if (categoryChoice == "hometown" || categoryChoice == "h" || categoryChoice == "home" || categoryChoice == "town")
//        {
//            //display the respective hometown
//            Console.WriteLine($"{names[menuChoice - 1]} is from {hometowns[menuChoice - 1]}.");
//            break;
//        }
//        else if (categoryChoice == "favorite food" || categoryChoice == "f" || categoryChoice == "food" || categoryChoice == "fave")
//        {
//            Console.WriteLine($"{names[menuChoice - 1]} loves {favoriteFoods[menuChoice - 1]}.");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("That was not a valid response. Please try again");
//            continue;
//        }
//    }
//    return categoryChoice;
//}

//static bool AnotherStudent()
//{
//    Console.WriteLine("Would you like to see another student? y/n");
//    string another = Console.ReadLine().ToLower().Trim();
//    if (another == "y" || another == "yes")
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//-------------------------------------------------------------------------------------------------------------------------


//REWRITE THE STUDENT DATABASE USING THE STUDENTS CLASS

//a list of students
//List<Students> studentList = new List<Students>()
//{
//    new Students ("Sam", "Waterford", "Burgers"),
//    new Students("Liz", "NY", "Hot Dogs"),
//    new Students("Frank", "Miami", "Vodka")
//};

////An array of students
//Students [] studentArray = new Students[12];
//studentArray[0] = new Students("Jack", "LA", "Sandwiches");
//Students Maria = new Students("Maria", "Detroit", "Pasta");
////put Maria into the 2nd place: index 1
//studentArray[1] = Maria;
//studentArray[2] = new Students("Pam", "Kansas City", "Peaches");

//bool viewStudents = true;
//while (viewStudents)
//{
//    Console.WriteLine("Choose a student");
//    //display the menu to choose a student
//    for (int i = 0; i < studentList.Count; i++)
//    {
//        //Console.WriteLine($"{studentList}");

//    }
//    for (int i = 0; i < studentArray.Length; i++)
//    {
//        var index = Array.IndexOf(studentArray, studentArray[i]);
//        index++;
//        Console.WriteLine($"{index}. {studentArray[i]}");//prints 1. Jack ...

//    }
//    break;
//}

//---------------------------------------------------------------------------------------------------------------------
//You are playing the following Nim Game with your friend:

//Initially, there is a heap of stones on the table.
//You and your friend will alternate taking turns, and you go first.
//On each turn, the person whose turn it is will remove 1 to 3 stones from the heap.
//The one who removes the last stone is the winner.
//Given n, the number of stones in the heap, return true if you can win the game assuming both you and your friend play optimally, otherwise return false.

//Example 1:

//Input: n = 4
//Output: false
//Explanation: These are the possible outcomes:
//1.You remove 1 stone. Your friend removes 3 stones, including the last stone. Your friend wins.
//2. You remove 2 stones. Your friend removes 2 stones, including the last stone. Your friend wins.
//3. You remove 3 stones. Your friend removes the last stone. Your friend wins.
//In all outcomes, your friend wins.
//Example 2:

//Input: n = 1
//Output: true
//Example 3:

//Input: n = 2
//Output: true



//Constraints:

//1 <= n <= 231 - 1

//Random random = new Random();
//int n = random.Next(1, 15);
//CanWinNim(n);
//static int CanWinNim(int n)
//{
//    while (n >= 1 && n <= Math.Pow(2, 32) - 1)
//    {
//        bool turn = true;
//        while (n != 0)
//        {
//            //logic for playing
//            Console.WriteLine($"Next person: There are {n} stones left. How many do you want to remove?");
//            int removed = int.Parse(Console.ReadLine());
//            if (removed < 1 || removed > 3)
//            {
//                Console.WriteLine("Please choose 1, 2, or 3 stones");
//                continue;
//            }
//            else
//            {
//                n -= removed;
//                Console.WriteLine($"There are now {n} stones. ");
//                break;
//            }
//        }
//        if (n == 0)
//        {
//            Console.WriteLine("You won!");
//        }


//        //logic for winning
//        //    if () //logic for if you take stones including the last one
//        //    {

//        //        return true;// you win
//        //    }
//        //    else if () //logic for your friend taking stones including the last one
//        //    {
//        //        return false; //you lose
//        //    }
//    }
//    return n;
//}

//METHODS

//---------------------------------------------------------------------------------------------------------------------
//Given an integer x, return true if x is a 
//palindrome
//, and false otherwise.

int number = 251;
bool result = IsPalindrome(number);

Console.WriteLine(result);
static bool IsPalindrome(int x)
{
    string original = x.ToString();
    string reversed = new string(original.Reverse().ToArray());

    return original == reversed;
}

string palindrome = "mom";
bool result2 = IsPalindrome2(palindrome);
Console.WriteLine(result2);
static bool IsPalindrome2(string x)
{
    for (int i = 0, j = x.Length - 1; i < j; i++, j--)
    {
        if (x[i] != x[j])
        {
            return false;
        }
    }
    return true;
}
//another way
Console.WriteLine("Daddy");
string palindrome3 = "daddy";
bool result3 = IsPalindrome3(palindrome3);
Console.WriteLine(result3);
static bool IsPalindrome3(string x)
{
    string original = x.ToString();
    string reversed = new string(original.Reverse().ToArray());
    return original == reversed;
}

//another way
string theWord = "racecar";
bool isPal = (IsPalindrome4(theWord));
Console.WriteLine($"Is the word: {theWord} a palendrome? {isPal}");
static bool IsPalindrome4(string x)
{
    for (int i = 0; i < x.Length / 2; i++)
    {
        if (x[x.Length - 1 - i] != x[i])
        {
            return false;
        }
    }
    return true;
}

//---------------------------------------------------------------------------------------------------------------------
// Check if the borrower is considered valid based on the given conditions
//        // Borrowers are considered valid if:
//        // - their name is not null or empty,
//        // - their Dti is below or equal to 25,
//        // - their owned properties are less than or equal to 3


string borrower = "Top";
int DTI = 25;
int ownedProperties = 3;

bool valid = IsValid(borrower, DTI, ownedProperties);
Console.WriteLine($"is this borrower valid? {valid}");
static bool IsValid(string borrower, int DTI, int ownedProperties)
{
    if (borrower == null || borrower == "" || DTI > 25 || ownedProperties > 3)
    {
        return false;

    }
    else
    {
        return true;
    }
}
//NOW USE CLASSES

//Console.WriteLine("What is your name?");
//string bName = Console.ReadLine();
//Console.WriteLine("Enter Dti:");
//double dti = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter # Properties:");
//int propertiesOwned = int.Parse(Console.ReadLine());

////create an instance of the Borrower
//Borrower borrower1 = new Borrower(bName, dti, propertiesOwned);
//Console.WriteLine(borrower1);

//Console.WriteLine(IsValid(borrower1));

//---------------------------------------------------------------------------------------------------------------------
//Shopping Cart
List<Items> itemsList = new List<Items>()
{
    new Items (1, "Toy", 20.00, 1, 200),
    new Items (1, "Stapler", 8.00, 1, 100),
    new Items (1, "Computer", 500.00, 1, 20),
};

//Create an instance of the cart
ShoppingCart cart1 = new ShoppingCart();

//Methods
static string AddItem()
{
    return "hello";
}
//---------------------------------------------------------------------------------------------------------------------
//TEST QUESTIONS
Console.WriteLine("Data Types:Declare a variable of type int named myNumber and assign it the value 42.");
int myNumber = 42;
Console.WriteLine("Arrays:Create an array of integers named nums with the values {1, 3, 5, 7, 9}.Print the third element of the array.");
int[] nums = { 1, 3, 5, 7, 9 };
Console.WriteLine(nums[2]);//prints 5, the 3rd element of the array 

Console.WriteLine("Loops:\r\nWrite a for loop to print even numbers from 2 to 10.");
for (int i = 2; i < 12; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Classes:\r\n\r\nDefine a class named Person with properties Name (string) and Age (int).\r\n" +
    "Create an instance of the Person class with the name \"Alice\" and age 25.");
//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    Person(string _name, int _age)
//    {
//        Name = _name;
//        Age = _age;
//    }
//    public static void Main()
//    {
//        Person Alice = new Person("Alice", 25);

//        Console.WriteLine(Alice);
//    }

//    //methods
//    public override string ToString()
//    {
//        return $"Name: {Name}, Age: {Age}";
//    }
//}

//Console.WriteLine("Methods:\r\n\r\nWrite a method named Add that takes two integers as parameters and returns their sum.");
//int x = 10;
//int y = 5;
//static int Add(int x, int y)
//{
//    int sum = x + y;
//    return sum;
//}
//Console.WriteLine(Add(x, y));

//Console.WriteLine("String Manipulation:\r\n\r\nCreate a string variable named greet with the value \"Hello, World!\".\r\nPrint the length of the string.");
//string greet = "Hello, World!";
//Console.WriteLine(greet.Length);//prints 13

//Console.WriteLine("Conditional Statements:\r\n\r\nWrite an if statement to check if a variable score is greater than or equal to 60. If true, print \"Passed.\"");
//int score = 80;
//if (score >= 60)
//{
//    Console.WriteLine("Passed.");
//}
//else
//{
//    Console.WriteLine("Try again!");
//}

//Console.WriteLine("Collections:\r\n\r\nCreate a List of strings named fruits with the values {\"Apple\", \"Banana\", " +
//    "\"Orange\"}.\r\nAdd \"Grapes\" to the list.\r\nPrint all the elements in the list.");
//List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
//fruits.Add("Grapes");
//Console.WriteLine(string.Join(", ", fruits));
////another way
//foreach (string f in fruits)
//{ Console.WriteLine(f); }


//Console.WriteLine("Exception Handling:\r\nWrite a try-catch block to handle a potential FormatException when parsing a user-input string to an integer.");
//bool runProgram = true;
//while (true)
//{
//    Console.WriteLine("Type a number.");
//    try
//    {
//        string userInput = Console.ReadLine();
//        double parsedNumber = double.Parse(userInput);
//        runProgram = false;
//        break;
//    }
//    catch (FormatException error)
//    {
//        Console.WriteLine($"Error: {error.Message}\r\nPlease enter a valid integer.");
//        continue;
//    }
//}
////it can be done this way too
//Console.WriteLine("type a number");
//try
//{
//    int input = int.Parse(Console.ReadLine());
//}
//catch (FormatException error)
//{
//    Console.WriteLine($"Error: {error.Message}");
//}

//Console.WriteLine("LINQ:\r\nGiven an array of integers named numbers, use LINQ to filter and print only the even numbers.");
//int[] nummies = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int[] evenNummies = nummies.Where(num => num % 2 == 0).ToArray();
////or var evenNumbers = numbers.Where(num => num % 2 == 0);
//foreach (var n in evenNummies)
//{ Console.WriteLine(n); }
////or using non-LINQ
//for (int i = 0; i < nummies.Length; i++)
//{
//    if (nummies[i] % 2 == 0)
//    {
//        Console.WriteLine(nummies[i]);
//    }
//}
////or
//foreach (int i in nummies)
//{
//    if ((i % 2) == 0)
//    { Console.WriteLine(i); }
//}

//Console.WriteLine("Working with Arrays:\r\nDeclare an array of integers named numbers with values {1, 3, 5, 7, 9}.\r\n" +
//    "Write a method named PrintThirdElement to print the third element of the array.");
//int[] array = { 1, 3, 5, 7, 9 };
//Console.WriteLine(PrintThirdElement(array));
//static int PrintThirdElement(int[] array)
//{
//    int thirdElement = array[2];
//    return thirdElement;//prints 5, the third element
//}
////or
//Print3rdElement(array);
//static void Print3rdElement(int[] array)
//{
//    Console.WriteLine($"The third element is {array[2]}");
//}


//Console.WriteLine("Exception Handling:\r\nWrite a method named ParseInt that takes a string as input and returns its integer representation. " +
//    "Handle exceptions gracefully.");
//ParseInt();
//static void ParseInt()
//{
//    Console.WriteLine("Type an integer:");

//    // Read the input from the user
//    string userInput = Console.ReadLine();

//    // Use int.TryParse to attempt parsing without throwing exceptions
//    if (int.TryParse(userInput, out int result))
//    {
//        // Print the parsed integer
//        Console.WriteLine("Parsed integer: " + result);
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter a valid integer.");
//    }
//}
////or 
//ParseInt2();
//static void ParseInt2()
//{
//    Console.WriteLine("Try the try/catch way: Type an integer:");
//    try
//    {
//        int.Parse(Console.ReadLine());
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine($"Error: {ex.Message}. Please enter a valid integer.");
//    }
//    catch (OverflowException ex)
//    {
//        Console.WriteLine($"Error: {ex.Message}. \"Input is too large or too small for an integer.");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error: {ex.Message}. \"An unexpected error occurred.");
//    }

//}

//Console.WriteLine("\r\n\r\n\r\nLINQ and Collections:\r\nCreate a list of strings named techSkills with values " +
//    "{\"C#\", \"JavaScript\", \"React\", \"SQL\"}.\r\nUse LINQ to print skills that contain the word \"development.\"");

//List<string> techSkills = new List<string> { "C# Developer", "React", "Java", "SQL", "Database Developer" };
//var devSkills = techSkills.Where(i => i.Contains("Developer"));
//foreach (var n in devSkills)
//{ Console.WriteLine(n); }
////or
//foreach (var n in techSkills)
//{
//    if (n.Contains("Developer"))
//    {
//        Console.WriteLine(n);

//    }
//}
////or
//for (int i = 0; i < techSkills.Count; i++)
//{
//    if (techSkills[i].Contains("Developer"))
//    {
//        Console.WriteLine(techSkills[i]);
//    }
//}

//Console.WriteLine("FizzBuzz:\r\nWrite a function that prints the numbers from 1 to 100. But for multiples of three, " +
//    "print \"Fizz\" instead of the number, and for the multiples of five, " +
//    "print \"Buzz.\" For numbers that are multiples of both three and five, print \"FizzBuzz.\"");
//for (int i = 1; i <= 100; i++)
//{
//    if (i%3==0 && i%5==0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    { Console.WriteLine(i); }
//}
//Console.WriteLine("Reverse a String:\r\nWrite a function that takes a string as input and returns the string reversed.");

//string original = "Hello There";
//ReverseString(original);
//static void ReverseString(string x)
//{

//    //OR
//    char[] charArray = x.ToCharArray();
//    for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
//    {
//        // Swap characters at positions i and j
//        char temp = charArray[i];
//        charArray[i] = charArray[j];
//        charArray[j] = temp;
//    }
//    string reversed2 = new string(charArray);
//    Console.WriteLine(reversed2);
//}
//Console.WriteLine("Factorial:\r\nWrite a function to calculate the factorial of a given non-negative integer.");
//Console.WriteLine(CalculateFactorial(5)); //prints 120
//static int CalculateFactorial(int n)
//{
//    int result = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        result *= i;
//    }
//    return result;
//}

//Console.WriteLine("Fibonacci Sequence:\r\nImplement a function to generate the nth Fibonacci number. " +
//    "The Fibonacci sequence is defined as follows: F(0) = 0, F(1) = 1, and F(n) = F(n-1) + F(n-2) for n > 1.");
////F(n)=F(n−1)+F(n−2)
////recursion
//int n = 6;
//Console.WriteLine(CalculateFibonacci(n));
//static int CalculateFibonacci(int n)
//{
//    if (n <= 1)
//    {
//        return n;
//    }
//    int[] fibonacci = new int[n + 1]; //the +1 is used in fibonacci sequence calculations to account for the initial values of 0 and 1
//    fibonacci[0] = 0;
//    fibonacci[1] = 1;
//    for (int i = 2; i <= n; i++)
//    {
//        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
//    }
//    return fibonacci[n];
//}

//Console.WriteLine("Write a function to determine if a given string is a palindrome. " +
//    "Ignore spaces, punctuation, and capitalization.");
//string a = "mom.";
//Console.WriteLine($"{a} is a palindrom: {CheckPalindrome(a)}");
//static bool CheckPalindrome(string a)
//{
//    string original = a.ToString().ToLower();
//    string clean = new string(original.Where(Char.IsLetterOrDigit).ToArray());
//    string reversed = new string(clean.Reverse().ToArray());
//    //string reverse = new string(original.Reverse().ToArray());
//    return clean == reversed;
//}

//string f = "Dad. ?%";
//Console.WriteLine($"{f} is a palindrom: {Checked(f)}");
//static bool Checked(string x)
//{
//    string cleaned = new string(x.Where(Char.IsLetterOrDigit).ToArray()).ToLower();

//    for (int i = 0; i < cleaned.Length; i++)
//    {
//        if (cleaned[cleaned.Length - 1 - i] != cleaned[i])
//        {
//            return false;
//        }
//    }
//    return true;
//}


//double u = 121.121;
//Console.WriteLine(C(u));
//static bool C(double x)
//{
//    if (x < 0) //check to see if the number is negative.
//    {
//        return false;
//    }
//    else if (x > 0)
//    {
//        string s = x.ToString();
//        string cleaned = new string(s.Where(Char.IsLetterOrDigit).ToArray());
//        string reversed = new string(cleaned.Reverse().ToArray());
//        return cleaned == reversed;
//        //for (int i = 0; i < s.Length / 2; i++)
//        //{
//        //    if (s[s.Length - 1 - i] == s[i])
//        //    { return true; }
//        //}
//    }
//    return false;
//}

//string h = "Racecars";

//Console.WriteLine(CheckForP(h));
//static bool CheckForP(string x)
//{
//    //string original = x.ToString();
//    //string cleaned = new string(original.Where(Char.IsLetterOrDigit).ToArray());
//    //string reversed = new string(cleaned.Reverse().ToArray());
//    //Console.WriteLine(reversed);
//    //return cleaned == reversed;


//    for (int i = 0; i < x.Length / 2; i++)
//    {
//        if (x[x.Length - 1 - i] == x[i])
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine("Given an array of integers and a target sum, " +
//    "find and return the indices of two numbers that add up to the target. " +
//    "Assume there is exactly one solution.");

//int targetSum = 5;
//int[] numbers1 = { 1, 2, 3, 7, 8, 1, 6 };
//int[] result5 = TwoSum(numbers1, targetSum);
//Console.WriteLine($"Indices: {result5[0]}, {result5[1]}");
//static int[] TwoSum(int[] array, int target)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        int indices = target - array[i];
//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if (array[j] == indices)
//            {
//                return new int[] { i, j };
//            }
//        }
//    }
//    throw new InvalidAsynchronousStateException("none found");
//}


//Console.WriteLine("Implement a binary search algorithm to find the index of a given element in a sorted array. " +
//    "If the element is not present, return -1.");

//int targetElement = 9;
//int[] elements = { 1, 7, 9, 0, 5 }; //2 is in the 2nd index; should return "2"
//int result6 = LinearSearch(elements, targetElement);
//Console.WriteLine(result6);
//static int LinearSearch(int[] e, int t)
//{
//    for (int i = 0; i < e.Length; i++)
//    {
//        if (e[i] == t)
//            return i;
//    }
//    return -1;
//}
//Console.WriteLine("Write a function that takes two sorted arrays as input and merges them into a single sorted array.");
//int[] a1 = { 1, 9, 7, 0, 15 };
//int[] a2 = { 11, 3, 17, 1, 10 };
//int[] mergedArray = Merge(a1, a2);
//foreach (int i in mergedArray)
//{
//    Console.WriteLine(i);
//}
//static int[] Merge(int[] a1, int[] a2)
//{
//    int totalLength = a1.Length + a2.Length;
//    int[] newArray = new int[totalLength];
//    for (int i = 0; i < a1.Length; i++)
//    {
//        newArray[i] = a1[i];
//    }
//    for (int i = 0; i < a2.Length; i++)
//    {
//        newArray[a1.Length + i] = a2[i];
//    }
//    Array.Sort(newArray);
//    return newArray;
//}
//Console.WriteLine("Write a function to find and return all unique elements in an array. The order of elements in the result does not matter.");

//static void Main()
//{
//    int[] array = { 1, 2, 3, 4, 2, 5, 6, 7, 1, 8, 9, 9, 10 };
//    int[] uniqueElements = FindUniqueElements(array);
//    Console.WriteLine("Unique Elements:");
//    foreach (int element in uniqueElements)
//    {
//        Console.WriteLine(element);
//    }
//}
//static int[] FindUniqueElements(int[] array)
//{
//    int uniqueCount = 0;
//    // Count the number of unique elements
//    for (int i = 0; i < array.Length; i++)
//    {
//        bool isUnique = true;
//        // Check if the current element is already found before
//        for (int j = 0; j < i; j++)
//        {
//            if (array[i] == array[j])
//            {
//                isUnique = false;
//                break;
//            }
//        }
//        if (isUnique)
//        {
//            uniqueCount++;
//        }
//    }
//    // Create an array to store unique elements
//    int[] uniqueElements = new int[uniqueCount];
//    int currentIndex = 0;
//    // Fill the array with unique elements
//    for (int i = 0; i < array.Length; i++)
//    {
//        bool isUnique = true;
//        for (int j = 0; j < i; j++)
//        {
//            if (array[i] == array[j])
//            {
//                isUnique = false;
//                break;
//            }
//        }
//        if (isUnique)
//        {
//            uniqueElements[currentIndex] = array[i];
//            currentIndex++;
//        }
//    }

//    return uniqueElements;
//}
//Console.WriteLine("Check an array for even numbers using a loop.");

//int[] allNumbers = { 1, 3, 46, 23, 23, 12, 35, 6, 7, 8 };
//result = CheckEvent(allNumbers);
//Console.WriteLine(CheckEvent(allNumbers));
//static bool CheckEvent(int[] allNumbers)
//{

//    foreach (int i in allNumbers)
//    {
//        if (i % 2 == 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}
//if (result = true)
//{
//    Console.WriteLine("The array had even numbers");
//}
//else
//{
//    Console.WriteLine("They array had no even numbers");
//}

//Console.WriteLine("put the even numbers into a new array");

//EvenNumbers2(allNumbers);
//static int[] EvenNumbers2(int[] allNumbers)
//{
//    int countEven = 0;
//    // Count the number of even numbers
//    foreach (int i in allNumbers)
//    {
//        if (i % 2 == 0)
//        {
//            countEven++;
//        }
//    }
//    // Check if there are any even numbers
//    if (countEven > 0)
//    {
//        int[] evenArray = new int[countEven];
//        int index = 0;
//        // Populate the even numbers
//        foreach (int i in allNumbers)
//        {
//            if (i % 2 == 0)
//            {
//                evenArray[index] = i;
//                index++;
//            }
//        }
//        return evenArray;
//    }
//    throw new Exception("There were no even numbers");
//}

//EvenNumbers1(allNumbers);

//static int[] EvenNumbers1(int[] allNumbers)
//{
//    List<int> evenList = new List<int>();
//    foreach (int i in allNumbers)
//    {
//        if (i % 2 == 0)
//        {
//            evenList.Add(i);
//        }
//    }
//    if (evenList.Count > 0)
//    {
//        return evenList.ToArray();
//    }
//    throw new Exception("There were no even numbers");
//}

//Console.WriteLine(" Create a List of strings named fruits with the values {\"Apple\", \"Banana\", \"Orange\"}.\r\nAdd \"Grapes\" to the list.\r\n" +
//    "Print all the elements in the list.");
//List<string> fruity = new List<string> { "apple", "orange", "banana" };
//fruity.Add("Grapes");

//foreach (string s in fruity)
//{
//    Console.WriteLine(s);

//}

//Person Mark = new Person("Mark", 12);
//Person Jamie = new Person("Jamie", 12);
//Person Alice = new Person("Alice", 15);

//List<Person> personList = new List<Person> { Mark, Alice };
//foreach (Person p in personList)
//    if (p.Age > 12)
//    { Console.WriteLine(p); }


//Clothing Pjs = new Clothing("Pjs", 10, "Cozy", 30);
//Clothing Shirt = new Clothing("T-shirt", 10, "Cotton", 25);
//Clothing Jeans = new Clothing("Jeans", 10, "blue jeans", 45);

//List<Clothing> clothingList = new List<Clothing> { Pjs, Shirt, Jeans };
//foreach (Clothing p in clothingList)
//{ Console.WriteLine(p); }

//bool Maria = IsValid("Maria", 3, 12);
//Console.WriteLine(Maria);


//People Alice2 = new People("Alice", 16, false);

//Console.WriteLine(Alice2);
//Console.WriteLine(Alice2.IsOldEnough());
//People Maria2 = new People("Maria", 28, true);
//Console.WriteLine(Maria2.IsOldEnough());
//People Russ = new People("Russ", 47, true);
//Console.WriteLine(Russ.IsOldEnough());

//List<People> peopleList = new List<People> { Maria2, Russ, Alice2 };

//foreach (People p in peopleList)
//    Console.WriteLine(p.IsOldEnough());


//Console.WriteLine("Write a try-catch block to handle a potential FormatException when parsing a user-input string to an integer.");
//Console.WriteLine("Enter a number.");
//try
//{
//    int.Parse(Console.ReadLine());
//}
//catch (FormatException x)
//{
//    Console.WriteLine($"Error: {x.Message} \n Please enter a valid integer.");
//}



//Console.WriteLine("Given an array of integers named numbers, use LINQ to filter and print only the even numbers.");
//int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int[] evenInts = intArray.Where(x => x % 2 == 0).ToArray();
//foreach (int even in evenInts)
//{
//    Console.WriteLine(even);
//}

////nonLINQ

//for (int i = 0; i < intArray.Length; i++)
//{
//    if (intArray[i] % 2 == 0)
//    { Console.WriteLine(intArray[i]); }
//}

//Console.WriteLine("Declare an array of integers named numbers with values {1, 3, 5, 7, 9}.\r\n" +
//    "Write a method named PrintThirdElement to print the third element of the array.");

//int[] arrayOfInts = { 1, 3, 5, 7, 9 };
//Console.WriteLine(PrintThirdElement(arrayOfInts));//prints 5
//static int PrintThirdElement(int[] x)
//{
//    int third = x[2];
//    return third; 
//}

//Console.WriteLine("Write a method named ParseInt that takes a string as input and returns its integer representation. Handle exceptions gracefully.");

//ParseInt();
//static void ParseInt()
//{
//    Console.WriteLine("Enter a number");
//    try
//    { int.Parse(Console.ReadLine());
//        Console.WriteLine("Thank you for the number.");
//    }
//    catch (FormatException x) 
//    {
//        Console.WriteLine($"{x.Message} \n Please enter an integer");
//    }
//    catch (OverflowException x)
//    {
//        Console.WriteLine( x.ToString());
//    }
//    catch (Exception x)
//    {
//        Console.WriteLine(x.Message);
//    }
//}

//Console.WriteLine(" Create a list of strings named techSkills with values {\"C#\", \"JavaScript\", " +
//    "\"React\", \"SQL\"}.\r\nUse LINQ to print skills that contain the word \"developer.\"");

//List<string> jobNamesList = new List<string> { "Software Engineer" };

//jobNamesList.Add("Software Developer");
//jobNamesList.Add("Software Coder");
//jobNamesList.Add("Junior Developer");
//jobNamesList.Add("Data Analystr");
//jobNamesList.Add("Data Developer");
//bool runJobSearch = true;
//while (runJobSearch)
//{
//    //list out all of the jobs
//    Console.WriteLine($"\n \n There are {jobNamesList.Count} jobs");

//    Console.WriteLine($"Here is a list of all jobs:");
//    foreach (string jobName in jobNamesList)
//    {
//        Console.WriteLine(jobName);
//    }

//    string searchAgain = "y";

//    while (searchAgain == "y")//search for a job
//    {
//        Console.WriteLine("Enter a job title to search.");
//        string searchTerm = Console.ReadLine();

//        List<string> developerJobs = jobNamesList.Where(x => x.ToLower().Contains(searchTerm)).ToList();

//        Console.WriteLine($"These are the {searchTerm} jobs");

//        foreach (string job in developerJobs)
//        {
//            Console.WriteLine(job);
//        }
//        Console.WriteLine("Search again? y/n");
//        string searchAgainAnswer = Console.ReadLine();
//        if (searchAgainAnswer == "y")
//        {
//            continue;
//        }
//        else
//            Console.WriteLine("Bye!");
//        runJobSearch = false;
//        break;

//    }
//}

//Console.WriteLine("Write a function that prints the numbers from 1 to 100. But for multiples of three, print \"Fizz\" " +
//    "instead of the number, and for the multiples of five, print \"Buzz.\" For numbers that are multiples of both three and five, print \"FizzBuzz.\"");
//FizzBuzz();
//static void FizzBuzz()
//{
//    for (int i = 0; i <= 100; i++)
//    {
//        if (i % 3 == 0 && i % 5 == 0)
//        {
//            Console.WriteLine("FizzBuzz");
//        }
//        else if (i % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (i % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        else
//        { Console.WriteLine(i); }


//    }
//}

//Console.WriteLine(" Write a function that takes a string as input and returns the string reversed.");

//Console.WriteLine(ReverseString2("   Hello  ,   "));
//string reverseThis = "Hello, how are you today?";
//Console.WriteLine(ReverseString2(reverseThis));
//static string ReverseString2(string x)
//{

//    string original = x.ToString().Trim().ToLower();//remove white spaces and make all letters lower case
//    string cleaned = new string(original.Where(Char.IsLetterOrDigit).ToArray());
//    string reversed = new string(cleaned.Reverse().ToArray());
//    return reversed;
//}

//Console.WriteLine("Write a function to calculate the factorial of a given non-negative integer.");

//Console.WriteLine(CalculateFactorial1(5));//prints 120
//static int CalculateFactorial1(int x)

//{
//    int result = 1;
//    for (int i = 1; i <= x; i++)
//    {

//        result *= i;
//    }
//    return result;
//}

//Console.WriteLine("Implement a function to generate the nth Fibonacci number. The Fibonacci sequence is defined as follows: " +
//    "F(0) = 0, F(1) = 1, and F(n) = F(n-1) + F(n-2) for n > 1.");

//Console.WriteLine(CalcFibonacci(6)); //should print "8"
//static int CalcFibonacci(int n)
//{
//    if (n <= 1)
//        return n;

//    int[] fib = new int[n + 1];
//    fib[0] = 0;
//    fib[1] = 1;

//    for (int i = 2; i <= n; i++)
//    {
//        fib[i] = fib[i - 1] + fib[i - 2];
//    }
//    return fib[n];
//}
//Console.WriteLine("Write a function to determine if a given string is a palindrome. Ignore spaces, punctuation, and capitalization.");
//string pal = "This is a palindrome";
//string pal2 = "Mom.";
//Console.WriteLine(CheckPal(pal));//prints "false"
//Console.WriteLine(CheckPal(pal2));//prints "true"
//static bool CheckPal(string p)
//{
//    string original = p.ToString().ToLower().Trim();
//    string cleaned = new string(original.Where(Char.IsLetterOrDigit).ToArray());
//    //string reversed = new string (cleaned.Reverse().ToArray());
//    //return cleaned == reversed;

//    for (int i = 0; i < cleaned.Length / 2; i++)
//    {
//        if (cleaned[cleaned.Length - 1 - i] != cleaned[i])
//        {
//            return false;
//        }
//    }
//    return true;
//}


//Console.WriteLine("Given an array of integers and a target sum, find and return the indices of two numbers that add up to the target. " +
//    "Assume there is exactly one solution.");

//int target = 5;
//int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] twoNumbers = FindTwoSum(ints, target); //new array that will hold the two indices
//Console.WriteLine($"The two numbers are {twoNumbers[0]} and {twoNumbers[1]}"); //prints 1, 2 for the indices
//static int[] FindTwoSum(int[] x, int target)
//{
//    int[] twoNumbers = new int[1]; //new array that will hold the two indices

//    for (int i = 0; i < x.Length; i++)
//    {
//        int indices = target - x[i];
//        for (int j = 0; j < x.Length; j++)
//        {
//            if (x[j] == indices)
//            { return new int[] { i, j }; }
//        }
//    }
//    throw new InvalidAsynchronousStateException("none found");
//}
//Console.WriteLine("Write a function that takes two sorted arrays as input and merges them into a single sorted array.");
//int[] array1 = { 1, 18, 3, 11, 5 };
//int[] array2 = { 6, 4, 9, 8, 12 };
//Array.Sort(array1);
//Array.Sort(array2);
//MergeTheArray(array1, array2);
//static int[] MergeTheArray(int[] array1, int[] array2)
//{
//    int[] addedArray = new int[array1.Length + array2.Length];//create new array to store the old arrays

//    for (int i = 0; i < array1.Length; i++)
//    {
//        addedArray[i] = array1[i];
//    }
//    for (int i = array1.Length; i < addedArray.Length; i++)
//    {
//        addedArray[i] = array2[i - array1.Length];
//    }
//    Array.Sort(addedArray);
//    Console.WriteLine("here is the merged array.");
//    foreach (int i in addedArray)
//    {
//        Console.WriteLine(i);
//    }
//    return addedArray;
//}
//Console.WriteLine("Write a function to find and return all unique elements in an array. The order of elements in the result does not matter.");

//int[] nonUnique = new int[] { 1, 1, 3, 4, 4, 5, 2 }; //unique items are 3, 5, and 2
//Console.WriteLine(FindUnique(nonUnique));
//static int[] FindUnique(int[] nonUnique)
//{
//    int count = 0;
//    //first we need to count how many unique items there are
//    //then we need to make a new array and initiate it with the # of the unique items
//    //then we need to fill the new array with the unique items

//    for (int i = 0; i < nonUnique.Length; i++) //step 1
//    {
//        bool isUnique = true;
//        for (int j = 0; j < i; j++)
//        {
//            if (nonUnique[j] == nonUnique[i])
//            {
//                isUnique = false;
//                break;
//            }
//            if (isUnique)
//            { count++; }
//        }
//    }
//    int[] unique = new int[count]; //step 2
//    int currentIndex = 0;
//    // Fill the array with unique elements
//    for (int i = 0; i < nonUnique.Length; i++)
//    {
//        bool isUnique = true;
//        for (int j = 0; j < i; j++)
//        {

//            if (nonUnique[i] == nonUnique[j])
//            {
//                isUnique = false;
//                break;
//            }
//        }
//        if (isUnique)
//        {
//            unique[currentIndex] = nonUnique[i];
//            currentIndex++;
//        }
//    }
//    return unique;
//}
////---------------------------------------------------------------------------------------------------------------------

//Console.WriteLine("Check an array for even numbers using a loop.");
//int[] allNums = new int[] { 1, 3, 5, 9, 5, 6, 8, 2, 4 };//prints 6, 8, 2, 4
//int count = 0;
//for (int i = 0; i < allNums.Length; i++)
//{
//    if (allNums[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//if (count > 0)
//{
//    int[] evenNumbers = new int[count];
//        int currentIndex = 0;

//    for (int i = 0; i < allNums.Length; i++)
//    {
//        if (allNums[i] % 2 == 0)
//        {
//            evenNumbers[currentIndex] = allNums[i];
//            currentIndex  ++;
//        }
//    }
//    foreach (int i in evenNumbers)
//    {
//        Console.WriteLine(i);
//    }
//}

//List<int> allNumsList = new List<int> { 1, 2, 4, 5, 6, 7, 8 };
//List<int> evenList = new List<int>();
//foreach (int i in allNumsList)
//{
//    if (i % 2 == 0)
//    {
//        evenList.Add(i);
//        Console.WriteLine(i);
//    }
//}

//Console.WriteLine("Create a List of strings named fruits with the values " +
//    "{\"Apple\", \"Banana\", \"Orange\"}.\r\nAdd \"Grapes\" to the list.\r\nPrint all the elements in the list.");
//List<string> fruitList = new List<string> { "Apple", "Banana", "Orange" };
//fruitList.Add("Grapes");
//foreach  (string s in fruitList)
//{
//    Console.WriteLine(s);
//}
//Console.WriteLine(" Create a string variable named greeting with the value " +
//    "\"Hello, World!\".\r\nPrint the length of the string.");
//string greetingHello = "Hello, World!";
//Console.WriteLine(greetingHello.Length);


//Person Matthew = new Person("Matthew",46);
//Person Paul = new Person("Paul", 65);
//Person Luke = new Person("Luke", 23);
//Person John = new Person("John", 34);

//Person[] peopleArray = new Person[] { Matthew, Paul, Luke, John };
//List<Person> personsList = new List<Person> { Matthew, Paul, Luke, John};
//foreach (Person p in personsList)
//{
//    Console.WriteLine(p);
//}

//Console.WriteLine("Type an integer");

//try
//{
//    int.Parse(Console.ReadLine());
//}
//catch (FormatException error)
//{ Console.WriteLine(error.Message); }

//Console.WriteLine("Given an array of integers named numbers, use LINQ to filter and print only the even numbers.");
//int[] allNums1 = new int[] { 1, 3, 5, 9, 5, 6, 8, 2, 4 };//prints 6, 8, 2, 4
//int [] array6 = allNums1.Where(x => x %2 ==0).ToArray();
//Array.Sort(array6);
//foreach  (int i in array6)
//{ Console.WriteLine(i); }

//Console.WriteLine("Declare an array of integers named numbers with values {1, 3, 5, 7, 9}.\r\nWrite a " +
//    "method named PrintThirdElement to print the third element of the array.");
//int[] integers = new int[] { 1, 3, 5, 7, 9 };
//Console.WriteLine(Print3rdNumber(integers));
//static int Print3rdNumber(int[] array)
//{
//    return array[2];
//}

//Console.WriteLine("Create a list of strings named techSkills with values " +
//    "{\"C#\", \"JavaScript\", \"React\", \"SQL\"}.\r\nUse LINQ to print skills that contain the word \"development.\"");

//List<string> techJobs = new List<string> { "Java Dev", "C# Dev", "Web Admin" };

//List<string> devJobs = techJobs.Where(x => x.ToLower().Contains("dev")).ToList();
//foreach (string job in devJobs)
//{ Console.WriteLine(job); }

//Console.WriteLine("Write a function that prints the numbers from 1 to 100. But for multiples of three, print \"Fizz\" instead of the number, and for the multiples of five, " +
//    "print \"Buzz.\" For numbers that are multiples of both three and five, print \"FizzBuzz.\"");
//for (int i = 0; i <= 100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    { Console.WriteLine("FizzBuzz"); }
//    else if (i % 3 == 0)
//    { Console.WriteLine("Fizz"); }
//    else if (i % 5 == 0)
//    { Console.WriteLine("Buzz"); }
//    else
//    { Console.WriteLine(i); }
//}
//Console.WriteLine("Write a function that takes a string as input and returns the string reversed.");
//bool isP = false;
//Console.WriteLine("give me a word");
//string inputFromUser = Console.ReadLine().ToString().Trim().ToLower();
//Console.WriteLine(checkp(inputFromUser));
//static bool checkp(string inputFromUser)
//{
//    string cleaned = new string(inputFromUser.Where(Char.IsLetterOrDigit).ToArray());
//string reversed = new string(cleaned.Reverse().ToArray());
//Console.WriteLine($"Here is your word reversed {reversed}");
//    return reversed == cleaned; 
//}
Console.WriteLine(CalcF(5));
static int CalcF(int x)
{
    int result = 1;
    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine(isPals("mom"));
static bool isPals(string x)
{
    string original = x.ToString().ToLower().Trim();
    string cleaned = new string(original.Where(Char.IsLetterOrDigit).ToArray());
    string reversed = new string(cleaned.Reverse().ToArray());
    return reversed == cleaned;
}
Console.WriteLine(CalcFib(0));
static int CalcFib(int x)
{
    if (x <= 1)
    {
        return x;
    }
    int[] fib = new int[x + 1];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i <= x; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib[x];
}

string word = "racecars";
Check(word);
static void Check(string x)
{
    string original = x.ToString().ToLower().Trim();
    string cleaned = new string(x.Where(Char.IsLetterOrDigit).ToArray());
    string reversed = new string(cleaned.Reverse().ToArray());
    if (cleaned == reversed)
    {
        Console.WriteLine($"{x} is a palindrome");
    }
    else
    {
        Console.WriteLine($"{x} is not palindrome");
    }
}
Console.WriteLine("Implement a binary search algorithm to find the index of a given element in a sorted array. If the element is not present, return -1.");

int element = 9;
int[] elementList = new int[] { 1, 2, 3, 4, 5, 1, 6, 9, 10 };//prints "7"
Console.WriteLine(FindIndex(element, elementList));
static int FindIndex(int element, int[] elementList)
{
    int left = 0, right = elementList.Length - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (elementList[mid] == element)
            return mid; // Element found, return its index
        else if (elementList[mid] < element)
            left = mid + 1; // Search in the right half
        else
            right = mid - 1; // Search in the left half
    }
    return -1; // Element not found
}

string str = "arrb6???4xxbl5???eee5";
Console.WriteLine(QuestionsMarks(str));
static bool QuestionsMarks(string str)
{
    char[] characters = str.ToCharArray();
    int count = 0;
    int currentSum = 0;
    for (int i = 0; i < characters.Length; i++)
    {
        if (Char.IsDigit(characters[i]))
        {
            int num1 = Int32.Parse(characters[i].ToString());
            for (int j = i + 1; j < characters.Length; j++)
            {
                if (Char.IsDigit(characters[j]))
                {
                    int num2 = Int32.Parse(characters[j].ToString());
                    currentSum = num1 + num2;

                    if (currentSum == 10)
                    {
                        count += 3;
                        break;
                    }
                }
                else if (characters[j] == '?')
                {
                    count++;
                }
            }
        }
    }
    return count >= 3;
}
//two sum
//find two indices of numbers that add up to the target number
int target = 5;
int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7 }; //should return an array with 0, and 3 in it. 
int[] twoNumbers = FindTwoSum(numbers1, target);
Console.WriteLine($"The two indices are {twoNumbers[0]} and {twoNumbers[1]}");
static int[] FindTwoSum(int[] x, int t)
{
    int[] twoNumbers = new int[1];
    for (int i = 0; i < x.Length; i++)
    {
        int index = t - x[i]; // index = 5 -  1(index of i) === 4
        for (int j = 0; j < x.Length; j++)
        {
            if (x[j] == index)
            {
                return new int[] { i, j };
            }
        }
    }
    return new int[] { 0, 0 };
}

//find two numbers that add up to the target number
int targetNumber = 5;
int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] answer = TwoSum(targetNumber, array);
Console.WriteLine($"The two Numbers are {answer[0]}, {answer[1]}");
static int[] TwoSum(int target, int[] array)
{
    //make an array to store the numbers
    int[] twoNumbers = new int[2];
    for (int i = 0; i < array.Length; i++)//find first number
    {
        int firstNumber = target - array[i];
        for (int j = 0; j < array.Length; j++)//find second number
        {
            if (target - firstNumber == array[j])
            {
                int secondNumber = array[j];
                twoNumbers[0] = firstNumber;
                twoNumbers[1] = secondNumber;
            }
        }
        return twoNumbers; //should return 1, and 4
    }
    return new int[] { 0, 0 };
}


Console.WriteLine("Write a function to find and return all unique elements in an array. The order of elements in the result does not matter.");
    int[] array3 = { 1, 2, 2, 4, 2, 2, 3};
    int[] uniqueElements = FindUniqueElements(array3);
    Console.WriteLine("Unique Elements:");

    foreach (int e in uniqueElements)
    {
        Console.WriteLine(e);
    }
static int[] FindUniqueElements(int[] array)
{
    int uniqueCount = 0;
    // Count the number of unique elements
    for (int i = 0; i < array.Length; i++)
    {        bool isUnique = true;
        // Check if the current element is already found before
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
            {
                isUnique = false;
                break;
            }
        }
        if (isUnique)
        {
            uniqueCount++;
        }
    }
    // Create an array to store unique elements
    int[] uniqueElements = new int[uniqueCount];
    int currentIndex = 0;
    // Fill the array with unique elements
    for (int i = 0; i < array.Length; i++)
    {
        bool isUnique = true;
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
            {
                isUnique = false;
                break;
            }
        }
        if (isUnique)
        {
            uniqueElements[currentIndex] = array[i];
            currentIndex++;
        }
    }
    return uniqueElements;
}

