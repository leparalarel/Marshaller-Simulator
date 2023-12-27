using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandlerLv1 : MonoBehaviour
{
    public GameObject[] stars; // Variabel untuk menampung jumlah bintang
    private float counter; // Variabel untuk menampung jumlah waktu
    private float starTime;

    // Update is called once per frame
    void Update()
    {
        // Jika object dengan tag "Check" tidak null atau masih ada
        if (GameObject.FindGameObjectWithTag("Stop") != null)
        {
            // Maka waktu berjalan
            counter += 1 * Time.deltaTime;
        }

        // Waktu 1 - 15 detik
        if (counter <= 15)
        {
            // Maka semua bintang muncul
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
            stars[3].SetActive(true); // Perfect!
        }
        // Waktu 16 - 30 detik
        else if (counter >= 16 && counter <= 30)
        {
            // Maka 2 bintang muncul
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(false);
            stars[3].SetActive(false); // Perfect!
            stars[4].SetActive(true); // Good Job!
        }
        // Waktu 31 - 45 detik
        else if (counter >= 31 && counter <= 45)
        {
            // Maka hanya 1 bintang yang muncul
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
            stars[3].SetActive(false); // Perfect!
            stars[4].SetActive(false); // Good Job!
            stars[5].SetActive(true); // Not Bad!
        }
        // Waktu lebih dari 46 detik
        else if (counter >= 46)
        {
            // Maka semua bintang tidak muncul
            stars[0].SetActive(false);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
            stars[3].SetActive(false); // Perfect!
            stars[4].SetActive(false); // Good Job!
            stars[5].SetActive(false); // Not Bad!
            stars[6].SetActive(true); // Your grandma can do better.
        }
    }
}
