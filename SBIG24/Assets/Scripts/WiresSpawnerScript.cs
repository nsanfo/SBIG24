using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresSpawnerScript : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public GameObject wiresSection;
    private bool canSpawn = false;

    private void Start() {
        spawn();
        canSpawn = false;
    }

    private void Update() {
        if (canSpawn)
        {
            spawn();
        }
    }

    private void spawn()
    {
        GameObject section = Instantiate(wiresSection, transform.position, Quaternion.identity);
        WireSectionScript wireSectionScript = section.GetComponent<WireSectionScript>();

        wireSectionScript.gameManagerScript = gameManagerScript;
        canSpawn = false;
    }

    private void OnTriggerExit(Collider other) {
        canSpawn = true;
    }
}