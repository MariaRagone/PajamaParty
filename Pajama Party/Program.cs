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
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

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
string palindrome3 = "daddy";
bool result3 = IsPalindrome3(palindrome3);
Console.WriteLine(result3);
static bool IsPalindrome3(string x)
    {
    string original = x.ToString();
    string reversed = new string (original.Reverse().ToArray());
    return original == reversed;
    }