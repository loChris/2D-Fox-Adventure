using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private PlayerAnimation _playerAnimation;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed = 1.5f; 
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        
        FlipSprite(moveHorizontal);
        
        _rigidbody2D.velocity = new Vector2(moveHorizontal, moveVertical) * _speed;
        
        _playerAnimation.Move(moveHorizontal);
        _playerAnimation.MoveUp(moveVertical);
        _playerAnimation.MoveDown(moveVertical);
    }

    void FlipSprite(float move)
    {
        if (_spriteRenderer != null)
        {
            if (move > 0)
            {
                _spriteRenderer.flipX = false;
            }
            else if (move < 0)
            {
                _spriteRenderer.flipX = true;
            }
        }
    }
}
