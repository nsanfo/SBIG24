using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject LeftTarget;
    public GameObject RightTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            GoLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            GoRight();
        }
    }

    void GoLeft()
    {
        Debug.Log("Left");
        gameObject.transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
    }
    void GoRight()
    {
        gameObject.transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        Debug.Log("Right");
    }
}
