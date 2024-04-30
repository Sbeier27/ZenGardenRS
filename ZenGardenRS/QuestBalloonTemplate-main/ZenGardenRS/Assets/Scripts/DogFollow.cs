using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFollow : MonoBehaviour
{
    public GameObject Player;
    public float Dis;
    public Transform target;
    public Animator animator;
    public UnityEngine.UI.Text petFed;
    public UnityEngine.UI.Text message;
    //public UnityEngine.UI.Text counter;
    //public int zenLevel;
    //public UnityEngine.UI.Text Congrats;
    //public Text Zenscore;
    //public Text Score;

    public AudioSource source;
    public AudioClip clip;
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
            gameObject.GetComponent<Animator>().Play("DogWalk");
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
            source.PlayOneShot(clip);

        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "CustomHandRight")
        {
            gameObject.GetComponent<Animator>().Play("DogPet");
            scoreKeeper.IncrementZenScore();
            //counter.text = (int.Parse(counter.text) + 1).ToString();
            source.PlayOneShot(clip);
            message.text = "Having a good day";

            Invoke("ClearText:", 1.5f);
        }

    }
        public void ClearText()
        {
            message.text = "";
        }
}


