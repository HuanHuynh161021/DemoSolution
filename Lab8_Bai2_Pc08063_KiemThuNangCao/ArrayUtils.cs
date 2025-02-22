using System;

public class ArrayUtils
{
    public static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    public static int FindMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (var num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}
