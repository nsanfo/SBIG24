using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public GameObject guiManager;
    public GameObject[] healthPips;
    public int health = 3;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Obstacle"){
            damagePlayer();
        }
    }

    private void damagePlayer(){
        health--;

        switch(health){
            case < 0:
            playerDies();
            healthPips[0].SetActive(false);
            healthPips[1].SetActive(false);
            healthPips[2].SetActive(false);
            break;

            case 0:
            healthPips[0].SetActive(false);
            healthPips[1].SetActive(false);
            healthPips[2].SetActive(false);
            playerDies();
            break;

            case 1: 
            healthPips[1].SetActive(false);
            healthPips[2].SetActive(false);
            break;

            case 2:
            healthPips[2].SetActive(false);
            break;

            case 3:
            break;

            default:
            break;
        }
    }

    private void playerDies(){
        gameObject.GetComponent<PlayerMovement>().playerCanMove = false;
        Time.timeScale = 0;
        guiManager.GetComponent<LevelGUIManager>().GameOver();
    }

}
