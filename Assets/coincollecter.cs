using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincollecter : MonoBehaviour
{
    public int COINS = 0;

    public TextMeshProUGUI coinText;
    
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected");
            COINS += 1;
            coinText.text = "Coin: " + COINS.ToString();
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }
}
