using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogFollow : MonoBehaviour
{
    public GameObject Player;
    public float Dis;
    public Transform target;
    public Animator animator;
    public UnityEngine.UI.Text petFed;
    //public UnityEngine.UI.Text counter;
    //public int zenLevel;
    //public UnityEngine.UI.Text Congrats;
    public Text Zenscore;
    public Text Score;

    public AudioSource source;
    public AudioClip clip;
    //Added during debug
    public ScoreKeeper scoreKeeper;

    // Update is called once per frame
    void Start()
    {
        animator = gameObject.GetComponent<Animator>(); 

    }
    
    
    
    
    
    void Update()
    {
        Dis = Vector3.Distance(transform.position, Player.transform.position);

        if (Dis >= 5)
        { 
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 5 * Time.deltaTime);
            animator.Play("DogWalk");
            if (target != null)
            {
                transform.LookAt(target);
                
            }


        }

        

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CustomHandRight")
        {
            gameObject.GetComponent<Animator>().Play("DogPet");
            scoreKeeper.IncrementZenScore();
            //counter.text = (int.Parse(counter.text) + 1).ToString();
            source.PlayOneShot(clip);

            if (collision.gameObject.tag == "Treat")
            {
                gameObject.GetComponent<Animator>().Play("DogEat");

                //counter.text = (int.Parse(counter.text) + 1).ToString();
                /*if (int.Parse(counter.text) == 2) 
                {
                    Congrats.text = "Good job! you've gained a Zen Level";
                    zenLevel++;
                    counter.text = (int.Parse(counter.text) - 2).ToString();
                } */
            }

        }




    }

    public void OnCollisionExit(Collision collision)
    {
        source.Stop();
    }




}

