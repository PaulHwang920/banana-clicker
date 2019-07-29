using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGenerator : MonoBehaviour
{
    public GameObject AutoBanana;

    public void StartMakingBananas()
    {
        AutoBanana.SetActive(true);
    }
}
