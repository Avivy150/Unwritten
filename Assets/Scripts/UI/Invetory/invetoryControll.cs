using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class invetoryControll : MonoBehaviour
{
    public GameObject invetoryCon;
    public bool active = false;
    public equitmentWindow eWindow;
    // Use this for initialization
    void Start()
    {
        //makes the invetory frames invisable  
        invetoryCon.SetActive(false);
    }
	// Update is called once per frame
	void Update ()
    { 
        if (Input.GetKeyDown(KeyCode.I))
        {
            active = !active;
        }
        invetoryCon.SetActive(active);   
        if (!active)
        {
            eWindow.active = false;
        } 
    }  
    public void setEquip ()
    {
        eWindow.active = !eWindow.active;
    }
} 



















