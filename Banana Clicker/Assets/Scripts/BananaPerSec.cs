using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaPerSec : MonoBehaviour
{

    public UnityEngine.UI.Text bpsDisplay;
    public MainButtonClick click;
    public ItemManager[] items;

    private void Start()
    {
        StartCoroutine(AutoTick());
    }

    private void Update()
    {
        bpsDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(getBananaPerSec(), false, false) + " bananas/sec";
    }

    public float getBananaPerSec()
    {
        float tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.bananaPerSecond;
        }
        return tick;
    }

    public void autoBananaPerSec()
    {
        click.bananas += getBananaPerSec() / 10;
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            autoBananaPerSec();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
