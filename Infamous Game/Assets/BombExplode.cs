using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplode : MonoBehaviour
{
    public float delay = 3f;
    float countdown;
    bool hasExploded = false;
    public float force = 700;
    public float Radius = 5f;

    public GameObject explosionEffect;


    void Start()
    {
        countdown = delay;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(explosionEffect);
        Collider [] colliders = Physics.OverlapSphere(transform.position, Radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, Radius);
            }
        }
        Destroy(gameObject);
        
    }
}
