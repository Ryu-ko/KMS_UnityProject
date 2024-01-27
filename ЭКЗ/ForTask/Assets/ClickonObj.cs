using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ClickonObj : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }


}
