using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] 
    private Transform player;
    [SerializeField]
    bool Clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Clicked == true)
        {
            Vector3 Desired = player.transform.position - transform.position;
            Desired.y = 0;
            Vector3 delta = Vector3.RotateTowards(transform.forward, Desired, 1f, 0);
            transform.rotation = Quaternion.LookRotation(delta);
        }
    }

    public void Interacted()
    {
        if (Clicked == false)
        {
            Clicked = true;
        }
        else
        {
            Clicked = false;
        }

    }

    public void disable()
    {
        Clicked = false;
    }
}


