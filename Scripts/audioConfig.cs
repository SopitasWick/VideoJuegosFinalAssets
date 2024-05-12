using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isMuted = false;

    void Start()
    {
        // Obtener el componente AudioSource adjunto al GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleMute()
    {
        // Cambiar el estado de mutear
        isMuted = !isMuted;

        // Mute o desmute el audio según el estado actual
        audioSource.mute = isMuted;
    }
}


