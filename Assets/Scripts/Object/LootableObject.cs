using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootableObject : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = GameObject.FindObjectOfType(typeof(Player)) as Player;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "life")
        {
            player.GetLife();
            other.gameObject.SetActive(false);
            Debug.Log("can aldı");
        }

        if (other.transform.tag == "speed")
        {
            player.SpeedBoost();
            other.gameObject.SetActive(false);
            Debug.Log("hız aldı");
        }
    }
}
