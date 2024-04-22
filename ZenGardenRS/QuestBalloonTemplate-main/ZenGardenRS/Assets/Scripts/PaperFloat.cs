using System.Collections;
using System.Collections.Generic;

/*
public class PaperFloat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
using UnityEngine;

public class PaperFloat : OVRGrabbable
{
    public Light light;
    // You need to override the GrabEnd method with the correct signature
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);

        // Access the Rigidbody component of the grabbed object correctly
        Rigidbody rb = grabbedRigidbody;
        if (rb != null)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange); // Using ForceMode.VelocityChange to ensure consistent behavior
            light.intensity = 3f;
            
        }
    }
}
