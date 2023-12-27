using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAhead : MonoBehaviour
{
    public GameObject moveAhead;

    public void Pressed()
    {
        moveAhead.SetActive(false);
    }

    public void NotPressed()
    {
        moveAhead.SetActive(true);
    }
}
