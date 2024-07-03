using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public Animator animator;
    private int PlayerPos = 0;
    private PlayerControls playerControls;

    private void Start() {
        playerControls = new PlayerControls();
    }

    private void OnMoveLeft()
    {
        if (PlayerPos > -(gameManagerScript.NumOfWires/2))
        {
            gameObject.transform.position = new Vector3(transform.position.x - gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            PlayerPos -= 1;
        }
    }
    private void OnMoveRight()
    {
        if (PlayerPos < (gameManagerScript.NumOfWires/2))
        {
            gameObject.transform.position = new Vector3(transform.position.x + gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            PlayerPos += 1;
        }
    }
}
