using UnityEngine;

public class ExitGame : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ExitGameNow()
    {
        Application.Quit();
    }
}
