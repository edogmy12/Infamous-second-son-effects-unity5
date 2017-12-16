using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticleSystem : MonoBehaviour
{
private var ps : ParticleSystem;
 
 ////////////////////////////////////////////////////////////////
 
 function Start () {
          ps = GetComponent(ParticleSystem);
 }
 
 function Update () {
     if(ps)
     {
         if(!ps.IsAlive())
         {
             Destroy(gameObject);
         }
     }
 }
}
