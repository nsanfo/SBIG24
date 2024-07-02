using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManagerScript gameManagerScript;
    public Animator animator;

    //Which wire the player is on, initialized at 0(Middle).
        //-1 = Left
        //1 = Right
    private int PlayerPos = 0;
    void Update()
    {
        //Debug.Log("IsGrounded: " + isGrounded);
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && PlayerPos > -(gameManagerScript.NumOfWires/2)){
            Jump();
            GoLeft();
        }
        else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))  && PlayerPos < (gameManagerScript.NumOfWires/2)){
            Jump();
            GoRight();
        }
    }

    private void OnTriggerEnter(Collider other) {
        
    }

    private void Jump()
    {
        
    }

    IEnumerator MoveToPosition(Vector3 targetPos){
        while (Vector3.Distance(transform.position, targetPos) > 0.1f){
            transform.position = Vector3.MoveTowards(transform.position, targetPos, gameManagerScript.jumpSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPos;
    }

    IEnumerator AirTime()
    {
        yield return new WaitForSeconds(gameManagerScript.airTime);
    }

    void GoLeft()
    {
        //If the position is not at the last possible left wire...
        if (PlayerPos > -(gameManagerScript.NumOfWires/2))
        {
            //Move player 2 units to the left on the x axis.
            gameObject.transform.position = new Vector3(transform.position.x - gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            // Vector3 endJumpPoint = new Vector3(
            //     transform.position.x - gameManagerScript.WireSpacing,
            //     -1,
            //     0
            // );

            // Vector3 midJumpPoint = new Vector3(
            //     transform.position.x - (gameManagerScript.WireSpacing / 2), 
            //     transform.position.y + gameManagerScript.jumpHeight, 
            //     transform.position.z);
            
            // StartCoroutine(MoveToPosition(midJumpPoint));
            // AirTime();
            // StartCoroutine(MoveToPosition(endJumpPoint));

            //Update player position by decrementing by 1
            PlayerPos -= 1;
        }
    }
    void GoRight()
    {
        //If the position is not at the last possible right wire...
        if (PlayerPos < (gameManagerScript.NumOfWires/2))
        {
            //Move player 2 units to the right on the x axis.
            gameObject.transform.position = new Vector3(transform.position.x + gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            //Update player position by incrementing by 1
            PlayerPos += 1;
        }
    }
}
