using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSectionScript : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public GameObject wire;
    
    private void Awake() {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        spawnWires();
    }
    private void Update() {
        //Move forward towards player each frame
        transform.position += new Vector3(0,0,-gameManagerScript.Speed * Time.deltaTime);
    }

    private void spawnWires()
    {
        int halfWires = gameManagerScript.NumOfWires/2;

        for (int i = -halfWires; i <= halfWires; i++)
        {
            Vector3 wirePos = new Vector3(transform.position.x + (i * gameManagerScript.WireSpacing), transform.position.y, transform.position.z);
            Instantiate(wire, wirePos, Quaternion.identity, transform);
        }
    }
}
