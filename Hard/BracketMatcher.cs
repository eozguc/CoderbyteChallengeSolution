using System;
using System.Collections.Generic;

namespace Medium;

public class BracketMatcher
{
    public static string BracketMatcher(string str) {

        // code goes here  
        //return str;
        
        List<char> stack = new List<char>();
        int countOpenBrackets = 0;
        int countCloseBrackets = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                stack.Add(str[i]);
                countOpenBrackets++;
                continue;
            }

            if (str[i] == ')')
            {
                int currentCount = stack.Count;
                if (currentCount != 0)
                    stack.RemoveAt(currentCount - 1);

                countCloseBrackets++;
                continue;
            }
        }

        if (countOpenBrackets == countCloseBrackets && stack.Count == 0)
            return "1";
        // code goes here  
        //return str;
        return "0";

    }

    static void Main() {  
        // keep this function call here
        Console.WriteLine(BracketMatcher(Console.ReadLine()));
    } 

}