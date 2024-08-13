using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAheadAnim : MonoBehaviour
{
    public GameObject moveAheadAnim;

    public void Pressed()
    {
        moveAheadAnim.SetActive(false);
    }

    public void NotPressed()
    {
        moveAheadAnim.SetActive(true);
    }
}
