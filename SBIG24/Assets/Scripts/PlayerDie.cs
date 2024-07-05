using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameManagerScript gameManagerScript;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Obstacle"){
            Debug.Log("Player Died!");
            Time.timeScale = 0;
        }
    }
}
