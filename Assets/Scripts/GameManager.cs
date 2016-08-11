using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject inventoryCamera;
    public GameObject weaponsCamera;

    void Start ()
    {
        mainCamera = GameObject.Find("Main Camera");
        inventoryCamera = GameObject.Find("Inventory Camera");
        weaponsCamera = GameObject.Find("Weapons Camera");
    }

	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.I))
        {
            mainCamera.GetComponent<Camera>().enabled = false;
            mainCamera.GetComponent<AudioListener>().enabled = false;
            weaponsCamera.GetComponent<Camera>().enabled = false;
            weaponsCamera.GetComponent<AudioListener>().enabled = false;
            inventoryCamera.GetComponent<Camera>().enabled = true;
            inventoryCamera.GetComponent<AudioListener>().enabled = true;
        }

        if (Input.GetKey(KeyCode.U))
        {
            mainCamera.GetComponent<Camera>().enabled = false;
            mainCamera.GetComponent<AudioListener>().enabled = false;
            inventoryCamera.GetComponent<Camera>().enabled = false;
            inventoryCamera.GetComponent<AudioListener>().enabled = false;
            weaponsCamera.GetComponent<Camera>().enabled = true;
            weaponsCamera.GetComponent<AudioListener>().enabled = true;
        }
    }
}
