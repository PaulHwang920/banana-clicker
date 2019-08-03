using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public MainButtonClick click;
    public UnityEngine.UI.Text itemLevel;
    public float cost;
    public int count = 1;
    public int clickPower;
    public Color standard;
    public Color affordable;
    private float baseCost;

    private void Start()
    {
        baseCost = cost;
    }

    void Update()
    {
        itemLevel.text = "Click Upgrade\nLevel: " + count + "\nCost: " + cost;

        if (click.bananas >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
    }

    public void purchaseUpgrade()
    {
        if (click.bananas >= cost)
        {
            click.bananas -= cost;
            count += 1;
            click.bananaPerClick += clickPower;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
            
        }
    }
}
