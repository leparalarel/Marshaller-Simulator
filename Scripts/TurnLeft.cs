using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnLeft : MonoBehaviour
{
    public GameObject airplane, turnLeftAnim;
    public Image notPressed, pressed;
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
            airplane.transform.Rotate(0f, 0f, 10f * Time.deltaTime);
        }

        if (index == 0)
        {
            airplane.transform.Rotate(0f, 0f, 0f);
        }
    }

    public void Pressed()
    {
        index = 1;
        pressed.gameObject.SetActive(true);
        notPressed.gameObject.SetActive(false);
        turnLeftAnim.SetActive(true);
    }

    public void NotPressed()
    {
        index = 0;
        notPressed.gameObject.SetActive(true);
        pressed.gameObject.SetActive(false);
        turnLeftAnim.SetActive(false);
    }
}
