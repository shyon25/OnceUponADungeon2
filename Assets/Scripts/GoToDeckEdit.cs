using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GoToDeckEdit : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData data)
    {
        GoToDeckEditfunction();
    }

    public void GoToDeckEditfunction()
    {
        SceneManager.LoadScene("DeckEdit");
    }
}
