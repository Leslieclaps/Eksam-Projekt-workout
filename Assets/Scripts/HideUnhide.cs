using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class HideUnhide : MonoBehaviour
{
    public void Hide(GameObject[] buttons)
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }

    public void UnHide(GameObject[] _buttons)
    {
        foreach (GameObject _button in _buttons)
        {
            _button.SetActive(true);
        }
    }
    
}