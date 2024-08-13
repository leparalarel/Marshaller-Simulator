using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAhead : MonoBehaviour
{
    public GameObject airplane, idleAnim, moveAheadAnim, setBreakAnim, releaseBreakAnim, insertChocksAnim, removeChocksAnim, turnLeft, turnRight, stop;
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

        if (GameObject.FindGameObjectWithTag("Break") != null && GameObject.FindGameObjectWithTag("Chocks") == null)
        {
            if (index == 1)
            {
                airplane.transform.Translate(0f, 0.5f * Time.deltaTime, 0f);
            }
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

        idleAnim.SetActive(false);
        moveAheadAnim.SetActive(true);
        setBreakAnim.SetActive(false);
        releaseBreakAnim.SetActive(false);
        insertChocksAnim.SetActive(false);
        removeChocksAnim.SetActive(false);

        turnLeft.SetActive(true);
        turnRight.SetActive(true);
        stop.SetActive(true);
    }

    public void NotPressed()
    {
        index = 0;

        notPressed.gameObject.SetActive(true);
        pressed.gameObject.SetActive(false);

        idleAnim.SetActive(true);
        moveAheadAnim.SetActive(false);

        turnLeft.SetActive(false);
        turnRight.SetActive(false);
        stop.SetActive(false);
    }
}
