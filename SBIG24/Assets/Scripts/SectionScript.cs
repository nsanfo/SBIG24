using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionScript : MonoBehaviour
{
    public GameManagerScript gameManagerScript;

    public GameObject[] debris;
    public GameObject[] debrisPositions;

    private void Awake(){
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        RandomizeDebrisField();
    }

    private void Update() {
        transform.position += new Vector3(0,0,-gameManagerScript.Speed * Time.deltaTime);
    }

    private void RandomizeDebrisField(){
        for (int i = 0; i < debrisPositions.Length; i++){
            Instantiate(debris[Random.Range(0,debris.Length)], debrisPositions[i].transform.position, Quaternion.Euler(Random.Range(0f,360f), Random.Range(0f,360f), Random.Range(0f,360f)), debrisPositions[i].transform);
        }
    }

}
