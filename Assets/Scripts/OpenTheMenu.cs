using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenTheMenu : MonoBehaviour, IPointerClickHandler
{
    public bool closed;
    public GameObject menus;
    
    public void OnPointerClick(PointerEventData data)
    {
        if (closed == false)
        {
            menus.SetActive(false);
            closed = true;
        }
        else
        {
            menus.SetActive(true);
            closed = false;
        }
        Debug.Log("Clicked");
    }

    void Start()
    {
        menus = GameObject.Find("Menus");
        menus.SetActive(false);
        closed = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
