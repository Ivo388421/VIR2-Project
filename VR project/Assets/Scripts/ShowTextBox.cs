using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextBox : MonoBehaviour
{
    [SerializeField] private MeshRenderer TextBox;

    [SerializeField] private Collider TextColider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        TextColider.enabled = true;
        TextBox.enabled = true;
    }

    public void complete()
    {
        TextColider.enabled = false;
        TextBox.enabled = false;
    }
}
