﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicks : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Spins the chicks
        transform.Rotate(0 , 50 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //If the player tags the chicks they disappear and add to counter
            GameManager.numberOfChicks += 1;
            Destroy(gameObject);
        }
    }
}
