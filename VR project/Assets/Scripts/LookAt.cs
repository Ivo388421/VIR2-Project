using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] 
    private Transform player;
    [SerializeField]
    bool Clicked = false;
    [SerializeField]
    private bool BoxSpawned;
    private Transform Box;
    private Vector3 spawnposition;
    public MeshRenderer TextBox;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Clicked == true)
        {
            TextBox.enabled = true;
            Vector3 Desired = player.transform.position - transform.position;
            Desired.y = 0;
            Vector3 delta = Vector3.RotateTowards(transform.forward, Desired, 1f, 0);
            transform.rotation = Quaternion.LookRotation(delta);
        }
        else
        {
            TextBox.enabled = false;
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
}


