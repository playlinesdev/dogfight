using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propulsor : MonoBehaviour
{
    public float force;
    public float maxForce;
    public Rigidbody body;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        body.AddForce(new Vector3(0, -Physics.gravity.y * body.mass + .5f, 0), ForceMode.Force);
    }
}
