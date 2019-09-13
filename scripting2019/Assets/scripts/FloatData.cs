using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 20f;

    public void UpdateValue(float amt)
    {
        value += amt;
    }

    public void UpdateValueLimitZero(float amt)
    {
        if (value < 0)
        {
            value = 0;
        }
        else
        {
            UpdateValue(amt);
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amt)
    {
        if (value < maxValue)
        {
            UpdateValue(amt);
        }
        else
        {
            value = maxValue;
        }
        UpdateValueLimitZero(amt);
    }
}
