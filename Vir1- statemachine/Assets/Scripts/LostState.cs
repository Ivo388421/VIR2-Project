using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostState : StateMachineBehaviour
{
    int Counter;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(SeePlayer(animator))
       {
           //change to lost
           animator.SetInteger("CameraState", 1);
       }
       else{
           if(Counter >= 100){
               Counter = 0;
               animator.SetInteger("CameraState", 0);
           }
           else{
               Counter +=1;
           }
       }
    }

    bool SeePlayer(Animator animator)
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(
            animator.transform.position, 
            animator.transform.forward, 
            out hitInfo, 
            10))
        {
            if(hitInfo.transform.gameObject.CompareTag("Player"))
            {
                return true;
            }
        }
        return false;
    }


}
