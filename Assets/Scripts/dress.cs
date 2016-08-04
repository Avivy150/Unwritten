using UnityEngine;
using System.Collections;

public class dress : MonoBehaviour
{

    public PlayerInput player;
    public string Dress;

    public Sprite yellowDressUp;
    public Sprite yellowDressDown;
    public Sprite yellowDressRight;
    public Sprite yellowDressLeft;

    bool up;
    bool down;
    bool right;
    bool left;
    string dressType;

    SpriteRenderer sprite;

    // Use this for initialization
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        up = player.up;
        down = player.down;
        right = player.right;
        left = player.left;
        transform.position = player.position + new Vector3(/*19.71*/ 0f, 0f, 2f);

        if (up)
        {
            sprite.sprite = yellowDressUp;
            sprite.flipX = false;
        }
        else if (down)
        {
            sprite.sprite = yellowDressDown;
            sprite.flipX = false;
        }
        else if (right)
        {
            sprite.sprite = yellowDressRight;
            sprite.flipX = false;
        }
        else if (left)
        {
            sprite.sprite = yellowDressLeft;
            sprite.flipX = true;
        }else
        {
            return;
        }
    } 
    public void setDressType (string dressType)
    {
        this.dressType = dressType;
    }
}
