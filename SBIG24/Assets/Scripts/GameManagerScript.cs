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
    
    //Global Distance of spawner from the screen
    public int SpawnerDistanceFromScreen = 5;

    public GameObject Player;
    public GameObject WireSpawner;

    void Start()
    {
        //Set Attributes of Player
        Player.GetComponent<PlayerMovement>().NumWires = NumOfWires;
        Player.GetComponent<PlayerMovement>().WireSpacing = WireSpacing;

        //Set Attributes of Wire Spawner
        WireSpawner.GetComponent<WiresSpawnerScript>().distanceFromScreen = SpawnerDistanceFromScreen;
        WireSpawner.GetComponent<WiresSpawnerScript>().numWires = NumOfWires;
        WireSpawner.GetComponent<WiresSpawnerScript>().WireSpeed = Speed;
    }
}
