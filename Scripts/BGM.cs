using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private void Awake()
    {
        // Fungsi untuk mencari object dengan tag "BGM"
        GameObject[] BGMObject = GameObject.FindGameObjectsWithTag("BGM");

        // Jika BGMObject lebih dari 1, maka hancurkan Audio Source
        if (BGMObject.Length > 1)
        {
            Destroy(this.gameObject);
        }

        // Jika BGMObject tidak lebih dari 1, maka jangan hancurkan Audio Source
        DontDestroyOnLoad(this.gameObject);
    }
}
