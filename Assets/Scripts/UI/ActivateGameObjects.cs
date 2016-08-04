using UnityEngine;

public class ActivateGameObjects : MonoBehaviour
{
    public GameObject toDeactivate;
    public GameObject toActivate;

    public void ActivateDeactivate()
    {
        toDeactivate.SetActive(false);
        toActivate.SetActive(true);
    }

    public void MouseEnterExit()
    {
        if (toDeactivate == toDeactivate.activeSelf)
        {
            toDeactivate.SetActive(false);
        }
        else if (toDeactivate != toDeactivate.activeSelf)
        {
            toDeactivate.SetActive(true);
        }

        if (toActivate == toActivate.activeSelf)
        {
            toActivate.SetActive(false);
        }
        else if (toActivate != toActivate.activeSelf)
        {
            toActivate.SetActive(true);
        }
    }
}
