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
    // You need to override the GrabEnd method with the correct signature
    /*public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd();
    }*/
    public ScoreKeeper scoreKeeper;
    public UnityEngine.UI.Text message;
    public Rigidbody rb;
    public UnityEngine.UI.Text countDown;
    public int left = 10;
    public int end;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity,angularVelocity);
        // Access the Rigidbody component of the grabbed object correctly
        rb = gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange); // Using ForceMode.VelocityChange to ensure consistent behavior
            light.intensity = 3f;
            scoreKeeper.IncrementZenScore();
            end = 10 - 1;
            countDown.text = "Lanterns left:" + end;
            message.text = "Peace";
            Invoke("ClearText", 2f);
        }
    }


    public void ClearText()
    {
        message.text = "";
    }
}


