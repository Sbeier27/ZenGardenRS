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
    public UnityEngine.UI.Text LevelOZen;
    public int zenLevel;
    public UnityEngine.UI.Text Congrats;

    public Light light;

    public Rigidbody rb;

    public UnityEngine.UI.Text counter;
    public AudioSource source;
    public AudioClip clip;


    // You need to override the GrabEnd method with the correct signature



    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);

        // Access the Rigidbody component of the grabbed object correctly
        if (rb != null)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 1f, ForceMode.VelocityChange); // Using ForceMode.VelocityChange to ensure consistent behavior
            light.intensity = 10;
            counter.text = (int.Parse(counter.text) + 1).ToString();


            source.PlayOneShot(clip);
            if (int.Parse(counter.text) == 10)
            {
                Congrats.text = "Your Heart Feels lighter, you've gained a zen level";
                zenLevel++;
                counter.text = (int.Parse(counter.text) -10).ToString();




            }
        }
    }

    

}
