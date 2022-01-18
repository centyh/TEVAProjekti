using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BackgroundChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject background;

    public void OnPointerEnter(PointerEventData eventData)
    {
        background.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        background.SetActive(false);
    }
}
