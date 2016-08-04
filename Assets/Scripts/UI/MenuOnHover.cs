using UnityEngine;
using System.Collections;

public class MenuOnHover : MonoBehaviour {

    private Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void OnHover(bool hovering)
    {
        if (hovering)
        {
            anim.SetTrigger("hovered");
        }
    }
}
