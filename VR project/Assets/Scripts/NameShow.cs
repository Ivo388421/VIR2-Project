using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextName;
    // Start is called before the first frame update
    void Start()
    {
        TextName.text = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
