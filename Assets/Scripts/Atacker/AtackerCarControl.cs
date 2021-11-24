using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AtackerCarControl : MonoBehaviour
{
    public float speed = 5.5f;
    Player player;
    Convoy convoy;
    private void Awake()
    {
        player = GameObject.FindObjectOfType(typeof(Player)) as Player;
        convoy = GameObject.FindObjectOfType(typeof(Convoy)) as Convoy;
    }

    void Accelerate()
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "guard")
        {
            Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
        }

        if(collision.transform.tag == "Player")
        {
            Destroy(this.gameObject);
            player.HitPlayer();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(player.gameState.state == "start")
        {
            Accelerate();
        }
    }
}
