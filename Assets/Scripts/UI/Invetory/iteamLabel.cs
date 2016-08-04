using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class iteamLabel : MonoBehaviour
{

    public Text thisText;
    public equitmentWindow eWindow;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "mouse")
        {
            eWindow.iteamScrolled(thisText);
        }
    }
}
