using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float move)
    {
        _animator.SetFloat("Move", math.abs(move));
    }

    public void MoveUp(float move)
    {
        _animator.SetFloat("MoveUp", move);
    }

    public void MoveDown(float move)
    {
        _animator.SetFloat("MoveDown", move);
    }
}
