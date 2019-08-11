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
    private float[] engineerCosts;
    private float[] minerCosts;
    private float[] wizardCosts;
    private float[] astronautCosts;

    void Start()
    {
        baseCost = cost;
        monkeyCosts = new float[]{ 1000f, 10000f, 100000f, 5000000f, 100000000f, 800000000000f };
        farmerCosts = new float[] { 5000f, 50000f, 500000f, 25000000f, 500000000f, 4000000000000f };
        engineerCosts = new float[] { 11000f, 55000f, 550000f, 55000000f, 550000000f, 5500000000000f };
        minerCosts = new float[] { 120000f, 600000f, 6000000f, 600000000f, 500000000f, 60000000000000f };
        wizardCosts = new float[] { 1300000f, 6500000f, 65000000f, 6500000000f, 650000000000f, 65000000000000f };
        astronautCosts = new float[] { 14000000f, 70000000f, 700000000f, 70000000000f, 7000000000000f, 700000000000000f };
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
            if (itemName == "Engineer Bot 5000")
            {
                cost = engineerCosts[count]; // increase cost
            }
            if (itemName == "Dual Pickaxe Frenzy")
            {
                cost = minerCosts[count]; // increase cost
            }
            if (itemName == "Monkey Wizard")
            {
                cost = wizardCosts[count]; // increase cost
            }
            if (itemName == "Monkey Astronaut")
            {
                cost = astronautCosts[count]; // increase cost
            }
        }
    }
}
