using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "WinPlane")
        {
            manager.GameWin();
        }
    }
}
