using System;

namespace Assignment1_ISM6225
{
    class Program
    {
        static void Main(string[] args)

        // Question 1
        {
            public bool JudgeCircle(string moves)
            {
                int x = 0;
                int y = 0;
                //Checking for L,R & U,D moves
                foreach (char move in moves)
                {
                    switch (move)
                    {
                        case 'U':
                            y--;
                            break;
                        case 'D':
                            y++;
                            break;
                        case 'L':
                            x--;
                            break;
                        case 'R':
                            x++;
                            break;
                    }
                }

                return (x.Equals(0) && y.Equals(0));
            }
        }
    }
}

// Question 2

class Program
{
    public static bool checkPangram(string str)
{

    // Create a hash table to mark the
    // characters in the string

    bool[] mark = new bool[26];

    // For indexing in mark[]
    int index = 0;

    // Iterate on all characters
    for (int i = 0; i < str.Length; i++)
    {
      if ('a' <= str[i] && str[i] <= 'z')
            index = str[i] - 'a';
  
        else
            continue;

        mark[index] = true;
    }

    // False if any character is unmarked
    for (int i = 0; i <= 25; i++)
        if (mark[i] == false)
            return (false);

    // If all present
    return (true);
}

// Driver Code
public static void Main()
{
    string str = "The quick brown fox jumps over the lazy dog";

    if (checkPangram(str) == true)
        Console.WriteLine(str + " is a pangram.");
    else
        Console.WriteLine(str + " is not a pangram.");
}
}

// Question 3

class GoodPairs
{
    public int NumIdenticalPairs(int[] nums)
    {
        int counter = 0;

        //Loop for comparing values on nums
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if ((nums[i] == nums[j]) && (i < j))
                    counter += 1;
            }

        }
        //display counter as final value
        return counter;
    }

}

// Question 4
class PivotIn
{
    public int PivotIndex(int[] nums)
    {
        try
        {
            // Declaring the right and left sum
            int[] right_sum = new int[nums.Length];
            int[] left_sum = new int[nums.Length];

            //Loop for storing the sum for all possible combinations

            for (int i = 1; i < nums.Length; i++)
            {
                left_sum[i] = nums[i - 1] + left_sum[i - 1];//starts from the left
                right_sum[nums.Length - i - 1] = nums[nums.Length - i] + right_sum[nums.Length - i];//starts from the right
            }

            // Comparing sum
            for (int i = 0; i < nums.Length; i++)
            {
                if (left_sum[i] == right_sum[i])
                {
                    return i;
                }
            }
            return -1;

        }
        catch (Exception e)
        {

            Console.WriteLine("Error!: " + e.Message);
            throw;
        }
    }
}

// Question 5
class StringBuilder
{
    private static string MergeAlternately(string word1, string word2)
    {
        try
        {
            //Declaring final output AND checking extra letters
            string newLength = "";
            int difference = word1.Length - word2.Length;
            int max_length = Math.Max((word1.Length), (word2.Length));

            for (int i = 0; i < (max_length - Math.Abs(difference)); i++)
            {
                newLength += word1[i];
                newLength += word2[i];
            }


            //To add extra letters to newlength if word2 longer
            if (difference < 0)
            {
                for (int j = 0; j < (Math.Abs(difference)); j++)
                {
                    newLength += word2[max_length - Math.Abs(difference) + j];

                }

            }

            //To add extra letters from word1 if its longer
            if (difference > 0)
            {
                for (int j = 0; j < Math.Abs(difference); j++)
                {
                    newLength += word1[max_length - Math.Abs(difference) + j];
                }
            }

            return newLength;
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

 }

// Question 6

class GoatLat
{
    private static string ToGoatLatin(string sentence)
    {
        try
        {
            // To build new string
            var new_string = new System.Text.StringBuilder();
            var each_word = sentence.Split();

            for (int j = 0; j < each_word.Length; j++)
            {
                //To store word
                var w = each_word[j];
                if (j > 0)
                {
                    new_string.Append(' ');
                }

                //To check for vowels
                if (w[0] == 'a' || w[0] == 'e' || w[0] == 'i' || w[0] == 'o' || w[0] == 'u' ||
                w[0] == 'A' || w[0] == 'E' || w[0] == 'I' || w[0] == 'O' || w[0] == 'U')
                {
                    //To append the entire string
                    new_string.Append(w);
                }

                else
                {
                    //Appending
                    new_string.Append(w.Substring(1));
                    new_string.Append(w[0]);
                }
                new_string.Append("maa");
                new_string.Append('a', j);
            }
            return new_string.ToString();
        }
        catch (Exception)
        {

            throw;
        }
    }

}

