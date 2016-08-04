using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	void Start ()
    {
	
	}

	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Application.Quit();
            //SceneManager.LoadScene(0);
        }
    }
}
