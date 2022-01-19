using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    float maxPlayerDist = 10;
    float minPlayerDist = 5;
    Color colorStart = Color.yellow;
    Color colorEnd = Color.red;
    Renderer Rend;
    // Start is called before the first frame update
    void Start()
    {
        Rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Player.position, transform.position);
        Rend.material.color = Color.Lerp(colorEnd, colorStart, (dist/ maxPlayerDist) * (dist/minPlayerDist));

        
    }
}
