using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public UnityEngine.UI.Text itemInfo;
    public MainButtonClick click;
    public float cost;
    public int bananaPerSecond;
    public int count;
    public string itemName;
    private float baseCost;

    void Start()
    {
        baseCost = cost;
    }

    void Update()
    {
        itemInfo.text = itemName + "\nBananas: " + bananaPerSecond + "/s" + "\nCost: " + cost;
    }

    public void purchaseItem()
    {
        if (click.bananas >= cost)
        {
            click.bananas -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }
}
