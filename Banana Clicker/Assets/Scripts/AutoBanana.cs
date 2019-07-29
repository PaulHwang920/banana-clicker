using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBanana : MonoBehaviour
{
    public BananaGenerators generator;

    private void Start()
    {
        generator = new BananaGenerators.Monkey();
    }

    void Update()
    {
        if (generator.makingBananas == false)
        {
            generator.makingBananas = true;
            StartCoroutine(generator.MakeBananas(1));
        }
    }
}
