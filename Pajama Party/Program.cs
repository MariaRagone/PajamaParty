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
Console.WriteLine("Reverse a String:\r\nWrite a function that takes a string as input and returns the string reversed.");

string original = "Hello There";
ReverseString(original);
static void ReverseString(string x)
{
    string reversed = new string(x.ToCharArray().Reverse().ToArray());
    Console.WriteLine(reversed);

    //OR
    char[] charArray = x.ToCharArray();
    for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
    {
        // Swap characters at positions i and j
        char temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
    }
    string reversed2 = new string(charArray);
    Console.WriteLine(reversed2);
}
Console.WriteLine("Factorial:\r\nWrite a function to calculate the factorial of a given non-negative integer.");
Console.WriteLine(CalculateFactorial(5)); //prints 120
static int CalculateFactorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine("Fibonacci Sequence:\r\nImplement a function to generate the nth Fibonacci number. " +
    "The Fibonacci sequence is defined as follows: F(0) = 0, F(1) = 1, and F(n) = F(n-1) + F(n-2) for n > 1.");
//F(n)=F(n−1)+F(n−2)
//recursion
int n = 6;
Console.WriteLine(CalculateFibonacci(n));
static int CalculateFibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    int[] fibonacci = new int[n + 1]; //the +1 is used in fibonacci sequence calculations to account for the initial values of 0 and 1
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i <= n; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci[n];
}

Console.WriteLine("Write a function to determine if a given string is a palindrome. " +
    "Ignore spaces, punctuation, and capitalization.");
string a = "mom.";
Console.WriteLine($"{a} is a palindrom: {CheckPalindrome(a)}");
static bool CheckPalindrome(string a)
{
    string original = a.ToString().ToLower();
    string clean = new string(original.Where(Char.IsLetterOrDigit).ToArray());
    string reversed = new string(clean.Reverse().ToArray());
    //string reverse = new string(original.Reverse().ToArray());
    return clean == reversed;
}

string f = "Dad. ?%";
Console.WriteLine($"{f} is a palindrom: {Checked(f)}");
static bool Checked(string x)
{
    string cleaned = new string(x.Where(Char.IsLetterOrDigit).ToArray()).ToLower();

    for (int i = 0; i < cleaned.Length; i++)
    {
        if (cleaned[cleaned.Length - 1 - i] != cleaned[i])
        {
            return false;
        }
    }
    return true;
}


double u = 121.121;
Console.WriteLine(C(u));
static bool C(double x)
{
    if (x < 0) //check to see if the number is negative.
    {
        return false;
    }
    else if (x > 0)
    {
        string s = x.ToString();
        string cleaned = new string(s.Where(Char.IsLetterOrDigit).ToArray());
        string reversed = new string (cleaned.Reverse().ToArray());
        return cleaned == reversed;
        //for (int i = 0; i < s.Length / 2; i++)
        //{
        //    if (s[s.Length - 1 - i] == s[i])
        //    { return true; }
        //}
    }
    return false;
}

string h = "Racecars";

Console.WriteLine(CheckForP(h));
static bool CheckForP(string x)
{
    //string original = x.ToString();
    //string cleaned = new string(original.Where(Char.IsLetterOrDigit).ToArray());
    //string reversed = new string(cleaned.Reverse().ToArray());
    //Console.WriteLine(reversed);
    //return cleaned == reversed;


for (int i = 0; i<x.Length / 2; i++)
    {
        if (x[x.Length-1-i] == x[i])
        {
            return true;
        }
    }
    return false;
}




//---------------------------------------------------------------------------------------------------------------------
