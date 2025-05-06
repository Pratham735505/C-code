/*Practical 2
Q1: Mr.XYZ has been packing for his trip and he is looking for his socks , he wants to know how many pairs of socks he has, if a single lowercase alpha denotes one sock then tell how many pairs he has :
Ex : sock_pairs("acbcca") = 2 pairs (aa cc)

Q2 : WAP in which If the anagram of a substring (sub) is found in the string (sup) then return true else false, ex:
"car" , "race" returns true

"bag" , "grab" return false

 Practical 3 ques :
Q) WAP to input a string and find the nearest vowel in the string based on the character that is entered.
Q) WAP to input a string and print the frequency of each letter.
Q) WAP to input a string and find which word contains maximum vowels.

 */
using System;

namespace Practicalques
{
    // Base class for common string operations
    public class StringOperations
    {
        protected string inputString;

        public StringOperations(string input)
        {
            inputString = input;
        }

        public virtual void Display() { }
    }

    // Class to find sock pairs
    public class SockPairs : StringOperations
    {
        public SockPairs(string input) : base(input) { }

        public int FindSockPairs()
        {
            int[] sockCount = new int[26]; // Array to store counts of socks (a-z)

            foreach (char sock in inputString)
            {
                sockCount[sock - 'a']++; // Increment the count for the corresponding sock
            }

            int pairs = 0;
            for (int i = 0; i < sockCount.Length; i++)
            {
                pairs += sockCount[i] / 2; // Calculate pairs by dividing counts by 2
            }

            return pairs;
        }

        public override void Display()
        {
            Console.WriteLine($"Number of sock pairs: {FindSockPairs()}");
        }
    }

    // Class to check for anagram substring
    public class AnagramSubstring : StringOperations
    {
        private string substring;

        public AnagramSubstring(string sub, string sup) : base(sup)
        {
            substring = sub;
        }

        public bool IsAnagramSubstring()
        {
            int[] subCount = new int[26]; // Frequency of substring characters
            int[] windowCount = new int[26]; // Frequency of characters in current window

            // Count frequency of characters in substring
            foreach (char c in substring)
            {
                subCount[c - 'a']++;
            }

            int windowSize = substring.Length;

            for (int i = 0; i < inputString.Length; i++)
            {
                windowCount[inputString[i] - 'a']++; // Add current character to window

                if (i >= windowSize)
                {
                    windowCount[inputString[i - windowSize] - 'a']--; // Remove character outside window
                }

                if (AreArraysEqual(subCount, windowCount))
                {
                    return true;
                }
            }

            return false;
        }

        private bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override void Display()
        {
            Console.WriteLine($"Is the substring an anagram: {IsAnagramSubstring()}");
        }
    }

    // Class to find the nearest vowel
    public class NearestVowel : StringOperations
    {
        private char character;

        public NearestVowel(string input, char ch) : base(input)
        {
            character = ch;
        }

        public char FindNearestVowel()
        {
            string vowels = "aeiouAEIOU";
            int minDistance = int.MaxValue;
            char nearestVowel = '\0';

            for (int i = 0; i < inputString.Length; i++)
            {
                if (vowels.Contains(inputString[i].ToString()))
                {
                    int distance = Math.Abs(i - inputString.IndexOf(character));
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        nearestVowel = inputString[i];
                    }
                }
            }

            return nearestVowel;
        }

        public override void Display()
        {
            Console.WriteLine($"Nearest vowel to {character}: {FindNearestVowel()}");
        }
    }

    // Class to count letter frequency
    public class LetterFrequency : StringOperations
    {
        public LetterFrequency(string input) : base(input) { }

        public void CountLetterFrequency()
        {
            int[] frequency = new int[26]; // To store frequencies of each letter

            foreach (char ch in inputString.ToLower())
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    frequency[ch - 'a']++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine((char)(i + 'a') + ": " + frequency[i]);
                }
            }
        }

        public override void Display()
        {
            Console.WriteLine("Letter frequencies:");
            CountLetterFrequency();
        }
    }

    // Class to find the word with the most vowels
    public class MaxVowelWord : StringOperations
    {
        public MaxVowelWord(string input) : base(input) { }

        public string FindMaxVowelWord()
        {
            string[] words = inputString.Split(' ');
            string vowels = "aeiouAEIOU";
            int maxVowelCount = 0;
            string maxVowelWord = "";

            foreach (string word in words)
            {
                int vowelCount = 0;
                foreach (char ch in word)
                {
                    if (vowels.Contains(ch.ToString()))
                    {
                        vowelCount++;
                    }
                }

                if (vowelCount > maxVowelCount)
                {
                    maxVowelCount = vowelCount;
                    maxVowelWord = word;
                }
            }

            return maxVowelWord;
        }

        public override void Display()
        {
            Console.WriteLine($"Word with maximum vowels: {FindMaxVowelWord()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test for SockPairs
            SockPairs sockPairs = new SockPairs("acbcca");
            sockPairs.Display(); // Output: 2 pairs

            // Test for AnagramSubstring
            AnagramSubstring anagram = new AnagramSubstring("car", "race");
            anagram.Display(); // Output: true

            // Test for NearestVowel
            NearestVowel nearestVowel = new NearestVowel("programming", 'g');
            nearestVowel.Display(); // Output: 'o'

            // Test for LetterFrequency
            LetterFrequency letterFrequency = new LetterFrequency("programming");
            letterFrequency.Display();

            // Test for MaxVowelWord
            MaxVowelWord maxVowelWord = new MaxVowelWord("the quick brown fox jumps over the lazy dog");
            maxVowelWord.Display(); // Output: "over"
        }
    }
}
