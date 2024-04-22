using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFollow : MonoBehaviour
{
    public GameObject Player;
    public float Dis;
    public Transform target;
    public Animator animator;

    // Update is called once per frame
    void Start()
    {
        gameObject.GetComponent<Animator>(); 

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

        gameObject.GetComponent<Animator>().Play("DogPet");





    }




}

