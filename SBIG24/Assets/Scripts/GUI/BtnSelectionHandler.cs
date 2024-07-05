using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnSelectionHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
    public float vertMoveAmt = 30f;
    public float moveTime = 0.1f;
    [Range(0f, 2f)] public float scaleAmt = 1.1f;

    private Vector3 startPos;
    private Vector3 startScale;

    private void Start() {
        startPos = transform.position;
        startScale = transform.localScale;
    }

    private IEnumerator MoveBtn(bool StartingAnimation){
        Vector3 endPos;
        Vector3 endScale;

        float elapsedTime = 0f;
        while (elapsedTime < moveTime)
        {
            elapsedTime += Time.deltaTime;

            if (StartingAnimation)
            {
                endPos = startPos + new Vector3(0f, vertMoveAmt, 0f);
                endScale = startScale * scaleAmt;
            }
            else
            {
                endPos = startPos;
                endScale = startScale;
            }

            //Calc lerped amounts
            Vector3 lerpedPos = Vector3.Lerp(transform.position, endPos, (elapsedTime/moveTime));
            Vector3 lerpedScale = Vector3.Lerp(transform.localScale, endScale, (elapsedTime/moveTime));

            //Apply amounts to pos and scale
            transform.position = lerpedPos;
            transform.localScale = lerpedScale;

            yield return null;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Select Btn
        eventData.selectedObject = gameObject;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Deselect Btn
        eventData.selectedObject = null;
    }

    public void OnSelect(BaseEventData eventData)
    {
        StartCoroutine(MoveBtn(true));

        BtnSelectionManager.instance.LastSelected = gameObject;

        for (int i = 0; i < BtnSelectionManager.instance.Btns.Length == gameObject; i++){
            if (BtnSelectionManager.instance.LastSelected == gameObject)
            {
                BtnSelectionManager.instance.LastSelectedIndex = i;
                return;
            }
        }
    }

    public void OnDeselect(BaseEventData eventData)
    {
        StartCoroutine(MoveBtn(false));
    }
}
