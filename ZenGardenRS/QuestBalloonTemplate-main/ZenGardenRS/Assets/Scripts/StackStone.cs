using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackStone : OVRGrabbable
{
    public UnityEngine.UI.Text LevelOZen;
    public int counter = 0;
    public int zenLevel;
    public UnityEngine.UI.Text Congrats;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);

        // Access the Rigidbody component of the grabbed object correctly
        Rigidbody rb = grabbedRigidbody;
        counter++;
        if (counter == 8)
        {
            Congrats.text = "Your Soul Feels , you've gained a zen level";
            zenLevel++;
            counter = 0;



        }
    }
}
