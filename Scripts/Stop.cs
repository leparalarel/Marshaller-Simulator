using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stop : MonoBehaviour
{
    public GameObject airplane, stopAnim, square; // Variabel square untuk menampung Square
    public Image notPressed, pressed;
    private float counter;
    float stopTime = 0;
    int index;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Stop") == null)
        {
            index = 0;
            notPressed.gameObject.SetActive(true);
            pressed.gameObject.SetActive(false);
        }

        if (index == 1)
        {
            counter += 1 * Time.deltaTime;

            if (counter <= 6)
            {
                stopTime -= 0.000008f; // Fungsi untuk mengurangi kecepatan kapal
            }
            else
            {
                stopTime = -0.006f; // Fungsi untuk membuat kapal stop
                square.gameObject.SetActive(false);
            }

            airplane.transform.Translate(0f, stopTime, 0f);
        }

        if (index == 0)
        {
            airplane.transform.Translate(0f, 0f, 0f);
        }
    }

    public void Pressed() 
    {
        index = 1;
        pressed.gameObject.SetActive(true);
        notPressed.gameObject.SetActive(false);
        stopAnim.gameObject.SetActive(true);
    }

    public void NotPressed()
    {
        index = 0;
        counter = 0;
        stopTime = 0;
        notPressed.gameObject.SetActive(true);
        pressed.gameObject.SetActive(false);
        stopAnim.gameObject.SetActive(false);
    }
}
