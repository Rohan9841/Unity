using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 2000f;
    public Vector3 shootingDirection;
    public float lifeTime = 3;

    // Use this for initialization
    void Start()
    {
        // we add force to the rigidbody of magnitude shootingDirection*bulletSpeed.
        GetComponent<Rigidbody>().AddForce(shootingDirection * bulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //decrease lifeTime each second
        lifeTime -= Time.deltaTime;
        if (lifeTime<= 0)
        {   
            //Destroy gameObject this component is attached to
            Destroy(gameObject);
        }
    }
}
