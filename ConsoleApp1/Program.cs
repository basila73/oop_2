namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //            using System;

            //interface IOutput2
            //        {
            //            void ShowEven();
            //            void ShowOdd();
            //        }

            //        class Array : IOutput2
            //        {
            //            int[] numbers;

            //            public Array(int[] n)
            //            {
            //                numbers = n;
            //            }

            //            public void ShowEven()
            //            {
            //                Console.WriteLine("Even numbers:");

            //                foreach (int n in numbers)
            //                {
            //                    if (n % 2 == 0)
            //                    {
            //                        Console.WriteLine(n);
            //                    }
            //                }
            //            }

            //            public void ShowOdd()
            //            {
            //                Console.WriteLine("Odd numbers:");

            //                foreach (int n in numbers)
            //                {
            //                    if (n % 2 != 0)
            //                    {
            //                        Console.WriteLine(n);
            //                    }
            //                }
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //                Array arr = new Array(nums);

            //                arr.ShowEven();
            //                arr.ShowOdd();
            //            }
            //        }



            using System;

interface ICalc2
        {
            int CountDistinct();
            int EqualToValue(int valueToCompare);
        }

        class Array : ICalc2
        {
            int[] numbers;

            public Array(int[] n)
            {
                numbers = n;
            }

            public int CountDistinct()
            {
                int count = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    bool found = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            found = true;
                        }
                    }

                    if (found == false)
                    {
                        count++;
                    }
                }

                return count;
            }

            public int EqualToValue(int valueToCompare)
            {
                int count = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == valueToCompare)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] nums = { 1, 2, 3, 2, 4, 1, 5, 2 };

                Array arr = new Array(nums);

                Console.WriteLine("Distinct values: " + arr.CountDistinct());

                Console.WriteLine("Enter value to compare:");
                int value = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Equal values: " + arr.EqualToValue(value));
            }
        }


    }
}
}
