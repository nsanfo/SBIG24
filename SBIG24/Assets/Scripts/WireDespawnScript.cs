using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireDespawnScript : MonoBehaviour
{
    //When this Game Object's box collider is triggered...
    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
    }
}
