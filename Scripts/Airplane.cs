using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    public GameObject airplane;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Stop") == null)
        {
            airplane.transform.Translate(0f, 0f, 0f);
        }
        else
        {
            airplane.transform.Translate(0f, 0.5f * Time.deltaTime, 0f);
        }
    }
}
