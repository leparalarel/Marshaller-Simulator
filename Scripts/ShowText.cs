using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{

    public GameObject UIObject;

    void Start()
    {
        UIObject.SetActive(false);
    }

    // Update is called once per frame
    public void Pressed()
    {
        UIObject.SetActive(true);
        StartCoroutine("WaitForSec");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(UIObject);
    }

}