using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrindDetectorScript : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "Wire"){
            playerMovement.isGrinding = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if (other.transform.tag == "Wire"){
            playerMovement.isGrinding = false;
        }
    }
}
