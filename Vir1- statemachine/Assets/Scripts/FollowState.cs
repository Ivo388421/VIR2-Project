using UnityEngine;
using UnityEngine.Analytics;


public class FollowState : StateMachineBehaviour
{
    public int Seen;

    private GameObject _player;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Seen += 1;
        animator.GetComponent<Renderer>().material.color = Color.red;
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(!SeePlayer(animator))
       {
           //change to lost
           animator.SetInteger("CameraState", 2);
       }
       else
       {
           Vector3 Desired = _player.transform.position - animator.transform.position;
           Desired.y = 0;
           Vector3 delta = Vector3.RotateTowards(animator.transform.forward, Desired, 1f, 0);
            animator.transform.rotation = Quaternion.LookRotation(delta);
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
