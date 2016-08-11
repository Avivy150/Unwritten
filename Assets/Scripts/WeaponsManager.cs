using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponsManager : MonoBehaviour {

    public GameObject weaponList;
    public GameObject weaponDisplay;

	// Use this for initialization
	void Start ()
    {
        weaponList = GameObject.Find("WeaponsList");
        weaponDisplay = GameObject.Find("WeaponDisplay Image");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void ChangeWeaponDisplayImage()
    {
        Debug.Log("Clicked");
        Sprite image = Resources.Load<Sprite>("starterdagger");
        weaponDisplay.GetComponent<Image>().sprite = image;
    }
}
