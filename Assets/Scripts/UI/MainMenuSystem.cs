using UnityEngine;
/* Main Menu Interface Controller Script.
The events from the interface are being sent to this script.
It disables/enables parts of the UI when needed.*/

public class MainMenuSystem : MonoBehaviour {

    public GameObject MainMenuRoot, MainPanel, CharacterSelectionRoot, OptionsRoot, CreditsRoot;

	public void OnNewGameClick()
    {
        MainMenuRoot.SetActive(false);
        MainPanel.SetActive(false);
        CharacterSelectionRoot.SetActive(true);
    }
    public void OnNewGameBackClick()
    {
        MainMenuRoot.SetActive(true);
        MainPanel.SetActive(true);
        CharacterSelectionRoot.SetActive(false);
    }
    public void OnContinueClick()
    {
        //nothing here...
    }
    public void OnOptionsClick()
    {
        MainMenuRoot.SetActive(false);
        OptionsRoot.SetActive(true);
    }
    public void OnOptionsBackClick()
    {
        MainMenuRoot.SetActive(true);
        OptionsRoot.SetActive(false);
    }
    public void OnCreditsClick()
    {
        MainMenuRoot.SetActive(false);
        CreditsRoot.SetActive(true);
    }
    public void OnCreditsBackClick()
    {
        MainMenuRoot.SetActive(true);
        CreditsRoot.SetActive(false);
    }
    public void OnExitClick()
    {
        Application.Quit();
    }
}
