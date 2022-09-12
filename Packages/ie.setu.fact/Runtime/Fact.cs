using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Name: Fact
//Replace each number by its factorial.
//Sample Input: 4 2 8 3 9 4 10
//Sample Output: 24 2 40320 6 362880 24 3628800

public class Fact : MonoBehaviour
{
    public static int factor(int x)
    {
        int sum = 1;

        for (int i = 1; i <= x; i++)
        {
            sum *= i;
        }

        return sum;
    }

    public static int[] outputFact(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = factor(xs[i]);
        }
        return result;
    }
}
