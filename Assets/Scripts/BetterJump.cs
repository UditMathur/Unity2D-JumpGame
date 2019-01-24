using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    //falling gravity
    private float _fallMultiplier = 3.0f;

    private float _lowJumpMultiplier = 0.6f;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if(_rb.velocity.y < 0)
        {
            _rb.velocity += Vector2.up * Physics2D.gravity.y * _fallMultiplier * Time.deltaTime;
        }

        else if(_rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            _rb.velocity += Vector2.up * Physics2D.gravity.y * _lowJumpMultiplier * Time.deltaTime;
        }
    }
}
