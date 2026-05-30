using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Angka 1 artinya saat game baru dinyalakan, hanya level 1 yang terbuka
    public static int levelTerbuka = 1;

    public static void BukaLevelBaru(int nomorLevel)
    {
        // Fungsi ini memastikan kita tidak sengaja mengunci level yang sudah terbuka
        if (nomorLevel > levelTerbuka)
        {
            levelTerbuka = nomorLevel;
        }
    }
}