using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireScript : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public bool clearWire = false;
    public GameObject[] obstaclePositions;
    public GameObject ObstacleShort;
    public GameObject ObstacleTall;

    

    private void Awake() {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        clearWire = getBoolByChance(gameManagerScript.clearWireChance);
        fillObstacles();
    }

    
    private void fillObstacles(){
        if (clearWire){
            return;
        }

        for (int i = 0; i < obstaclePositions.Length; i++){
            if (getBoolByChance(gameManagerScript.obstacleChance)){
                
                if (getBoolByChance(gameManagerScript.whichObstacleChance)){
                    Instantiate(ObstacleShort, obstaclePositions[i].transform.position, Quaternion.identity, transform);
                }
                else{
                    Instantiate(ObstacleTall, obstaclePositions[i].transform.position, Quaternion.identity, transform);
                }
            }
        }
    }

    private bool getBoolByChance(float chance){
        
        if (Random.value > chance){
            return true;
        }
        return false;
    }
}
