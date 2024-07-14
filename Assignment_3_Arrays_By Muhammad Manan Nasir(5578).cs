using System;
using System.Linq;

namespace MyApp
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            RemoveDuplicate();
            LargestAndSecondLargest();
            ZerosAtEnd();
            FirstNonRepeatingChar();
            MergeSortedArray();
            MissingNumber();
            ArmstrongNumber();
            LongestCommonPrefix();
            FibonacciSequence();
            PositiveNegativeTotalAverage();
        }

        //Task#1 : Write a program to delete the duplicates from an array
        static void RemoveDuplicate()
        {

            int arraySize, currentIndex, nextIndex, shiftIndex;

            Console.WriteLine("Enter the array size : ");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arraySize];

            Console.WriteLine("Enter the Elements of Array: ");
            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                arr[currentIndex] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array: ");
            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                Console.WriteLine(arr[currentIndex]);
            }

            Console.WriteLine("Array After Removing Duplicate Elements: ");
            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                for (nextIndex = currentIndex + 1; nextIndex < arraySize;)
                {
                    if (arr[currentIndex] == arr[nextIndex])
                    {
                        for (shiftIndex = nextIndex; shiftIndex < arraySize - 1; shiftIndex++)
                        {
                            arr[shiftIndex] = arr[shiftIndex + 1];
                        }
                        arraySize--;
                    }
                    else
                    {
                        nextIndex++;
                    }
                }
            }

            for (currentIndex = 0; currentIndex < arraySize; currentIndex++)
            {
                Console.WriteLine(arr[currentIndex]);
            }

            Console.ReadLine();
        }

        //Task#2 : Write a program to find the largest and the second largest number in an array.
        static void LargestAndSecondLargest()
        {
            int arraySize, index, max1, max2;
            int[] arr = new int[50];

            Console.WriteLine("Enter the Size of Array : ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Elements of Array : ");
            for (index = 0; index < arraySize; index++)
            {
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }

            max1 = max2 = int.MinValue;
            for (index = 0; index < arraySize; index++)
            {
                if (arr[index] > max1)
                {
                    max2 = max1;
                    max1 = arr[index];
                }
                else if (arr[index] > max2)
                {
                    max2 = arr[index];
                }
            }
            Console.WriteLine("First Largest Number= " + max1);
            Console.WriteLine("Second Largest Number= " + max2);



            Console.ReadLine();
        }

        //Task#3: Write a program that places all the zeros in an array at the end of the list.
        static void ZerosAtEnd()
        {
            int[] arr = { 3, 2, 0, 4, 0, 8, 5 };
            int cnt = 0; // Counter for non-zero elements

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[cnt] = arr[i];
                    cnt++;
                }
            }
            // Now all non-zero elements have been shifted to the front
            // Fill remaining elements with zero
            for (int i = cnt; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }

        // Task#4: Write a program to find the first non-repeating character in a string.
        static void FirstNonRepeatingChar()
        {
            Console.WriteLine("Program to find the first non-repeating character in a string.");
            Console.Write("Enter the String:");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < word.Length; j++)
                {
                    if (i != j && word[i] == word[j])
                    {
                        isUnique = false;
                        break;
                    }
                    if (isUnique)
                    {
                        Console.WriteLine("The first non-repeating character is: " + word[i]);
                        return;
                    }

                }
            }
            Console.WriteLine("No non-repeating characters found.");
        }

        // Task#5: Write a program to merge two sorted arrays into a single sorted array. 
        static void MergeSortedArray()
        {
            Console.Write("Enter the size of first array: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[n1];
            Console.WriteLine("Write the elements of first array: ");
            for (int i = 0; i < n1; i++)
            {
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the size of second array: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] secondArray = new int[n2];
            Console.WriteLine("Write the elements fo first array: ");
            for (int i = 0; i < n1; i++)
            {
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(firstArray);
            Array.Sort(secondArray);
            int[] mergedArray = new int[n1 + n2];
            Array.Copy(firstArray, 0, mergedArray, 0, n1);
            Array.Copy(secondArray, 0, mergedArray, n1, n2);

            // Sort the merged array
            Array.Sort(mergedArray);
            
            Console.WriteLine("Merged array:");
            for (int index = 0; index < mergedArray.Length; index++)
            {
                Console.Write(mergedArray[index] + " ");
            }

        }

        //Task#6: Write a program to find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n. 

        static void MissingNumber()
        {
            Console.Write("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Write the elements of array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = 0; i < n-1; i++)
            {
                if (array[i + 1] - array[i]>1)
                {
                    Console.WriteLine("The missing number is: " + (array[i]+1));
                    return;
                }
            }
            if (array[0] > 0)
            {
                Console.WriteLine("The missing number is: 0");
            }
            else
            {
                Console.WriteLine("The missing number is: " + n);
            }
        }

        //Task#7: Write a program to check whether a number is Armstrong number or not.
        static void ArmstrongNumber()
        {
            Console.WriteLine("Enter a Number");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            int sum = 0;
            for (int i=0; i<input.Length; i++)
            {
            int digit = Convert.ToInt32(input[i].ToString());
                sum = sum + (digit*digit*digit);
            }
            if (sum == sum)
            {
                Console.WriteLine($"The entered number {input} is an armstrong number.");
            }
            else
                Console.WriteLine($"The entered number {input} is NOT an armstrong number.");
            {

            }
        }

        //Task#8: Write a program to find the longest common prefix in an array of strings.

        static void LongestCommonPrefix()
        {
            string[] strs = { "flower", "flow", "flight" };
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // Reduce the prefix by one character at a time
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If the prefix becomes empty, return an empty string
                    if (prefix == "")
                    {
                        Console.WriteLine("Longest Common Prefix: ");
                        return;
                    }
                }
            }

            Console.WriteLine("Longest Common Prefix: " + prefix);
        }


        //Task#9: Write a program that prints the Fibonacci sequence up to n terms (where n is user input).

        static void FibonacciSequence()
        {
            Console.WriteLine("This porgrma prints the Fibonacci Sequence upto n terms");
            Console.Write("Enter the number n: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.Write(a + " ");

            for (int i=1; i<num; i++)
            {
                Console.Write(b + " ");
                int nextNumber = a + b;
                a = b;
                b = nextNumber;
            }
        }

        // Task#10: Write a program that reads N integers, determines how many positive and negative values have been read and computes the total and average of input values.

        static void PositiveNegativeTotalAverage()
        {
            Console.WriteLine("This Program will find the positive negative intergers, total and average");
            Console.WriteLine("How many numbers you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int negativeNumbers = 0;
            int positiveNumbers = 0;
            int total = 0;
            double average = 0;
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0;i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    negativeNumbers++;
                }
                if (array[i] > 0)
                {
                    positiveNumbers++;
                }
                total = total + array[i];
                average = (double) total / n;
            }
            Console.WriteLine("Negative Numbers: " + negativeNumbers);
            Console.WriteLine("Positive Numbers: " + positiveNumbers);
            Console.WriteLine("Total: " + total);
            Console.WriteLine( "Average: " + average);
        }

    }
}

