using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    //Which wire the player is on, initialized at 0(Middle).
        //-1 = Left
        //1 = Right
    private int PlayerPos = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            GoLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            GoRight();
        }
    }

    void GoLeft()
    {
        //If the position is not at the last possible left wire...
        if (PlayerPos > -(gameManagerScript.NumOfWires/2))
        {
            //Move player 2 units to the left on the x axis.
            gameObject.transform.position = new Vector3(transform.position.x - gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            //Update player position by decrementing by 1
            PlayerPos -= 1;
        }
    }
    void GoRight()
    {
        //If the position is not at the last possible right wire...
        if (PlayerPos < (gameManagerScript.NumOfWires/2))
        {
            //Move player 2 units to the right on the x axis.
            gameObject.transform.position = new Vector3(transform.position.x + gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            //Update player position by incrementing by 1
            PlayerPos += 1;
        }
    }
}
