using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresSpawnerScript : MonoBehaviour
{
    //Distance of the spawner from the screen, farther is harder to see 
    public int distanceFromScreen;

    public GameObject wireSection;

    //length of the wires
    private int wireLength = 50;

    //How many wires to spawn
    public int numWires;

    //How fast the wires approach the player
    public int WireSpeed;

    //If the wires can be spawned or not
    private bool canSpawn = false;
    
    
    private void Start() {
        //move spawner far from player
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + ((wireLength/2) * distanceFromScreen));

        //Set numeber of wires to spawn, and their speed to go
        wireSection.GetComponent<WireSectionScript>().NumOfWires = numWires;
        wireSection.GetComponent<WireSectionScript>().MovementSpeed = WireSpeed;

        //Spawn The section of wires
        spawnSection();
    }

    private void Update() {
        //if it can be spawned, spawn it and set it to false
        if (canSpawn)
        {
            spawnSection();
            canSpawn = false;
        }
    }

    //if something leaves the trigger collider, spawn another wire section.
    private void OnTriggerExit(Collider other) {
        canSpawn = true;
    }

    //instantiate a wire section game object.
    private void spawnSection()
    {
        Instantiate(wireSection, transform.position, Quaternion.identity);
    }
}
