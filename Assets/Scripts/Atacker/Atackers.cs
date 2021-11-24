using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Atackers : MonoBehaviour
{
    public GameState gameState;
    public List<GameObject> carAtackerList = new List<GameObject>();
    public List<Transform> spawnAtackerCarPoint = new List<Transform>();
    List<GameObject> cars = new List<GameObject>();
    Transform position;

    public IEnumerator SpawnAtackerCar()
    {
        Destroy();
        for (int y = 0; y < 200; y++)
        {
            for (int i = 0; i < carAtackerList.Count(); i++)
            {
                var atacker_go = Instantiate(carAtackerList[i], spawnAtackerCarPoint[Random.Range(0, 6)]);
                cars.Add(atacker_go);
                atacker_go.AddComponent<AtackerCarControl>();
                atacker_go.GetComponent<AtackerCarControl>().speed = Random.Range(6f, 6f);
                yield return new WaitForSeconds(0.8f);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAtackerCar());
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void Destroy()
    {
        foreach(GameObject g in cars)
        {
            Destroy(g);
        }
        cars.Clear();
    }
}
