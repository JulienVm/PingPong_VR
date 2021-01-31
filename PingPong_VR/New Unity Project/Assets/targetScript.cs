using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    public GameObject gameManager;
    private GameManager gmScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameManager= GameObject.Find("GameManager");
        GameManager gmScript=gameManager.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="ball")
        {
            gmScript.score++;
        }
    }
}
