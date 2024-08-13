using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAndStopEngine : MonoBehaviour
{
    public GameObject startEngineUI, stopEngineUI, idleAnim, startEngineAnim, stopEngineAnim, setBreakAnim, releaseBreakAnim, insertChocksAnim, removeChocksAnim, setBreak, releaseBreak, moveAhead;
    public Image notPressed, pressed;

    void Start()
    {
        startEngineUI.SetActive(false);
        stopEngineUI.SetActive(false);
    }

    public void Pressed()
    {
        startEngineUI.SetActive(true);
        stopEngineUI.SetActive(false);
        StartCoroutine("WaitForSec");

        idleAnim.SetActive(false);
        startEngineAnim.SetActive(true);
        stopEngineAnim.SetActive(false);
        setBreakAnim.SetActive(false);
        releaseBreakAnim.SetActive(false);
        insertChocksAnim.SetActive(false);
        removeChocksAnim.SetActive(false);

        pressed.gameObject.SetActive(true);
        notPressed.gameObject.SetActive(false);

        setBreak.SetActive(true);
        moveAhead.SetActive(true);
    }

    public void NotPressed()
    {
        stopEngineUI.SetActive(true);
        startEngineUI.SetActive(false);
        StartCoroutine("WaitForSec");

        idleAnim.SetActive(false);
        startEngineAnim.SetActive(false);
        stopEngineAnim.SetActive(true);
        setBreakAnim.SetActive(false);
        releaseBreakAnim.SetActive(false);
        insertChocksAnim.SetActive(false);
        removeChocksAnim.SetActive(false);

        pressed.gameObject.SetActive(false);
        notPressed.gameObject.SetActive(true);

        setBreak.SetActive(false);
        releaseBreak.SetActive(false);
        moveAhead.SetActive(false);
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        startEngineUI.SetActive(false);
        stopEngineUI.SetActive(false);
    }
}
