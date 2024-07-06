using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //Global Wire Speed
    public int Speed = 40;

    //Global Number of Wires
    public int NumOfWires = 3;

    //Global Spacing Between Wires
    public int WireSpacing = 2;

    public int jumpHeight;
    public float jumpSpeed = 2f;
    public float airTime = 0.1f;

    public float clearWireChance = 0.5f;
    public float obstacleChance = 0.3f;
    public float whichObstacleChance = 0.5f;
    public float pointInterval = 1.0f;
}
