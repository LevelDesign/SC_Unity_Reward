using UnityEngine;
using System.Collections;

public class NavMechMove : MonoBehaviour {
   
  

    public Transform EndPoint;

     public Transform Target;


    public float VisibilityZone = 5.0f;





    

  //  public bool isIkActive;
    

   // bool A = false;


    Animator _anim;

    UnityEngine.AI.NavMeshAgent _navMeshAgent;



    // Use this for initialization
    void Start () {
        _navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _anim = GetComponent<Animator>();
      
    }



    // Update is called once per frame
    void Update()
    {
     

        if (Vector3.Distance(transform.position, Target.position) < VisibilityZone)
        {
			
            GetComponent<Animator>().SetBool("Walk", true);

            _navMeshAgent.SetDestination(EndPoint.position);




    }
        else
        {
  
            GetComponent<Animator>().SetBool("Walk", false);

            _navMeshAgent.SetDestination(gameObject.transform.position);
 
        }
    }



   


   




}
 

