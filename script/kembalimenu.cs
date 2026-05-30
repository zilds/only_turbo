using UnityEngine;
using UnityEngine.SceneManagement; // Library wajib untuk pindah scene

public class KembaliKeMenu : MonoBehaviour
{
    // Fungsi ini yang akan dipanggil oleh tombol nanti
    public void KeMenuUtama(string namaSceneMenu)
    {
        // Memuat scene menu berdasarkan nama yang kamu masukkan
        SceneManager.LoadScene(namaSceneMenu);
    }

    // Alternatif: Fungsi jika kamu ingin langsung menulis nama scenenya di kode
    public void KeMenuDefault()
    {
        // Pastikan nama "menu" sama persis dengan nama file scene menu kamu
        SceneManager.LoadScene("menu");
    }
}