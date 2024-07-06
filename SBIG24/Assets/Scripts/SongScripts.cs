using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongScripts : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public AudioManager audioManagerScript;
    public AudioSource audioSource;
    public PlayerMovement playerMovement;
    private void Start() {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.name == "Player"){
            playerMovement.pointsMultiplier += 1;
            audioSource.mute = false;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.transform.name == "Player"){
            StartCoroutine(waitThenMute());
        }
    }

    IEnumerator waitThenMute(){
        yield return new WaitForSeconds(gameManagerScript.musicFalloff);
        playerMovement.pointsMultiplier -= 1;
        audioSource.mute = true;
    }
}
