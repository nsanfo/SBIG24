using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteWireSpawn : MonoBehaviour
{
    private int WireGap = 2;
    private int numLR;

    public GameObject WireObj;

    public int NumOfWires = 3;
    public int WireDespawnDistance = 2;
    public int WireSpawnDistance = 2;
    public int pos = 0;
    public int MovementSpeed = 2;
    
    private void Start()
    {
        numLR = NumOfWires/2;

        for (int i = -numLR; i <= numLR; i++)
        {
            Instantiate(WireObj, new Vector3(i * WireGap, transform.position.y, transform.position.z), Quaternion.identity);
        }

    }

    private void LayDownSection()
    {

    }
}
