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
        bpsDisplay.text = getBananaPerSec() + " bananas/sec";
    }

    public int getBananaPerSec()
    {
        int tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.bananaPerSecond;
        }
        return tick;
    }

    public void autoBananaPerSec()
    {
        click.bananas += getBananaPerSec();
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            autoBananaPerSec();
            yield return new WaitForSeconds(1);
        }
    }
}
