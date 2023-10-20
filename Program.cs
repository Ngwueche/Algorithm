internal class Program
{
    static void IsPrime()
    {
        //check if a given number is a prime number or not.
        Console.Write("Enter a positive number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        double divider = (double)2;
        double maxDivider = Math.Sqrt(num);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (num % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("Is Prime? " + prime);
    }

    static void ReverseString()
    {
        //Reverse a given string.
        Console.Write("Enter a Word: ");
        string word = Console.ReadLine();

        char[] charWord = word.ToCharArray();
        Array.Reverse(charWord);
        var Rword = new string(charWord);
        Console.WriteLine(Rword);


    }
    static void Palindrome()
    {
        //Palindrome Check:
        //Check if a given string is a palindrome.
        Console.WriteLine("Enter your word: ");
        string word = Console.ReadLine();

        char[] charWord = word.ToCharArray();
        Array.Reverse(charWord);
        var ReversedWord = new string(charWord);
        if (word == ReversedWord)
            Console.WriteLine($" {word} is a Palindrome");
        else
            Console.WriteLine($" {word} is Not a Palindrome");


    }
    static void Anagram()
    {
        //Check if two strings are anagrams of each other.
        //a word, phrase, or name formed by rearranging the letters of another, such as spar, formed from rasp.
        Console.WriteLine("Enter your word: ");
        string word1 = Console.ReadLine();

        Console.WriteLine("Enter another word: ");
        string word2 = Console.ReadLine();

        if (word1.Length != word2.Length)
            Console.WriteLine("The two words are Not Anagrams.");
        char[] charWord = word1.ToCharArray();
        char[] charWord2 = word2.ToCharArray();
        Array.Sort(charWord);
        Array.Sort(charWord2);

        if (charWord.SequenceEqual(charWord2))
            Console.WriteLine("The two words are Anagram");
        else
            Console.WriteLine("The two words are Not Anagram");
    }
    static void TwoSum()
    {
        //Two Sum:
        //Given an array of integers, find two numbers such that they add up to a specific target.



    }
    static void Reverse()
    {
        Console.WriteLine("Enter your word: ");
        string word1 = Console.ReadLine();
        var myWord = word1.ToCharArray();
        var stack = new Stack<char>();
        stack.Push(myWord);
        Console.WriteLine(myWord);
    }


    //FizzBuzz:

    //Print numbers from 1 to n, but for multiples of 3 print "Fizz" and for multiples of 5 print "Buzz".
    //Factorial:

    //Compute the factorial of a non-negative integer.
    //Fibonacci Sequence:

    //Generate the Fibonacci sequence up to a given number.
    //Bubble Sort:

    //Implement the Bubble Sort algorithm to sort an array.
    //Selection Sort:

    //Implement the Selection Sort algorithm to sort an array.
    //Binary Search:

    //Implement the Binary Search algorithm to find a target element in a sorted array.
    //Merge Sort:

    //Implement the Merge Sort algorithm to sort an array.
    //Quick Sort:

    //Implement the Quick Sort algorithm to sort an array.
    //Maximum Subarray Sum:

    //Find the contiguous subarray with the largest sum.
    //Longest Common Prefix:

    //Find the longest common prefix among an array of strings.
    //Detect a Cycle in a Linked List:

    //Determine if a linked list has a cycle.
    //Reverse a Linked List:

    //Reverse a singly linked list.
    //Detect a Cycle in a Directed Graph:

    //Detect a cycle in a directed graph.
    //Graph Traversals (DFS, BFS):

    //Implement Depth-First Search (DFS) and Breadth-First Search (BFS) for a graph.
    //Minimum Spanning Tree (Prim's or Kruskal's algorithm):

    //Find the minimum spanning tree of a weighted graph.
    //Dijkstra's Shortest Path:

    //Find the shortest path between nodes in a weighted graph using Dijkstra's algorithm.

    private static void Main(string[] args)
    {
        Reverse();
        //TwoSum();
        //Anagram();
        //Palindrome();
        //ReverseString();
        //IsPrime();
    }
}