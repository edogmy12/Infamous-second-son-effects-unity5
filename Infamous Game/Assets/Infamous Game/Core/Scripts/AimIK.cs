using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimIK : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;

    Animator anim;
    Transform Chest;

    void Start()
    {
        anim = GetComponent<Animator>();
        Chest = anim.GetBoneTransform(HumanBodyBones.Chest);
    }

    void LateUpdate()
    {
        Chest.LookAt(Target.position);
        Chest.rotation = Chest.rotation * Quaternion.Euler(offset);
    }
} 
