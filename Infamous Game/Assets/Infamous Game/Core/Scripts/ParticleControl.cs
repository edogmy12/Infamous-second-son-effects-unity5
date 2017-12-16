using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    [Header("VertexParticle Scripts")]
    public VertexParticles VertexParticlesScriptLaggingMeshVertices;
    public VertexParticles VertexParticlesScriptStayingMeshVertices;
    
    public SkinnedMeshRenderer PlayerSkinnedMesh;
    public SkinnedMeshRenderer playerJointsSkinnedMesh;


    // all Particles
    //Thrusting Particles
    [Header("Thrusting Particles")]

    public ParticleSystem LeftForeArm;
    public ParticleSystem LeftArm;

    public ParticleSystem RightForeArm;
    public ParticleSystem RightArm;


    //mesh particles
    [Header("Mesh Vertice particles")]
    public ParticleSystem StayingMeshVertices;
    public ParticleSystem LaggingMeshVertices;

    public Animator anim;

    //trail renderers
    [Header("Trail Renderers")]
    public TrailRenderer Trail1;
    public TrailRenderer Trail2;
    public TrailRenderer Trail3;
    public TrailRenderer Trail4;
    public TrailRenderer Trail5;
    public TrailRenderer Trail6;

    [Header("Particle dust")]
    public ParticleSystem ParticleDust1;
    public ParticleSystem ParticleDust2;



    public bool ParticleThrusting = false;

    void Start()
    {
        anim = anim.GetComponent<Animator>();
        ThrustingOff();
        DashingOff();
       

    }

    void DashingOff()
    {
        anim.SetBool("Dashing", false);

        playerJointsSkinnedMesh.enabled = true;
        PlayerSkinnedMesh.enabled = true;

        VertexParticlesScriptLaggingMeshVertices.enabled = false;
        VertexParticlesScriptStayingMeshVertices.enabled = false;

        Trail1.enabled = false;
        Trail2.enabled = false;
        Trail3.enabled = false;
        Trail4.enabled = false;
        Trail5.enabled = false;
        Trail6.enabled = false;

        ParticleDust1.enableEmission = false;
        ParticleDust2.enableEmission = false;

    }
    void DashingOn()
    {
        anim.SetBool("Dashing", true);
        playerJointsSkinnedMesh.enabled = false;
        PlayerSkinnedMesh.enabled = false;

        VertexParticlesScriptLaggingMeshVertices.enabled = true;
        VertexParticlesScriptStayingMeshVertices.enabled = true;

        Trail1.enabled = true;
        Trail2.enabled = true;
        Trail3.enabled = true;
        Trail4.enabled = true;
        Trail5.enabled = true;
        Trail6.enabled = true;

        ParticleDust1.enableEmission = true;
        ParticleDust2.enableEmission = true;
    }

    void ThrustingOn()
    {
        ParticleThrusting = true;

        LeftForeArm.enableEmission = true;
        LeftArm.enableEmission = true;

        RightForeArm.enableEmission = true;
        RightArm.enableEmission = true;

    }
    void ThrustingOff()
    {
        ParticleThrusting = false;

        LeftForeArm.enableEmission = false;
        LeftArm.enableEmission = false;

        RightForeArm.enableEmission = false;
        RightArm.enableEmission = false;

    }

    void Update()
    {
        if (anim.GetBool("Grounded") == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                ThrustingOn();
            }
            else
            {
                ThrustingOff(); 
            }
          

        }

        if (anim.GetBool("Grounded") == true)
        {
            ThrustingOff();
        }

        if (anim.GetFloat("Speed") > 1.5)
        {
            DashingOn();
        }
        else
        {
            DashingOff();
        }
    }

}
