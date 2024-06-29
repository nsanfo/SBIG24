using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSectionScript : MonoBehaviour
{
    //Gap Between the wires
    private int WireGap = 2;

    //Number of wires to the left or right of middle wire
    private int numLR;

    public GameObject WireObj;

    //Number of Wires to spawn
    public int NumOfWires = 3;

    //Speed of the wires going towards player
    public int MovementSpeed = 40;
    
    private void Start()
    {
        //Calculate numLR
        numLR = NumOfWires/2;

        //for each wire...
        for (int i = -numLR; i <= numLR; i++)
        {
            //Instantiate a new wire object at appropriate position.
            GameObject wireObj = Instantiate(WireObj, new Vector3(i * WireGap, transform.position.y, transform.position.z), Quaternion.identity, this.transform);
        }
    }

    private void Update() {
        //Move Towards player
        transform.position += -transform.forward * MovementSpeed * Time.deltaTime;
    }
}
