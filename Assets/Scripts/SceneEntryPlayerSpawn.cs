/*This Script Spawns the player when the scene starts*/

using UnityEngine;

public class SceneEntryPlayerSpawn : MonoBehaviour {

    public GameObject girl1, girl2, girl3, girl4, girl5, girl6, girl7, girl8;

    public GameObject SpawnPoint;
    private static Quaternion SpawnRotation = Quaternion.Euler(0, 0, 0);

    void Start () {
        SelectCharacter();
	}

    public void SelectCharacter()
    {
        switch (SelectedCharacter.SelectedCharacterId)
        {
            case 1:
                Instantiate(girl1, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 2:
                Instantiate(girl2, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 3:
                Instantiate(girl3, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 4:
                Instantiate(girl4, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 5:
                Instantiate(girl5, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 6:
                Instantiate(girl6, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 7:
                Instantiate(girl7, SpawnPoint.transform.position, SpawnRotation);
                break;
            case 8:
                Instantiate(girl8, SpawnPoint.transform.position, SpawnRotation);
                break;

        }
    }
}
