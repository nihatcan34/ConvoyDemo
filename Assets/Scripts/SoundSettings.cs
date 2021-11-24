using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public GameObject sound_Button;
    public Sprite mute, unmute;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void SoundOnOff()
    {
        if (this.GetComponent<AudioSource>().mute == false)
        {
            this.GetComponent<AudioSource>().mute = true;
            sound_Button.GetComponent<Image>().sprite = mute;
        }
        else
        {
            this.GetComponent<AudioSource>().mute = false;
            sound_Button.GetComponent<Image>().sprite = unmute;
        }
            
    }
}
