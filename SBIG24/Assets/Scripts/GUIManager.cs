using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    //Instance of the GUI Manager, to check if it already exists or not
    private static GUIManager instance = new GUIManager();

    private void Awake() {
        //if it doesn't already exist...
        if (instance == null){
            //set instance to this script
            instance = this;
            //make this game object persistent
            DontDestroyOnLoad(gameObject);
        }
        //if it does already exist...
        else{
            //destroy this game object, it is not needed.
            Destroy(gameObject);
        }
    }

    public void Play(){
        Debug.Log("Play Game!");
    }

    public void Options(){
        Debug.Log("Options Menu!");
    }

    public void Quit(){
        Debug.Log("Exit Game!");
    }
}
