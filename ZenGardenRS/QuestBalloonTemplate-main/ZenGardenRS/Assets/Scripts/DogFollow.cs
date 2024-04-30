using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFollow : MonoBehaviour
{
    public GameObject Player;
    public float Dis;
    public Transform target;
    public Animator animator;
<<<<<<< Updated upstream
=======
    public UnityEngine.UI.Text petFed;
    public UnityEngine.UI.Text message;
    //public UnityEngine.UI.Text counter;
    //public int zenLevel;
    //public UnityEngine.UI.Text Congrats;
    public Text Zenscore;
    public Text Score;

    public AudioSource source;
    public AudioClip clip;
    //Added during debug
    public ScoreKeeper scoreKeeper;
>>>>>>> Stashed changes

    // Update is called once per frame
    void Start()
    {
<<<<<<< Updated upstream
        gameObject.GetComponent<Animator>(); 
=======
        animator = gameObject.GetComponent<Animator>();
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
=======
        if (collision.gameObject.name == "CustomHandRight")
        {
            gameObject.GetComponent<Animator>().Play("DogPet");
            scoreKeeper.IncrementZenScore();
            //counter.text = (int.Parse(counter.text) + 1).ToString();
            source.PlayOneShot(clip);
            message.text = "Having a good day";

            Invoke("ClearText:", 1.5f);
>>>>>>> Stashed changes

        gameObject.GetComponent<Animator>().Play("DogPet");





    }

    public void ClearText() 
    {
        message.text = "";
    }




}

