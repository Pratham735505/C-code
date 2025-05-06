
namespace numandstr
{
    public class Str
    {
        //1
        public string ReverseString(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        //2
        public string ExtractDigits(string input)
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    result.Append(c);
            }
            return result.ToString();
        }

        //3
        public bool ContainsOnlyDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        //4
        public int vowelcount(string input)
        {
            int vowelCount = 0;
            foreach (char c in input.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        //5
        public string capitalize(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }
            string capitalized = string.Join(" ", words);
            return capitalized;
        }
        //6
        public string counter(string input, char searchChar)
        {
            
            int count = 0;
            foreach (char c in input)
            {
                if (c == searchChar)
                {
                    count++;
                }
            }
            return $"The character '{searchChar}' occurs {count} times.";
        }
        //7
        public string replace(string input,char oldChar, char newChar)
        {
            char[] resultArray = input.ToCharArray();
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (resultArray[i] == oldChar)
                {
                    resultArray[i] = newChar;
                }
            }
            string result = new string(resultArray);
            return "Replaced string: " + result;
        }

        //8 average lengtyh of words in sentnce

        public string avlen(string input)
        {
            string[] words = input.Split(' ');
            int totalLength = 0;
            foreach (string word in words)
            {
                totalLength += word.Length;
            }
            double averageLength = (double)totalLength / words.Length;
            return "Average word length: " + averageLength;
        }

        //9 have same frequency of each character
        public string anagram(string str1,string str2)
        {
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string sortedStr1 = new string(arr1);
            string sortedStr2 = new string(arr2);
            bool areAnagrams = sortedStr1 == sortedStr2;
            return $"The strings \"{str1}\" and \"{str2}\" are anagrams: {areAnagrams}";
        }

        //10
        public string upper(string input)
        {
            string result = string.Empty;
            foreach (char c in input)
            {
                result += char.ToUpper(c);
            }
            return "Uppercase string: " + result;
        }
    }

    public class Num
    {
        //1
        public string isprime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return "not prime";
                }
            }
            return "prime";
        }
        //2

        public int factorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
        //3
        public int floorsqrt(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            int i = 1;
            while (true)
            {
                if (i * i > n)
                {
                    return i - 1;
                }
                if (i * i == n)
                {
                    return i;
                }
                i++;
            }
        }

        //4
        public int reverse(int n)
        {
            int s = 0;
            while (n > 0)
            {
                s = s * 10 + n % 10;
                n = n / 10;
            }
            return s;
        }

        //5
        public bool IsPerfectNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }

        //6
        public int bintodec(int n)
        {

            int s = 0;
            int i = 1;

            while (n > 0)
            {
                s = s + n % 10 * i;
                n = n / 10;
                i = i * 2;
            }
            return s;
        }
        //7
        public bool perfcube(int n)
        {
            for (int i = 1; i <= n / 3 + 1; i++)
            {
                if (i * i * i == n)
                {
                    return true;
                }
                if (i * i * i > n)
                {
                    return false;
                }
            }
            return false;
        }

        //8 How can you determine if a number is a Mersenne prime (a prime number that is one less than a power of two)?

        public bool mersenneprime(int n)
        {
            int i = 1;
            while (true)
            {
                if(i==n+1)
                {
                    break;
                }
                if(i>n+1)
                {
                    return false;
                }
                i *= 2;
            }

            if (isprime(n) == "prime") return true;
            return false;
        }

        //9 A Sophie Germain prime is a prime number p for which  2p+1 is also a prime number.
        public bool sophiegerman(int n)
        {
            if(isprime(n) == "prime" && isprime(2*n + 1)=="prime")
            {
                return true;
            }
            return false;
        }

        //10 A Repunit number is a positive integer that consists entirely of the digit 1. The term "Repunit" comes from "repeated unit."

        public bool repunit(int n)
        {
            int i = 1;
            while (true)
            {
                if ((i - 1) / 9 == n)
                {
                    return true;
                }
                if ((i - 1) / 9 > n)
                {
                    return false;
                }
                i *= 10;
            }
        }


    }
}
