using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 1f;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void UpdateValueLimitZero(float amt)
    {
        if (value <= 0)
        {
            UpdateValue(amt);
        }
    }

    public void UpdateValueLimitZeroAndMaz(float amt)
    {
        if (value >= 0 && value <= maxValue)
        {
            UpdateValue(amt);
        }
    }
}
