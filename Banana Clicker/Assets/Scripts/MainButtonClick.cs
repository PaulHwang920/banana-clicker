﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public UnityEngine.UI.Text bananaDisplay;
    public float bananas = 0.00f;
    public int bananaPerClick = 1;

    private void Update()
    {
        bananaDisplay.text = "Bananas: " + CurrencyConverter.Instance.GetCurrencyIntoString(bananas, false, false);
    }

    public void ClickButton()
    {
        bananas += bananaPerClick;
    }
}
