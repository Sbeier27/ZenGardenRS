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
    public Text Zenscore;
    public Text Score;
    // You need to override the GrabEnd method with the correct signature
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);

        /*
 *         Rigidbody rb = gameObject.GetComponent<Rigidbody>();
rb.isKinematic = m_grabbedKinematic;
rb.velocity = linearVelocity;
rb.angularVelocity = angularVelocity;
m_grabbedBy = null;
m_grabbedCollider = null;
*/

        // Access the Rigidbody component of the grabbed object correctly
        Rigidbody rb = grabbedRigidbody;
        if (rb != null)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange); // Using ForceMode.VelocityChange to ensure consistent behavior
            light.intensity = 3f;
            scoreKeeper.IncrementZenScore();
        }
        
    }
}
