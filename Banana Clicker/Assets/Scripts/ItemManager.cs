using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public UnityEngine.UI.Text itemInfo;
    public MainButtonClick click;

    public float cost;
    public int bananaPerSecond;
    public int count;
    public int achievementMultiplier;
    public string itemName;

    public Color standard;
    public Color affordable;

    private float baseCost;

    void Start()
    {
        baseCost = cost;
    }

    // Updates the display text for the click upgrade appropriately
    // Also highlights item when affordable
    void Update()
    {
        itemInfo.text = itemName + "\nBananas: " + bananaPerSecond + "/s" + "\nCost: " + cost;

        if (click.bananas >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
    }

    // What happens when an item is purchased
    public void purchaseItem()
    {
        // if affordable
        if (click.bananas >= cost)
        {
            click.bananas -= cost; // pay money
            count += 1; // get item
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count)); //increase cost
        }
    }
}
