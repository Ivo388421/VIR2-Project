using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandWichDelete : MonoBehaviour
{
    [SerializeField] private GameObject Camera;

    [SerializeField] private GameObject sandwichPlayer;

    private SandwichSounds sandwichScript;
    // Start is called before the first frame update
    void Start()
    {
        sandwichScript = sandwichPlayer.GetComponent<SandwichSounds>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= Camera.transform.position.x + 0.15 &&
            transform.position.x >= Camera.transform.position.x - 0.15 &&
            transform.position.y <= Camera.transform.position.y + 0.15 &&
            transform.position.y >= Camera.transform.position.y - 0.15 &&
            transform.position.z <= Camera.transform.position.z + 0.15 &&
            transform.position.z >= Camera.transform.position.z - 0.15)
        {
            sandwichScript.eating();
            Destroy(gameObject);
        }
    }
}
