using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFollow : MonoBehaviour
{
    public GameObject Player; //defines a player in the inspector to follow
    public float Dis;  //a float to track the distance of the dog and player
    public Transform target; // defines a target to look at
    public Animator animator; //gathers an animator
    public UnityEngine.UI.Text petFed; //defines a specific part of the UI to use
    public UnityEngine.UI.Text message; // defines a specific part of the UI to use
    //public UnityEngine.UI.Text counter;
    //public int zenLevel;
    //public UnityEngine.UI.Text Congrats;
    //public Text Zenscore;
    //public Text Score;

    public AudioSource source; //defines an audio source in the inspector
    public AudioClip clip; //defines a specific audio clip
    public ScoreKeeper scoreKeeper; //defines a specifc UI element 

    // Update is called once per frame
    void Start()
    {

        animator = gameObject.GetComponent<Animator>(); /*at the start of the scene it gets the Animator
                                                        * of the object and sets it to the animator 
                                                        * variable */

    }





    void Update()
    {
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        //defines the distance between the dog and the player

        if (Dis >= 5)  /*if the distance is greater or equal to 5, the dog moves towards the player while playing the dog 
                        * walk animation */
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 5 * Time.deltaTime);
            gameObject.GetComponent<Animator>().Play("DogWalk");
            if (target != null)    //if there is a target, the dog turns to look at them
            {
                transform.LookAt(target);

            }


        }



    }

    public void OnCollisionEnter(Collision collision)               /* defines a collision enter where if the CustomHandRight 
                                                                     * object collides with the dog object, it plays the dog 
                                                                     * pet animation and plays a short barking sound*/
                                                                     
    {
        if (collision.gameObject.name == "CustomHandRight")
        {
            gameObject.GetComponent<Animator>().Play("DogPet");
            source.PlayOneShot(clip);

        }
    }
    public void OnCollisionExit(Collision collision)                 /*defines a collision exit for CustomHandRight that 
                                                                      * increases the scoreKeeper while displaying the message
                                                                      *Having a good day before clearing the text */
                                                                      
    {
        if (collision.gameObject.name == "CustomHandRight")
        {

            scoreKeeper.IncrementZenScore();
            //counter.text = (int.Parse(counter.text) + 1).ToString();
            source.PlayOneShot(clip);
            message.text = "Having a good day";

            Invoke("ClearText:", 1.5f);
        }

    }
        public void ClearText()          //clears the text UI so that it's blank
        {
            message.text = "";
        }
}


