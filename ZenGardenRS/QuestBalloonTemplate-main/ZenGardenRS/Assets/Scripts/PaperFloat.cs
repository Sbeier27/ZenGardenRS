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
using UnityEngine.UI;

public class PaperFloat : OVRGrabbable
{
    public Light light;
    public ScoreKeeper scoreKeeper;


    // Access the Rigidbody component of the grabbed object correctly
    void OnCollisionEnter(Collision collision){
        Rigidbody rb = grabbedRigidbody;
        if (collision.gameObject.name == "CustomHandRight")
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange); // Using ForceMode.VelocityChange to ensure consistent behavior
            light.intensity = 3f;
            scoreKeeper.IncrementZenScore();
        }
        
    }
}
