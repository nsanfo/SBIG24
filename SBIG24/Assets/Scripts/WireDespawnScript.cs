using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireDespawnScript : MonoBehaviour
{
    //When this Game Object's box collider is triggered...
    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        //If the object it collided with is a wire or a wires section instance...
        // if (other.gameObject.name == "Wire(Clone)" || other.gameObject.name == "WiresSection(Clone)"){
        //     //Delete it
        //     Destroy(other.gameObject);
        // }
        
    }
}
