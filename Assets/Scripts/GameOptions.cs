using UnityEngine;
using System.Collections;

public class GameOptions : MonoBehaviour {

    private AudioSource ThemeSong;
    private UIToggle SoundToggle;
    public GameObject SoundCheckbox;

    public float SoundVolume;

    
	void Start () {
        SoundToggle = SoundCheckbox.GetComponent<UIToggle>();
        SoundToggle.value = true;

        ThemeSong = GetComponent<AudioSource>();
        ThemeSong.volume = SoundVolume;
        }

    public void OnToggle()
    {
        if(SoundToggle.value == true)
        {
            SoundVolume = 1;
            ThemeSong.volume = SoundVolume;
        }
        if(SoundToggle.value == false)
        {
            SoundVolume = 0;
            ThemeSong.volume = SoundVolume;
        }
    }


}
