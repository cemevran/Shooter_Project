using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFx : MonoBehaviour
{

    [SerializeField] private float _bulletFxLifeTime = 0.2f;
    private float _timer;
    public SpriteRenderer _bulletFx;
    private bool timerEnable;


    // Start is called before the first frame update
    void Start()
    {
        _bulletFx = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerEnable==true)
        {
            _timer += Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            timerEnable = true;
            _bulletFx.enabled = true;
            
        }
        else if (_timer >= _bulletFxLifeTime)
        {
            _bulletFx.enabled = false;
            timerEnable = false;
            _timer = 0;
        }
    }
}
