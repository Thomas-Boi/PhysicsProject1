using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine : MonoBehaviour
{

    public float mass;

    public Vector3 velocityVector;
    public Vector3 netForceVector;
    public List<Vector3> forceVectorList;


    void Start()
    {
        // by default the mass is 1
        mass = 1;
    }

    void FixedUpdate()
    {
        transform.position += velocityVector * Time.fixedDeltaTime;
    }
}
