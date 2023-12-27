using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPosition : MonoBehaviour
{
    Collider coll;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerStay(Collider other)
    {
        // Jika objek dengan tag "Stop" adalah NULL, maka fungsi dibawahnya baru dijalankan
        if (GameObject.FindGameObjectWithTag("Stop") == null)
        {
            if (other.tag == "Player")
            {
                if (coll.bounds.Contains(other.bounds.max) && coll.bounds.Contains(other.bounds.min))
                {
                    print("Objek masuk semua");
                    Destroy(this.gameObject); // Jika pesawat masuk semua, maka hancurkan Check
                }
                else
                {
                    print("Objek masuk sebagian");
                }
            }
        }
    }
}
