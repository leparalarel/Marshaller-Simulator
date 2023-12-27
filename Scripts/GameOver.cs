using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Variabel untuk menetapkan "Game Over"
    public GameObject gameOverPanel, failedPanel;

    void Update()
    {
        // Jika objek dengan tag "Check" tidak ada atau NULL, maka tampilkan game over
        if (GameObject.FindGameObjectWithTag("Check") == null)
        {
            gameOverPanel.SetActive(true); // Fungsi untuk menampilkan game over
            failedPanel.SetActive(false);
        }
        // Jika objek dengan tag "Stop" tidak ada atau NULL tetapi objek dengan tag "Check" ada atau tidak NULL, maka tampilkan failed
        else if (GameObject.FindGameObjectWithTag("Stop") == null && GameObject.FindGameObjectWithTag("Check") != null)
        {
            failedPanel.SetActive(true); // Fungsi untuk menampilkan failed
            gameOverPanel.SetActive(false);
        }
    }

    // Fungsi ini akan dipanggil jika user menekan tombol restart
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Fungsi untuk memuat ulang layar
    }
}
