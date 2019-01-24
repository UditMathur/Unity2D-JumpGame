using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D _rb;
    public bool _onGround = false;

    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private LayerMask groundLayer;

    [SerializeField]
    private GameObject[] _platforms;

    private GameManager _gameManager;

    private UIManager _uiManager;


	// Use this for initialization
	void Start ()
    {
        _rb = GetComponent<Rigidbody2D>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


        InvokeRepeating("SpawnPlatform", 0, 1.5f);

    }
	
	// Update is called once per frame
	void Update ()
    {
        _onGround = Physics2D.OverlapCircle(_groundCheck.position, 0.1f, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && _onGround == true)
        {
            _rb.velocity = Vector2.up * 8;
        }
        Movement();

        if (transform.position.y < -5.5f)
        {
            _uiManager.ShowGameOver();
            _gameManager.gameOver = true;

            //if (Input.GetKeyDown(KeyCode.Space))
            {
                //_uiManager.HideGameOver();
                //_gameManager.gameOver = false;
                //_uiManager.ShowTitleScreen();
                //_gameManager.showTitleScreen = true;
                //_gameManager.StartScreen();
            }

        }

    }

    public void Movement()
    {
        if(transform.position.y > 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, transform.position.z);
        }
    }

    public void SpawnPlatform()
    {
        if(_gameManager.showTitleScreen == false)
        {
            float randomY = Random.Range(-2.7f, 1.7f);
            int randomPlatform = Random.Range(0, 2);
            Instantiate(_platforms[randomPlatform], new Vector3(10.91f, randomY, transform.position.z), Quaternion.identity);
        }

    }

}
