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
    private float[] monkeyCosts;
    private float[] farmerCosts;

    void Start()
    {
        baseCost = cost;
        monkeyCosts = new float[]{ 1000f, 10000f, 100000, 5000000, 100000000f, 800000000000f };
        farmerCosts = new float[] { 5000f, 50000f, 500000, 25000000, 500000000f, 4000000000000f };
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
            if (itemName == "Lots and lots of Monkeys")
            {
                cost = monkeyCosts[count]; // increase cost
            }
            if (itemName == "Advanced Monkey Farmers")
            {
                cost = farmerCosts[count]; // increase cost
            }
        }
    }
}
