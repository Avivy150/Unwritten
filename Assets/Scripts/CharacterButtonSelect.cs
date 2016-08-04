/* This class is attached on the selectable girls and returns a proper value when OnClick() function is called. Then it loads the level */

using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterButtonSelect : MonoBehaviour {

    public int CharacterId;

    public int levelnum;

    public void OnClick()
    {
        Debug.Log("Clicked!");
        SelectedCharacter.SelectedCharacterId = CharacterId;
        SceneManager.LoadScene(levelnum);
    }
}
