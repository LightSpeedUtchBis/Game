using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShipCoins : MonoBehaviour
{
    public int coins;
    public AudioSource coinFX;

    public void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Coin"){
            coins++;
            coinFX.Play();
            CollectableControl.coinCount += 1;
            //col.gameObject.SetActive(false);
            Destroy(col.gameObject);
        }
    }
}
