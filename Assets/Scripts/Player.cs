using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public CarControlBasic carControl;
    public GameState gameState;
    public Convoy convoy;
    public Sprite heart, gryHeart;
    public List<Image> lifes = new List<Image>();
    public GameObject player;
    int life = 2;


    public void HitPlayer()
    {
        if (life > 0)
        {
            life--;
            lifes[life].sprite = gryHeart;
            Debug.Log("Can " + life);
        }
        
        if (life == 0)
        {
            GameObject.FindWithTag("Player").SetActive(false);
            gameState.state = "break";
        }
    }

    public void SpeedBoost()
    {
        if(carControl.carSpeed <= 24f)
        {
            carControl.carSpeed = carControl.carSpeed + 2f;
        }  
    }

    public void GetLife()
    {
        if (life < 2)
        {
            lifes[life].sprite = heart;
            life++;
        }
        else
        {
            foreach(GameObject g in convoy.guards)
            {
                if (!g.transform.gameObject.active)
                {
                    g.SetActive(true);
                }
                else
                {
                    Debug.Log("Tüm korumalar Aktif");
                }
            }
        }
    }
}
