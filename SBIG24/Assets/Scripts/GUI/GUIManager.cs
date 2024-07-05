using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //Instance of the GUI Manager, to check if it already exists or not
    private static GUIManager instance = new GUIManager();
    public Vector2 NavigationInput {get; set;}
    public InputAction navigationAction;
    public static PlayerInput playerInput;

    public GameObject MMOptionsPanel;
    public GameObject PausePanel;
    public GameObject QuitQueryPanel;

    private PlayerControls playerControls;

    private void Start() {
        playerControls = new PlayerControls();
    }

    private void OnPause()
    {
        TogglePause();
    }

    //BUTTONS//
    public void Play(){
        SceneManager.LoadScene("Level0");
    }

    public void MMOptions(){
        MMOptionsPanel.SetActive(!MMOptionsPanel.activeInHierarchy);
    }

    public void Quit(){
        Application.Quit();
    }

    public void MMBack(){
        MMOptionsPanel.SetActive(!MMOptionsPanel.activeInHierarchy);
    }

    public void TogglePause(){
        PausePanel.SetActive(!PausePanel.activeInHierarchy);
        MMOptionsPanel.SetActive(false);

        if (PausePanel.activeInHierarchy){
            
            Time.timeScale = 0;
        }
        else{
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

    public void ResetGame(){
        SceneManager.LoadScene("Level0");
    }
    //END BUTTONS//
}
