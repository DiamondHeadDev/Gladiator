using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler/// required interface when using the OnPointerEnter method.
{
    public GameObject test;
    //Do this when the cursor enters the rect area of this selectable UI object.
    public void OnPointerEnter(PointerEventData eventData)
    {
        test.SetActive(true);
        Debug.Log("The cursor entered the selectable UI element.");
    }

    //Do this when the cursor exits the rect area of this selectable UI object.
    public void OnPointerExit(PointerEventData eventData)
    {
        test.SetActive(false);
        Debug.Log("The cursor exited the selectable UI element.");
    }
}