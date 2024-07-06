using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionSpawnerScript : MonoBehaviour
{
    public GameObject Section;
    public GameManagerScript gameManagerScript;
    private bool canSpawn = false;

    private void Start() {
        spawnSection();
    }
    private void Update() {
        if (canSpawn){
            spawnSection();
        }
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log(other.transform.name);
        if (other.transform.tag == "Section"){
            canSpawn = true;
        }
    }
    

    private void spawnSection(){
        Instantiate(Section, transform.position, Quaternion.identity);
        canSpawn = false;
    }
}
