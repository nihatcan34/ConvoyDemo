using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    List<Color> colors = new List<Color>();

    // Start is called before the first frame update
    void Start()
    {
        colors.Add(Color.black);
        colors.Add(Color.white);
        colors.Add(Color.red);

        StartCoroutine(TextColorChange());
    }

    private IEnumerator TextColorChange()
    {
        while (true)
        {
            foreach (Color color in colors)
            {
                this.gameObject.GetComponent<TextMeshProUGUI>().color = color;
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
