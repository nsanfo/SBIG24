using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireDespawnScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Wire(Clone)" || other.gameObject.name == "WiresSection(Clone)"){
            Destroy(other.gameObject);
        }
        
    }
}
