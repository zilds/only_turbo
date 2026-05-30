using UnityEngine;
using TMPro; // Wajib untuk TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject panelSelamat;

    [Header("Pengaturan Level")]
    public int targetLevelBerikutnya = 2; // Mengisi nomor level yang akan terbuka
    public int targetSkorMenang = 10;     // Target skor untuk menang (Default: 10)

    private float score;
    private bool sudahMenang = false;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null && !sudahMenang)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();

            // Menggunakan variabel 'targetSkorMenang' agar nilainya bisa fleksibel
            if ((int)score >= targetSkorMenang)
            {
                MenangLevel();
            }
        }
    }

    void MenangLevel()
    {
        sudahMenang = true;
        LevelManager.BukaLevelBaru(targetLevelBerikutnya);

        if (panelSelamat != null)
        {
            panelSelamat.SetActive(true);
        }

        Time.timeScale = 0f;
    }
}