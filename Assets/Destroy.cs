using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool activateDestroyAtacker = false;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("atacker yok et aktif");
            activateDestroyAtacker = true;
        }

        if(activateDestroyAtacker == true)
        {
            if (other.transform.tag == "enemy")
            {
                Destroy(other.gameObject);
                Debug.Log("yok edildi" + other.name);
            }
        }
    }
}
