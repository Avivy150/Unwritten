using UnityEngine;
using UnityEngine.UI;

public class ChangeUIColorOnEnter : MonoBehaviour
{
    public Text text;
    public Color colorOnEnter;
    public Color colorOnExit;

    public void OnEnter()
    {
        text.color = colorOnEnter;
    }

    public void OnExit()
    {
        text.color = colorOnExit;
    }
}
