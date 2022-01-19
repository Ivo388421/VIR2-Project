using UnityEngine;

public class PatrolState : StateMachineBehaviour
{
    [SerializeField]
    float Rotation = 50;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.GetComponent<Renderer>().material.color = Color.green;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.Rotate(Vector3.up, Rotation * Time.deltaTime);
        if(SeePlayer(animator) == true){
            animator.SetInteger("CameraState", 1);
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
