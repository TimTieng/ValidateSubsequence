/*
Problem: Given two, non-empty arrays of integers, write a function that determines if the second array
is a subsequence of the first array. 

Note: A subsequence of an array is a set of numbers that are not necessarily adjacent in the array, but that are
in the same order as they appear in the array
*/
using System;
using System.Collections.Generic;

namespace ValidateSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Positive Test - Should print This is a sequence
            List<int> arr1 = new List<int> {1,2,3,4};
            List<int> seq1 = new List<int> {2,4};
            ValidateSubsequence(arr1,seq1);

            // Negative Test - Should print this is not a sequence
            List<int> arr2 = new List<int> {1,2,3,4};
            List<int> seq2 = new List<int> {25,45};
            ValidateSubsequence(arr2,seq2);
        }
        public static void ValidateSubsequence(List<int> array, List<int> sequence)
        {
            // Declare and Initialize Pointers to be used as Index values
            int arrayPointer = 0;
            int seqPointer = 0;
            // Create a loop that evaluates both the array and the potential subsequence
            // NOTE Multiple conditions required because we have two arrays
            // Execute code while both pointers are less than their respective collection count
            while (arrayPointer < array.Count && seqPointer < sequence.Count)
            {
                if (array[arrayPointer] == sequence[seqPointer])
                {
                    // increment seqPointer
                    seqPointer++;
                }
                arrayPointer++;
            }
            // Use this as the evaluation criteria because if the seqPoint is incremented
            // This means it traversed the entire list implying that it is a valid SubSeq.
            if (seqPointer == sequence.Count)
            {
                Console.WriteLine("The provided sequence is a subsquence of the array");
            }
            else 
            {
                Console.WriteLine("The provided sequence is NOT a subsequence of the array");
            }

        }
    }
}