/* It's a class for holding SelectedCharacterId variable, as the scene changes*/

using UnityEngine;

public class SelectedCharacter : MonoBehaviour {

    public static int SelectedCharacterId;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
