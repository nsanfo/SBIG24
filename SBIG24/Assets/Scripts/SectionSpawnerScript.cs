using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionSpawnerScript : MonoBehaviour
{
    public GameObject Section;
    public GameManagerScript gameManagerScript;
    private bool canSpawn = false;

    private void Start() {
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
        Instantiate(Section, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 30), Quaternion.identity);
        canSpawn = false;
    }
}
