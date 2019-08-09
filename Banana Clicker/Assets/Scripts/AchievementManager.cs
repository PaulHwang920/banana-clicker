using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public UnityEngine.UI.Text itemInfo;
    public MainButtonClick click;
    public float cost;
    public int count;
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
        itemInfo.text = itemName + "\nCost: " + cost;

        if (click.bananas >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
    }

    // what happens when achievement is purchased
    public void purchaseAchievement()
    {
        // if affordable
        if (click.bananas >= cost)
        {
            click.bananas -= cost; // pay money
            count += 1; // get achievement
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count)); // increase cost
        }
    }
}
