using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public void LoadNextSceneIndex ()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1); 
   
    }
}
