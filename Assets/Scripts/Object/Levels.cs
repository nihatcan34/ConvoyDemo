using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public CarControlBasic carControl;
    public int level = 1;
    public GameObject[] road;
    public Text level_Text;
    public GameObject levelPanel;
    public Transform sinir;

    private void Start()
    {
        LevelText();
    }

    void LevelText()
    {
        level_Text.text = "LEVEL" + level.ToString();
    }
    public void LevelUp()
    {
        if(carControl.carSpeed <= 20f)
        {
            carControl.carSpeed = carControl.carSpeed + 5f;
        }
        level++;
        LevelText();
        StartCoroutine(EndlessRoad());
    }
    IEnumerator EndlessRoad()
    {
        yield return new WaitForSeconds(1f);

        road[0].transform.position = new Vector3(road[0].transform.position.x, road[0].transform.position.y, road[0].transform.position.z + 446f);
        GameObject g = road[0];
        road[0] = road[1];
        road[1] = g;
        sinir.position = new Vector3(sinir.position.x, sinir.position.y, sinir.position.z + 223f);
    }
}
