using UnityEngine;
using UnityEngine.SceneManagement; // Ini library wajib untuk pindah scene

public class PindahLevel : MonoBehaviour
{
    public void BukaLevel(string namaLevel)
    {
        SceneManager.LoadScene(namaLevel);
    }
}