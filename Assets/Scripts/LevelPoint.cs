using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPoint : MonoBehaviour
{
    public Levels levels;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Level Up");
            levels.LevelUp();
        }
    }
}
