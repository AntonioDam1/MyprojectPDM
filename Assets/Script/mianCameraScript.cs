using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public AudioSource ambientMusic;

    public void PauseAmbientMusic()
    {
        ambientMusic.Pause();
    }
}
