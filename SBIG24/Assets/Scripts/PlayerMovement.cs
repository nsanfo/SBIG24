using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Which wire the player is on, initialized at 0(Middle).
        //-1 = Left
        //1 = Right
    private int PlayerPos = 0;
    
    //Number of wires in the level
        //Mutable in Editor
    public int NumWires = 3;
    
    //Space between the wires
        //Mutable in Editor
    public int WireSpacing = 2;

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
        if (PlayerPos > -(NumWires/2))
        {
            //Move player 2 units to the left on the x axis.
            gameObject.transform.position = new Vector3(transform.position.x - WireSpacing, transform.position.y, transform.position.z);

            //Update player position by decrementing by 1
            PlayerPos -= 1;
        }
    }
    void GoRight()
    {
        //If the position is not at the last possible right wire...
        if (PlayerPos < (NumWires/2))
        {
            //Move player 2 units to the right on the x axis.
            gameObject.transform.position = new Vector3(transform.position.x + WireSpacing, transform.position.y, transform.position.z);

            //Update player position by incrementing by 1
            PlayerPos += 1;
        }
    }
}
