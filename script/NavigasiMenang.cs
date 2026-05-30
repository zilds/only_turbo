using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigasiMenang : MonoBehaviour
{
    public void PindahScene(string namaSceneTarget)
    {
        // WAJIB: Kembalikan waktu game menjadi normal (1f) sebelum pindah scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(namaSceneTarget);
    }
}