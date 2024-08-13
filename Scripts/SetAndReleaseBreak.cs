using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class SetAndReleaseBreak : MonoBehaviour
{
    public GameObject airplane, breakTag, setBreakUI, releaseBreakUI, startEngineAnim, setBreakAnim, releaseBreakAnim, insertChocksAnim, removeChocksAnim, moveAhead;
    public Image notPressed, pressed;
    int index;

    void Start()
    {
        setBreakUI.SetActive(false);
        releaseBreakUI.SetActive(false);
    }

    void Update()
    {
        if (index == 1)
        {
            breakTag.gameObject.SetActive(false);
        }

        if (index == 0)
        {
            breakTag.gameObject.SetActive(true);
        }
    }

    public void Pressed()
    {
        index = 1;

        setBreakUI.SetActive(true);
        releaseBreakUI.SetActive(false);
        StartCoroutine("WaitForSec");

        startEngineAnim.SetActive(false);
        setBreakAnim.SetActive(true);
        releaseBreakAnim.SetActive(false);

        pressed.gameObject.SetActive(true);
        notPressed.gameObject.SetActive(false);

        moveAhead.SetActive(false);
    }

    public void NotPressed()
    {
        index = 0;

        releaseBreakUI.SetActive(true);
        setBreakUI.SetActive(false);
        StartCoroutine("WaitForSec");

        startEngineAnim.SetActive(false);
        setBreakAnim.SetActive(false);
        releaseBreakAnim.SetActive(true);
        insertChocksAnim.SetActive(false);
        removeChocksAnim.SetActive(false);

        pressed.gameObject.SetActive(false);
        notPressed.gameObject.SetActive(true);

        moveAhead.SetActive(true);
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        setBreakUI.SetActive(false);
        releaseBreakUI.SetActive(false);
    }
}
