using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
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
    public float MovementSpeed = 0.01f;
    
    private void Start()
    {
        numLR = NumOfWires/2;

        for (int i = -numLR; i <= numLR; i++)
        {
            GameObject wireObj = Instantiate(WireObj, new Vector3(i * WireGap, transform.position.y, transform.position.z), Quaternion.identity, this.transform);
        }
    }

    private void Update() {
        //Move 
        transform.position += -transform.forward * MovementSpeed * Time.deltaTime;
    }
}
