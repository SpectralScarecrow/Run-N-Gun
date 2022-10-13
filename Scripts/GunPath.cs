using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPath : MonoBehaviour
{
    public float offset;
    public Transform shootpoint;
    public GameObject bullet;
    private GameObject root;

    public float bulletCount;
    public float bulletCountMax;

    // Start is called before the first frame update
    void Start()
    {
        root = transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotz + offset);

        //
        if (Input.GetButtonDown("Fire1"))
        {
            if (bulletCount > 0)
            {
                Shoot();
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            bulletCount = bulletCountMax;
        }

    }

    private void Shoot()
    {
        //aiming
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        bulletCount--;
        Instantiate(bullet, transform.position, transform.rotation);
    }


    }
/*
 * 
 *Predicted Hours: 12 hours
 * 
 * Game Flow: 
    - Change level system
    - Level Start / Complete Visuals
    - Start Screen
 
 *Bullet aiming system:
 *Change color of render
get line to follow mouse
get line to ricochet off environment
have bullets follow line
set gun to rotate towards mouse

Visuals: 
    - Decide on visual style 
    - 
 * */