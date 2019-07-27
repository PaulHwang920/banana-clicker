using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBananas : MonoBehaviour
{
    public static int bananaCount;
    public GameObject bananaDisplay;
    public int internalBanana;

    private void Update()
    {
        internalBanana = bananaCount;
        bananaDisplay.GetComponent<Text>().text = "Bananas: " + internalBanana;
    }
}
