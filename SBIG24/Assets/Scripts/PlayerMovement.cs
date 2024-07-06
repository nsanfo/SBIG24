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
    public AudioManager audioManagerScript;
    public Animator animator;
    private int PlayerPos = 0;
    private PlayerControls playerControls;
    public TMP_Text pointsDisplay;
    private int points = 0;
    public int pointsMultiplier = 0;
    public bool isGrinding = false;
    public Color oneXColor;
    public Color twoXColor;
    public Color threeXColor;
    public AudioSource[] activeRails;

    private void Start() {
        playerControls = new PlayerControls();
        InvokeRepeating("UpdatePoints", 0, gameManagerScript.pointInterval);
        InvokeRepeating("playRailGrindSFX", 0, 2.3f);
    }

    private void playRailGrindSFX(){
        if (isGrinding){
            audioManagerScript.playClip(audioManagerScript.railGrind);
        }
    }

    private void UpdatePoints(){
        if (isGrinding){
            points = points + (100 * pointsMultiplier);
            pointsDisplay.text = points.ToString();

            switch(pointsMultiplier){
            case <= 1:
            pointsDisplay.color = oneXColor;
            break;
            
            case 2:
            pointsDisplay.color = twoXColor;
            break;

            case >= 3:
            pointsDisplay.color = threeXColor;
            break;
        }
        }
    }

    private void OnMoveLeft()
    {
        if (!playerCanMove){
            return;
        }

        audioManagerScript.playClip(audioManagerScript.jumpWhoosh);

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

        audioManagerScript.playClip(audioManagerScript.jumpWhoosh);

        if (playerCanMove && PlayerPos < (gameManagerScript.NumOfWires/2))
        {
            gameObject.transform.position = new Vector3(transform.position.x + gameManagerScript.WireSpacing, transform.position.y, transform.position.z);

            PlayerPos += 1;
        }
    }
}
