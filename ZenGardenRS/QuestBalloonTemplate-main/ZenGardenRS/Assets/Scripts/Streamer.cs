using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streamer : OVRGrabber
{
    public ParticleSystem system;
    [SerializeField]
    private OVRInput.Controller m_controller = OVRInput.Controller.None;


    public void confetti()
    {

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            system.Play();
        }

    }

}




