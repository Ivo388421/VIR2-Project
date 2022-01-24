using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextBoxTransform : MonoBehaviour
{
    [SerializeField] private Transform CameraPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().position = new Vector3(CameraPlayer.position.x 
            ,CameraPlayer.position.y - 0.3f, 
            CameraPlayer.position.z);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, new Quaternion(0, CameraPlayer.rotation.y, 0, CameraPlayer.rotation.w), Time.deltaTime * 20f);
    }
}
