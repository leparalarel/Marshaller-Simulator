using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Variabel untuk menampilkan score
    private float score; // Variabel untuk menyimpan score

    // Update is called once per frame
    void Update()
    {
        // Jika objek dengan tag "Stop" ada atau tidak NULL, maka tambahkan score +1
        if (GameObject.FindGameObjectWithTag("Stop") != null)
        {
            score += 1 * Time.deltaTime; // Fungsi untuk menambahkan score +1 per detik
            scoreText.text = ((int)score).ToString(); // Fungsi untuk memastikan score tidak desimal dan di-convert ke String
        }
    }
}
