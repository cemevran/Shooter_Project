using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _moveSpeed = 10;

    private Rigidbody2D _rb;
    public GameObject _playerBulletPrefab;
    public GameObject _bulletFxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 _spawnPosBullet = transform.position + Vector3.up * 0.65f;
            Instantiate(_playerBulletPrefab, _spawnPosBullet, Quaternion.identity);
        }    
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 movePlayer = transform.position + (Vector3.right * _moveSpeed * horizontalInput * Time.deltaTime);

        _rb.MovePosition(movePlayer);
    }
}
