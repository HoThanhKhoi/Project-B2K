using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField] private float baseValue;
    public List<float> modifiers;

    public float GetValue()
    {
        float finalValue = baseValue;

        foreach (var modifier in modifiers)
        {
            finalValue += modifier;
        }

        return finalValue;
    }

    public void Add(float value)
    {
        modifiers.Add(value);
    }

    public void Remove(float value)
    {
        modifiers.Remove(value);
    }
}
