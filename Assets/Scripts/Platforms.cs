using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour {
    [SerializeField]
    private float _speed;

    private UIManager _uiManager;

    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update ()
    {
        if(_uiManager.score < 100)
        {
            _speed = 5.0f;
        }

        else if (_uiManager.score > 100 && _uiManager.score < 200)
        {
            _speed = 6.0f;
        }

        else if (_uiManager.score > 200 && _uiManager.score < 400)
        {
            _speed = 7.0f;
        }

        else if (_uiManager.score > 400 && _uiManager.score < 800)
        {
            _speed = 8.0f;
        }

        else if (_uiManager.score > 800)
        {
            _speed = 9.0f;
        }

        transform.Translate(Vector3.left * Time.deltaTime * _speed);


        if (transform.position.x < -12.1f)
        {
            //transform.position = new Vector3(12.1f, Random.Range(-4.0f,2.0f));
            Destroy(this.gameObject);
        }
    }

}
