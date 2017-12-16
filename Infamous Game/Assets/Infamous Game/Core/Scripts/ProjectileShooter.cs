using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    private GameObject ProjectilePrefab;

    void Start()
    {
        ProjectilePrefab = Resources.Load("arrow") as GameObject;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newProjectile = Instantiate(ProjectilePrefab) as GameObject;
        }
    }
}
