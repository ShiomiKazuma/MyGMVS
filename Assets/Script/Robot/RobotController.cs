using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [SerializeField, Tooltip("ジャンプ力")] float _jumpPower = 7f;
    [SerializeField, Tooltip("Y方向に最大のvelocity")] float _maxVelocityY = 3;
    float _h;
    float _v;
    float _moveSpeed;
    Rigidbody _rb;
    bool IsJump;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        if(Input.GetKey(KeyCode.Space))
            IsJump = true;
        else
            IsJump = false;
    }

    private void FixedUpdate()
    {
        if(IsJump)
            Jump();
    }

    private void Move()
    {
        Vector3 dir = new Vector3(_h, 0, _v);
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        _rb.velocity = dir * _moveSpeed;
    }

    private void Jump()
    {
        _rb.velocity += Vector3.up * _jumpPower;
        if (_rb.velocity.y > _maxVelocityY)
            _rb.velocity = new Vector3(_rb.velocity.x, _maxVelocityY, _rb.velocity.z);
    }
}
