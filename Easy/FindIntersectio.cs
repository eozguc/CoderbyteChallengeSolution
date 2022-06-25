using System;
using System.Collections.Generic;

namespace Code;

public class FindIntersectio
{
    public static List<string> FindIntersection(string[] strArr)
    {
        List<string> result = new List<string>() { "false" };

        List<string> intersectionValues = new List<string>();

        string[] valuesOfFirstElement = strArr[0].Split(",");
        string[] valuesOfSecondElement = strArr[1].Split(",");

        foreach (string item in valuesOfFirstElement)
        {
            foreach (string element in valuesOfSecondElement)
            {
                if (item == element)
                    intersectionValues.Add(element);
            }
        }

        if (intersectionValues.Count != 0)
            result = intersectionValues;

        return result;
    }

    static void Main()
    {
        List<string> result = FindIntersection(Console.ReadLine());

        int length = result.Count;

        for (int i = 0; i < length; i++)
        {
            Console.Write(result[i]);
            if (i != (length - 1))
                Console.Write(",");
        }
    }
}