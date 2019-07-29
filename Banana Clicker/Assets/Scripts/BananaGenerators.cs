using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaGenerators : MonoBehaviour
{
    public int price;
    public int earnRate;
    public int numGenerator;
    public bool makingBananas;

    public BananaGenerators()
    {
        numGenerator = 1;
    }

    public void buyGenerator(BananaGenerators generator)
    {
        generator.price *= 2;
        generator.numGenerator++;
        earnRate = generator.numGenerator * earnRate;
    }

    public void sellGenerator(BananaGenerators generator)
    {
        generator.price /= 2;
        generator.numGenerator--;
        earnRate = generator.numGenerator * earnRate;
    }

    internal IEnumerator MakeBananas (float seconds)
    {
        GlobalBananas.bananaCount += this.earnRate;
        yield return new WaitForSeconds(seconds);
        makingBananas = false;
    }

    public class Monkey : BananaGenerators
    {

        public Monkey() : base()
        {
            price = 10;
            earnRate = 1;
            numGenerator = 1;
        }
    }

    class MonkeyFarmer : BananaGenerators
    {
        public MonkeyFarmer() : base()
        {
            price = 20;
            earnRate = 1;
            numGenerator = 1;
        }
    }
}
