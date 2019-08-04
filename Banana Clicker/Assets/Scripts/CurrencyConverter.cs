using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyConverter : MonoBehaviour
{
    private static CurrencyConverter instance;
    public static CurrencyConverter Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        CreateInstance();
    }

    void CreateInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick)
    {
        string converted;
        if (valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000f).ToString("F3") + "Mil";
        }
        else if (valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000f).ToString("F3") + "K";
        }
        else
        {
            converted = "" + valueToConvert.ToString("F0");
        }

        if (currencyPerSec == true)
        {
            converted = converted + "banana/sec";
        }

        if (currencyPerClick == true)
        {
            converted = converted + "banana/click";
        }
        return converted;
    }

}
