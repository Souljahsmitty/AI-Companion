using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Controller : MonoBehaviour
{
    
    bool noTargetPointchosen = true;
    bool atTargetPoint = true;
    bool aboveReachableDistance = false;
    Vector3 targetToMoveTo; //Point NPC will move to
    public Transform playerTransform;
    NavMeshAgent agent;
    Animator animator;
    public NavMeshAgent player;
    public GameObject _mainTarget; //move to allowed based of position of Main Target
    float rotateSpeed = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        noTargetPointchosen = true;
        atTargetPoint = true;
        aboveReachableDistance = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        agent.destination = player.transform.position;
       
       animator.SetFloat("Horizontal", agent.velocity.magnitude);
       
       

    }
    void FixedUpdate()
    {
        
        

         
    }
    

}
