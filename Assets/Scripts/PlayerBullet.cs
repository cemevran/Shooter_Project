using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float _bulletSpeed = 10;

    private float _lifeTime = 5;
    private float _lifeTimer;

    // Start is called before the first frame update
    void Update()
    {
        _lifeTimer += Time.deltaTime;
        if(_lifeTimer >= _lifeTime)
        {
            _lifeTimer = 0;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.up * Time.deltaTime * _bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }

}
