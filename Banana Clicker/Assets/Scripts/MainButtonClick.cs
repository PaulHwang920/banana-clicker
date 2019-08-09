using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public UnityEngine.UI.Text bananaDisplay;

    public float bananas = 0.00f;
    public int bananaPerClick = 1;

    // Updates total bananas
    private void Update()
    {
        bananaDisplay.text = "Bananas: " + CurrencyConverter.Instance.GetCurrencyIntoString(bananas, false, false);
    }

    // When clicking, increased total bananas
    public void ClickButton()
    {
        bananas += bananaPerClick;
    }
}
