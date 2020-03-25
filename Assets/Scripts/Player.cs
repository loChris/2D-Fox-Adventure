using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private PlayerAnimation _playerAnimation;
    [SerializeField] private float _speed = 1.5f; 
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        
        _rigidbody2D.velocity = new Vector2(moveHorizontal, moveVertical) * _speed;
        
        _playerAnimation.Move(moveHorizontal);
    }
}
