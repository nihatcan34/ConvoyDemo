using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Convoy : MonoBehaviour
{
    public GameObject guardCarPrefab;
    public List<GameObject> guards = new List<GameObject>();
    public List<Transform> spawnpoints = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < guards.Count();i++)
        {
            GameObject guard_go = Instantiate(guardCarPrefab, spawnpoints[i].transform);
            guards[i] = guard_go;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
