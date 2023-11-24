using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers
{
}

[System.Serializable]
public struct CurrentMax
{
    public int current;
    public int max;

    public void Add(int value)
    {
        current += value;
        if (current > max)
            current = max;
    }

    public void Reduce(int value)
    {
        current -= value;
        if (current < 0)
            current = 0;
    }
}