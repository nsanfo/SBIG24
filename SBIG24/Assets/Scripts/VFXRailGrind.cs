using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXRailGrind : MonoBehaviour
{
    public GameObject GrindDetector;
    public PlayerMovement playerMovement;
    
    private void Update() {
        if (playerMovement.isGrinding){
            this.GetComponent<VisualEffect>().enabled = true;
        }
        else{
            this.GetComponent<VisualEffect>().enabled = false;
        }
    }
}
