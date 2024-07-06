using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public bool playerCanMove = true;
    public GameManagerScript gameManagerScript;
    public Animator animator;
    private int PlayerPos = 0;
    private PlayerControls playerControls;
    public TMP_Text pointsDisplay;
    private int points = 0;
    private int pointsMultiplier = 1;
    public bool isGrinding = false;
    

    private void Start() {
        playerControls = new PlayerControls();
        InvokeRepeating("UpdatePoints", 0, gameManagerScript.pointInterval);
    }

    private void Update() {
        
    }

    private void UpdatePoints(){
        if (isGrinding){
            points = points + (100 * pointsMultiplier);
        pointsDisplay.text = points.ToString();
        }
    }

    private void OnMoveLeft()
    {
        if (!playerCanMove){
            return;
        }

        if (playerCanMove && PlayerPos > -(gameManagerScript.NumOfWires/2))
        {
            gameObject.transform.position = new Vector3(transform.position.x - gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            PlayerPos -= 1;
        }
    }
    private void OnMoveRight()
    {
        if (!playerCanMove){
            return;
        }

        if (playerCanMove && PlayerPos < (gameManagerScript.NumOfWires/2))
        {
            gameObject.transform.position = new Vector3(transform.position.x + gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            PlayerPos += 1;
        }
    }
}
