using System.Text;

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
    //static void Reverse()
    //{
    //    Console.WriteLine("Enter your word: ");
    //    string word1 = Console.ReadLine();
    //    var myWord = word1.ToCharArray();
    //    var stack = new Stack<char>();
    //    stack.Push(myWord);
    //    Console.WriteLine(myWord);
    //}

    static int GetFactorial(int n)
    {
        //Compute the factorial of a non-negative integer.
        //Fibonacci Sequence:
        if (n == 0)
            return n = 1;
        else
            return n * GetFactorial(n - 1);

    }
    static long Fibonacci(int n)
    {
        //Fibonacci Sequence:
        //Compute the factorial of a non-negative integer.
        if (n == 0)
            return 1;
        if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); //if n=3 => 3,2,1

        //long fn = 1;
        //long fn1 = 1;
        //long fn2 = 1;
        //for (int i = 2; i < n; i++)
        //{
        //    fn = fn1 + fn2;
        //    fn2 = fn1;
        //    fn1 = fn;
        //}
        //return fn;
    }
    static void FizzBuzz()
    {
        //FizzBuzz:
        //Print numbers from 1 to n, but for multiples of 3 print "Fizz" and for multiples of 5 print "Buzz".

        Console.WriteLine("Enter a number");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 1; i < input + 1; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }
    static void SortBubble()
    {
        //Bubble Sort:
        //Implement the Bubble Sort algorithm to sort an array.

        int[] arr = new int[] { 34, 52, 12, 6, 98, 43, 22 };
        int n = arr.Length;
        bool flag = true;
        int temp;

        for (int i = 1; i < n - 1 && flag; i++)
        {
            flag = false;
            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])//ascending order
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                    flag = true;
                }
            }
            foreach (int num in arr)
                Console.WriteLine(num);
        }
    }
    public static void plusMinus(List<int> arr)
    {
        //Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with places after the decimal.
        List<int> proportion = new() { 0, 0, 0 };
        foreach (int i in arr)
        {
            if (i > 0)
                proportion[0]++;
            if (i < 0)
                proportion[1]++;
            if (i == 0)
                proportion[2]++;
        }
        decimal positive = (decimal)proportion[0] / arr.Count;
        decimal negative = (decimal)proportion[1] / arr.Count;
        decimal zero = (decimal)proportion[2] / arr.Count;

        Console.WriteLine(positive.ToString("F6"));
        Console.WriteLine(negative.ToString("F6"));
        Console.WriteLine(zero.ToString("F6"));
    }

    public static void staircase(int n)
    {
        //    #
        //   ##
        //  ###
        // ####
        //#####
        for (int i = 1; i <= n; i++)
        {
            StringBuilder str = new StringBuilder();
            for (int j = 1; j <= n; j++)
            {
                if (j <= n - i) str.Append(" ");
                else str.Append("#");
            }
            Console.WriteLine(str);
        }
    }
    public static void MiniHangman()
    {
        // create a gussing game where a player guess the letters in a word. 
        string[] words = { "football", "love", "family", "judge", "school", "nonesense" };
        Random random = new Random();

        var randomWord = random.Next(0, words.Length);
        var ChosenWord = words[randomWord];
        var hiddenWord = "";
        for (int i = 0; i < ChosenWord.Length; i++)
        {
            hiddenWord += "*";
        }
        Console.WriteLine($"Guess the letters in the random word! {hiddenWord}");
        while (hiddenWord.Contains("*"))
        {
            bool containsLetter = false;
            var letter = char.Parse(Console.ReadLine());
            for (int i = 0; i < ChosenWord.Length; i++)
            {
                if (letter == ChosenWord[i])
                {
                    hiddenWord = hiddenWord.Remove(i, 1).Insert(i, letter.ToString());
                    containsLetter = true;
                }
            }
            if (containsLetter == true)
                Console.WriteLine($"{letter} is containted in the word.");
            else
                Console.WriteLine($"{letter} is Not containted in the word.");
        }
        Console.WriteLine($"Great! You guessed right! The word is : {ChosenWord}");
    }

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

    public static void AddExtra(ref int Score)
    {
        Score += 3;
    }

    private static void Main(string[] args)
    {
        int studentScore = 75;
        AddExtra(ref studentScore);
        Console.WriteLine(studentScore);
        //MiniHangman();
        //SortBubble();
        //FizzBuzz();
        //Console.WriteLine(Fibonacci(5));
        //Console.WriteLine(GetFactorial(12));
        //Reverse();
        //TwoSum();
        //Anagram();
        //Palindrome();
        //ReverseString();
        //IsPrime();


        //Console.WriteLine(Weekly_Algorithm.CalculateBills(230));
        //int sumI = 0;
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //    sumI += i;
        //}
        //Console.WriteLine(sumI);


    }

}