using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaPerSec : MonoBehaviour
{

    public UnityEngine.UI.Text bpsDisplay;

    public MainButtonClick click;
    public ItemManager[] items;
    public AchievementManager[] achievements;
    public UpgradeManager clicker;

    private void Start()
    {
        StartCoroutine(AutoTick());
    }

    // Updates the banana count with correct values
    private void Update()
    {
        bpsDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(getBananaPerSec(), false, false) + " bananas/sec";
    }

    public float getBananaPerSec()
    {
        float tick = 0;
        float monkeyMultiplier = 0.0f;
        float farmerMultiplier = 0.0f;
        float engineerMultiplier = 0.0f;
        float minerMultiplier = 0.0f;
        float wizardMultiplier = 0.0f;
        float astronautMultiplier = 0.0f;
        // managing item multipliers
        foreach (AchievementManager achieve in achievements) {
            if (achieve.itemName == "Lots and lots of Monkeys")
            {
                monkeyMultiplier = Mathf.Pow(2, achieve.count);
            }
            if (achieve.itemName == "Advanced Monkey Farmers")
            {
                farmerMultiplier = Mathf.Pow(2, achieve.count);
            }
            if (achieve.itemName == "Engineer Bot 5000")
            {
                engineerMultiplier = Mathf.Pow(2, achieve.count);
            }
            if (achieve.itemName == "Dual Pickaxe Frenzy")
            {
                minerMultiplier = Mathf.Pow(2, achieve.count);
            }
            if (achieve.itemName == "Magical Wizardry of Wizards")
            {
                wizardMultiplier = Mathf.Pow(2, achieve.count);
            }
            if (achieve.itemName == "Apollo 11")
            {
                astronautMultiplier = Mathf.Pow(2, achieve.count);
            }
        }
        // calculating total generation per item
        foreach(ItemManager item in items)
        {
            if (item.itemName == "Monkey")
            {
                tick += item.count * (item.bananaPerSecond * monkeyMultiplier);
            }
            if(item.itemName == "Monkey Farmer")
            {
                tick += item.count * (item.bananaPerSecond * farmerMultiplier);
            }
            if (item.itemName == "Monkey Engineer")
            {
                tick += item.count * (item.bananaPerSecond * engineerMultiplier);
            }
            if (item.itemName == "Monkey Miner")
            {
                tick += item.count * (item.bananaPerSecond * minerMultiplier);
            }
            if (item.itemName == "Monkey Wizard")
            {
                tick += item.count * (item.bananaPerSecond * wizardMultiplier);
            }
            if (item.itemName == "Monkey Astronaut")
            {
                tick += item.count * (item.bananaPerSecond * astronautMultiplier);
            }
        }
        return tick;
    }

    // Adding 1/10 of total generation amount to total count of bananas
    public void autoBananaPerSec()
    {
        click.bananas += getBananaPerSec() / 10;
    }

    // every 1/10th of a second add 1/10 of total generation
    IEnumerator AutoTick()
    {
        while (true)
        {
            autoBananaPerSec();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
