using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streamer : MonoBehaviour
{
    public ParticleSystem system;  //defines a particle system to be used in the inspector
    [SerializeField]
    private OVRInput.Controller m_controller = OVRInput.Controller.None; //defines a controller to be used in the inspector


    public void update()
    {

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger)) /*checks every frame to see if the Left Index trigger has been
                                                             * pressed down and if so plays the particle effect */
        {
            system.Play();
        }

    }

}




