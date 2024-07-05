using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnSelectionManager : MonoBehaviour
{
    public static BtnSelectionManager instance;

    public GameObject[] Btns;

    public GameObject LastSelected {get; set;}
    public int LastSelectedIndex {get; set;}

    private void Awake(){
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(instance);
        }
    }

    private void Update() {
        //If Move Down
            //Select Next Btn
        //If Move Up
            //Select Prior Btn
    }

    private void OnEnable() {
        StartCoroutine(SetSelectedAfterOneFrame());
    }

    private IEnumerator SetSelectedAfterOneFrame()
    {
        yield return null;
        EventSystem.current.SetSelectedGameObject(Btns[0]);
    }
}
