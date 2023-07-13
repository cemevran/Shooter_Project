using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2;
    private Rigidbody2D _rb;
    public GameObject _enemyBulletPref;
    public GameObject _enemyPref;

    private float _enemySpawnTimer;
    private float _enemySpawnCD = 2;

    private float _enemyShootCD = 2;
    private float _enemyShootTimer;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _enemySpawnTimer += Time.deltaTime;
        _enemyShootTimer += Time.deltaTime;

        if(_enemySpawnTimer >= _enemySpawnCD)
        {
            _enemySpawnTimer = 0;
            Vector3 _spawnPos = new Vector3(Random.Range(-5f, 5f), 6f, 0);
            Instantiate(_enemyPref, _spawnPos, Quaternion.Euler(0, 0, 180));
        }

        if(_enemyShootTimer >= _enemyShootCD)
        {
            _enemyShootTimer = 0;
            Vector3 _bulletSpawnPos = transform.position + Vector3.down * 0.5f;
            Instantiate(_enemyBulletPref, _bulletSpawnPos, Quaternion.Euler(0, 0, 180));
        }

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 enemyMovement = transform.position + (Vector3.down * Time.deltaTime * _moveSpeed);
        _rb.MovePosition(enemyMovement);

    }
}
