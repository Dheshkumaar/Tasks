using System;
using System.Collections.Generic;
using System.Linq;
namespace Task3
{
    class Program
    {
        public static void Question1()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers:");
            for(int i = 0; i < 10; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                numbers.Add(k);
            }
            Console.WriteLine("The number divisible by 7");
            foreach (var i in numbers)
            {
                if(i%7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Question2()
        {
            Console.WriteLine("Enter the minimum value");
            int starting_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum value");
            int ending_no = Convert.ToInt32(Console.ReadLine());
            if (starting_no > ending_no)
            {
                Console.WriteLine("Invalid entry");
            }
            else 
            { 
                Console.WriteLine("The prime numbers between {0} and {1} are :", starting_no, ending_no);
                for (int i = starting_no; i <= ending_no; i++)
                {
                    int flag = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine(i);
                }
            }
        }
        public static void Question3()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                    break;
                else
                    numbers.Add(i);
            }
            IEnumerable<int> duplicates = numbers.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            Console.WriteLine("repeated elements are:");
            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }
        }

        public static void Question4()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    break;
                else if(i<0)
                    Console.WriteLine("Please enter a positive number");
                else
                    numbers.Add(i);
            }
            var num = (from i in numbers
                       select i).OrderBy(i => i).ToList();
            Console.WriteLine("Numbers after sorting");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
        public static void Question5()
        {
            int count = 0;
            do
            {
                Console.WriteLine("Username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user == "Admin" & password == "admin")
                {
                    Console.WriteLine("Welcome");
                    break;
                }

                else
                {
                    Console.WriteLine("Inavalid username or password");
                    Console.WriteLine("Try Again");
                    count = count + 1;
                }
            } while (count < 3);
            if (count >= 3)
            {
                Console.WriteLine("Sorry you have already tried 3 times");
            }
        }
        public static void Question6()
        {
            string[] arr = { "kite", "four", "neat", "play", "goal" };
            Console.WriteLine("play...");
            int cow = 0, bull = 0;
            var idx = new Random().Next(arr.Length);
            string word = arr[idx];
            do
            {
                //Console.WriteLine(word);
                for (int i = 0; i < arr.Length; i++)
                {
                    cow = 0; bull = 0;
                    Console.WriteLine("guess word");
                    string GuessWord = Console.ReadLine();
                    for (i = 0; i < word.Length; i++)
                    {
                        if (word[i] == GuessWord[i])
                            cow += 1;
                        else
                        {
                            for (int j = 0; j < GuessWord.Length; j++)
                            {
                                if (word[i] == GuessWord[j] && i != j)
                                    bull += 1;
                            }
                        }
                    }
                    Console.WriteLine("Cows-- " + cow + " Bull--" + bull);
                }
            } while (cow != 4);
            if (cow == 4 && bull == 0)
                Console.WriteLine("You won!!!!!!!");
        }
        public static void Question7()
        {
            Console.WriteLine("Please enter the Card Number");
            string Card_number = Console.ReadLine();
            if (Card_number.Length == 16)
            {
                Card_number = reverse(Card_number);
                Console.WriteLine(Card_number);
                string sum = Sumandmul(Card_number);
                Console.WriteLine(sum);
                string mod = ModAndCheck(sum);
                Console.WriteLine(mod);
            }
            else
                Console.WriteLine("Enter card length is 16");
        }
        private static string ModAndCheck(string sum)
        {
            int number = Convert.ToInt32(sum);
            if (number % 10 == 0)
                return "Valid Card";
            else
                return "Please verify correct number";
        }

        private static string reverse(string number)
        {
            string output = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                output += number[i];
            }
            return output;
        }
        private static string Sumandmul(string number)
        {
            int num_convert, mul_, sum = 0, even_sum = 0, odd_sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char v = number[i];
                num_convert = (int)Char.GetNumericValue(v);
                if ((i + 1) % 2 == 0)
                {
                    mul_ = num_convert * 2;
                    if (mul_ >= 10)
                    {
                        while (mul_ > 0)
                        {
                            int n = mul_ % 10;
                            even_sum += n;
                            mul_ = mul_ / 10;
                        }
                    }
                    else
                        even_sum += mul_;
                }
                else
                {
                    odd_sum += num_convert;
                }
                sum = even_sum + odd_sum;
            }
            return Convert.ToString(sum);
        }

        static void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Question1-Divisible by 7");
                Console.WriteLine("2.Question2-Print all prime numbers within the range");
                Console.WriteLine("3.Question3-Print numbers that are repeating");
                Console.WriteLine("4.Question4-Numbers in ascending order");
                Console.WriteLine("5.Question5-Login details Program");
                Console.WriteLine("6.Question6-Cow and bull Game");
                Console.WriteLine("7.Question7-Credit card validation.");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Enter the number to run the code");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Question1();
                        break;
                    case 2:
                        Question2();
                        break;
                    case 3:
                        Question3();
                        break;
                    case 4:
                        Question4();
                        break;
                    case 5:
                        Question5();
                        break;
                    case 6:
                        string str;
                        do
                        {
                            Question6();
                            Console.WriteLine("Do you want to continue. Enter yes to continue");
                            str = Console.ReadLine();
                        } while (str == "yes");                       
                        break;
                    case 7:
                        Question7();
                        break;
                    case 8:
                        Console.WriteLine("Exitting");
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (choice != 8);
        }
        static void Main(string[] args)
        {
            PrintMenu();
            Console.ReadKey();
        }
    }
}
