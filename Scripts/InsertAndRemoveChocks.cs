using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class InsertAndRemoveChocks : MonoBehaviour
{
    public GameObject airplane, chocksTag, insertChocksUI, removeChocksUI, idleAnim, startEngineAnim, stopEngineAnim, setBreakAnim, insertChocksAnim, removeChocksAnim, insertChocks, removeChocks, moveAhead;
    public Image notPressed, pressed;
    int index;

    void Start()
    {
        insertChocksUI.SetActive(false);
        removeChocksUI.SetActive(false);
    }

    void Update()
    {
        //if (GameObject.FindGameObjectWithTag("Stop") == null)
        //{
        //    index = 0;
        //    notPressed.gameObject.SetActive(true);
        //    pressed.gameObject.SetActive(false);
        //}

        if (index == 1)
        {
            chocksTag.gameObject.SetActive(false);
        }

        if (index == 0)
        {
            chocksTag.gameObject.SetActive(true);
        }
    }

    public void Pressed()
    {
        index = 0;

        insertChocksUI.SetActive(true);
        removeChocksUI.SetActive(false);
        StartCoroutine("WaitForSec");

        idleAnim.SetActive(false);
        startEngineAnim.SetActive(false);
        stopEngineAnim.SetActive(false);
        setBreakAnim.SetActive(false);
        insertChocksAnim.SetActive(true);
        removeChocksAnim.SetActive(false);

        //pressed.gameObject.SetActive(true);
        //notPressed.gameObject.SetActive(false);

        insertChocks.SetActive(false);
        removeChocks.SetActive(true);

        moveAhead.SetActive(false);
    }

    public void NotPressed()
    {
        index = 1;

        removeChocksUI.SetActive(true);
        insertChocksUI.SetActive(false);
        StartCoroutine("WaitForSec");

        idleAnim.SetActive(false);
        startEngineAnim.SetActive(false);
        stopEngineAnim.SetActive(false);
        setBreakAnim.SetActive(false);
        insertChocksAnim.SetActive(false);
        removeChocksAnim.SetActive(true);

        //pressed.gameObject.SetActive(false);
        //notPressed.gameObject.SetActive(true);

        insertChocks.SetActive(true);
        removeChocks.SetActive(false);
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        insertChocksUI.SetActive(false);
        removeChocksUI.SetActive(false);
    }
}
