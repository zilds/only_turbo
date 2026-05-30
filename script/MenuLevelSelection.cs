using UnityEngine;
using UnityEngine.UI; // Wajib karena kita akan mengatur tombol (Button)

public class MenuLevelSelection : MonoBehaviour
{
    public Button tombolLvl2;
    public Button tombolLvl3;

    void Start()
    {
        // 1. Cek Apakah Level 2 Sudah Terbuka?
        if (LevelManager.levelTerbuka >= 2)
        {
            tombolLvl2.interactable = true; // Tombol bisa diklik
        }
        else
        {
            tombolLvl2.interactable = false; // Tombol mati/terkunci
        }

        // 2. Cek Apakah Level 3 Sudah Terbuka?
        if (LevelManager.levelTerbuka >= 3)
        {
            tombolLvl3.interactable = true;
        }
        else
        {
            tombolLvl3.interactable = false;
        }
    }
}