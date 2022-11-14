using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _companFollow : MonoBehaviour
{
    public GameObject player;
    //public AudioSource _wolfAudioSource;
    public float nextSoundTime = 30;
   
    
    NavMeshAgent agent;
    Vector3 eyes;
    
    public float remainingDistance;
    Animator anim;
    const float acceleration = .05f;
    //const float Decceleration = -0.5f;
    float speed;


    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.stoppingDistance = 3f;

    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(player.transform.position);
        speed = speed + (Time.deltaTime * acceleration);
        //speed = Mathf.Clamp(speed, 0, 5f);
        anim.SetBool("Move", true);
        anim.SetFloat("Speed", speed);
       // anim.SetInteger("IdleRandomID", -1);
        anim.SetBool("Idle", false);

        if (Vector3.Distance(agent.destination, agent.transform.position) <= agent.stoppingDistance)
        {
            if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
            {
                speed = 0;
                //anim.SetBool("Idle", true);
                anim.SetInteger("IdleRandomID", Random.Range(0,4));
                anim.SetBool("Move", false);
                anim.SetFloat("Speed", speed);
               

            }
        }
    }
}
       
        
        
           
        
       

        
   
   







