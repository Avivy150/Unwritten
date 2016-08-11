using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOptions : MonoBehaviour {

    private AudioSource themeSong;
    private UIToggle soundToggle;
    public GameObject soundCheckbox;
    public UIToggle fullscreenToggle;
    public Dropdown resolutionDropdown;

    public float SoundVolume;

    
	void Start () {
        soundToggle = soundCheckbox.GetComponent<UIToggle>();
        soundToggle.value = true;

        themeSong = GetComponent<AudioSource>();
        themeSong.volume = SoundVolume;
        }

    public void ToggleSound()
    {
        if (soundToggle.value == true)
        {
            SoundVolume = 1;
            themeSong.volume = SoundVolume;
        }
        if (soundToggle.value == false)
        {
            SoundVolume = 0;
            themeSong.volume = SoundVolume;
        }
    }

    public void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    //public void ChangeResolution()
    //{
    //    if (resolutionDropdown.value == 0)
    //        Screen.SetResolution(1024, 576, Screen.fullScreen);
    //    if (resolutionDropdown.value == 1)
    //        Screen.SetResolution(1280, 720, Screen.fullScreen);
    //    if (resolutionDropdown.value == 2)
    //        Screen.SetResolution(1600, 900, Screen.fullScreen);
    //    if (resolutionDropdown.value == 3)
    //        Screen.SetResolution(1920, 1080, Screen.fullScreen);
    //}
}

