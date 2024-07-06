using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LevelGUIManager : MonoBehaviour
{
    //Instance of the GUI Manager, to check if it already exists or not
    private static GUIManager instance = new GUIManager();
    public Vector2 NavigationInput {get; set;}
    public InputAction navigationAction;
    public static PlayerInput playerInput;
    public GameObject Player;

    public GameObject OptionsPanel;
    public GameObject PausePanel;
    public GameObject QuitQueryPanel;
    public GameObject GameOverPanel;

    private PlayerControls playerControls;
    private bool canPause = true;

    private void Start() {
        playerControls = new PlayerControls();
    }

    private void OnPause()
    {
        TogglePause();
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        canPause = false;
    }

    //BUTTONS//
    public void Play(){
        SceneManager.LoadScene("Level0");
    }

    public void MMOptions(){
        OptionsPanel.SetActive(!OptionsPanel.activeInHierarchy);
    }

    public void Quit(){
        Application.Quit();
    }

    public void MMBack(){
        OptionsPanel.SetActive(!OptionsPanel.activeInHierarchy);
    }

    public void TogglePause(){
        if (!canPause){ return; }
        PausePanel.SetActive(!PausePanel.activeInHierarchy);
        OptionsPanel.SetActive(false);

        if (PausePanel.activeInHierarchy){
            Player.GetComponent<PlayerMovement>().playerCanMove = false;
            Time.timeScale = 0;
        }
        else{
            Player.GetComponent<PlayerMovement>().playerCanMove = true;
            Time.timeScale = 1;
        }
    }

    public void ReturnMainMenu(){
        QuitQueryPanel.SetActive(true);
    }

    public void MMYes(){
        SceneManager.LoadScene("MainMenu");
    }
    public void MMNo(){
        QuitQueryPanel.SetActive(false);
    }

    public void TryAgain(){
        GameOverPanel.SetActive(false);
        SceneManager.LoadScene("Level0");
        canPause = true;
    }

    //END BUTTONS//
}
