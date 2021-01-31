using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public Transform ballSpawn;
    private bool fallen;
    void Start()
    {
        fallen=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y<0.5 && !fallen)
        {
            fallen=true;
            Instantiate(ball,ballSpawn.position,ballSpawn.rotation);
        }

        // if the ball encounters a target, we add a point to the score
        
    }
}