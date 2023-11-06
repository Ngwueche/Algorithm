namespace algorithm
{
    public static class Weekly_Algorithm
    {
        //        Task
        //Finish the function numberToOrdinal, which should take a number and return it as a string with the correct ordinal indicator suffix(in English). For example, 1 turns into "1st".

        //For the purposes of this challenge, you may assume that the function will always be passed a non-negative integer.If the function is given 0 as an argument, it should return the string "0" without a suffix.

        //To help you get started, here is an excerpt from Wikipedia's page on Ordinal Indicators:

        //st is used with numbers ending in 1 (e.g. 1st, pronounced first)
        //nd is used with numbers ending in 2 (e.g. 92nd, pronounced ninety-second)
        //rd is used with numbers ending in 3 (e.g. 33rd, pronounced thirty-third)
        //As an exception to the above rules, all the "teen" numbers ending with 11, 12 or 13 use -th(e.g. 11th, pronounced eleventh, 112th, pronounced one hundred[and] twelfth)
        //th is used for all other numbers(e.g. 9th, pronounced ninth).
        //Specification
        //Challenge.NumberToOrdinal(number)
        //take a number and return it as a string with the correct English ordinal indicator suffix

        public static string NumberToOrdinal(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            if (number % 100 >= 11 && number % 100 <= 13)
            {
                return number + "th";
            }

            switch (number % 10)
            {
                case 1:
                    return number + "st";
                case 2:
                    return number + "nd";
                case 3:
                    return number + "rd";
                default:
                    return number + "th";
            }

        }
        //        An ATM only has 100, 50 and 20 dollar bills(USD) available to be dispensed.

        //Given an amount between 40 and 10000 dollars (inclusive) and assuming that the ATM wants to use as few bills as possible, determinate the minimal number of 100, 50 and 20 dollar bills the ATM needs to dispense (in that order).

        //Here is the specification for the withdraw method you'll complete:
        //public class Challenge
        //{
        //    public static List<int> Withdraw(int amount)
        //    {
        //        int hundred = 0;
        //        int fifty = 0;
        //        int twenty = 0;

        //        if (amount >= 100)
        //            hundred = amount / 100;
        //        int TempFifty = (amount - (hundred * 100));
        //        if (TempFifty >= 50 && TempFifty % 50 == 0)
        //            fifty = TempFifty / 50;
        //        int TempTwenty = (TempFifty - (fifty * 50));
        //        if (TempFifty % 50 != 0 && TempTwenty >= 20 && TempFifty % 20 == 0)
        //            twenty = TempTwenty / 20;
        //        return new List<int>() { hundred, fifty, twenty };
        //    }
        //}

        //public static int CalculateBills(int amount)
        //{
        //    int hundreds = amount / 100;
        //    amount %= 100;

        //    int fifties = amount / 50;
        //    amount %= 50;

        //    int twenties = amount / 20;

        //    Console.WriteLine($"$100 bills: {hundreds}");
        //    Console.WriteLine($"$50 bills: {fifties}");
        //    Console.WriteLine($"$20 bills: {twenties}");
        //}
    }
}
