using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void KeluarGame()
    {
        // Pesan di console untuk memastikan fungsi terpanggil
        Debug.Log("Tombol Keluar ditekan!");

        // Berhenti saat di Editor Unity (Layar langsung STOP)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        // Keluar jika sudah jadi aplikasi (Build)
        Application.Quit();
    }
}