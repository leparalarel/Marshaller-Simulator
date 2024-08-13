using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Airplane : MonoBehaviour
{
    public GameObject airplane;
    bool condition;
    float rand;

    void Start()
    {
        rand = Random.Range(-0.05f, 0.05f);
        condition = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Break") == null)
        {
            airplane.transform.Translate(0f, 0f, 0f);
        }

        if (GameObject.FindGameObjectWithTag("Break") != null)
        {
            if (condition)
            {
                airplane.transform.Translate(0f, 0f, 0f);
            }

            if (GameObject.FindGameObjectWithTag("Chocks") == null)
            {
                airplane.transform.Translate(0f, rand * Time.deltaTime, 0f);
                condition = true;
            }
            else
            {
                airplane.transform.Translate(0f, 0f, 0f);
            }
        }
    }
}
