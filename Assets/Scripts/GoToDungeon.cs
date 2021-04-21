using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GoToDungeon : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData data)
    {
        GoToDungeonfunction();
    }

    public void GoToDungeonfunction()
    {
        SceneManager.LoadScene("Dungeon");
    }
}
