using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckUpdateScore : MonoBehaviour
{
    private UIManager _uiManager;

    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    //Check collision with platform & update score
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            _uiManager.UpdateScore();
        }
    }
}
