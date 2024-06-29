using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresSpawnerScript : MonoBehaviour
{
    public int distanceFromScreen;
    public GameObject wireSection;
    private int wireLength = 50;
    private bool canSpawn = false;
    
    
    private void Start() {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + ((wireLength/2) * distanceFromScreen));

        spawnSection();
    }

    private void Update() {
        if (canSpawn)
        {
            spawnSection();
            canSpawn = false;
        }
    }

    private void OnTriggerExit(Collider other) {
        canSpawn = true;
    }

    private void spawnSection()
    {
        Instantiate(wireSection, transform.position, Quaternion.identity);
    }
}
