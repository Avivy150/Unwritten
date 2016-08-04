using UnityEngine;
using System.Collections;

public class yelllowDress : MonoBehaviour
{

    public PlayerInput player;
    
    bool up;
    bool down;
    bool right;
    bool left;
    Vector3 playerPos;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        up = player.up;
        down = player.down;
        right = player.right;
        left = player.left;
        playerPos = player.position;

        transform.position = playerPos;
        transform.position += new Vector3(0f,0f,-04f);
	}
}
 




















