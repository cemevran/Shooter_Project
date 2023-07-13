using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float _bulletSpeed = 3;

    private float _lifeTime = 5;
    private float _timer;

    //public int[] hp;
    private int hp = 3;


    // Start is called before the first frame update
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer>=_lifeTime)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.down * Time.deltaTime * _bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            hp--;
        }
        
    }

}
