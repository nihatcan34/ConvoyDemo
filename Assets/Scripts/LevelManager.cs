using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public List<GameObject> levels = new List<GameObject>();
    public Sprite levelComp, levelLock;

    public void LevelComplete(int level)
    {
        levels[level].GetComponent<Image>().sprite = levelComp;
    }

    public void LevelSelect()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
