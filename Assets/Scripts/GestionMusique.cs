using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionMusique : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void GererVolMusique(float volume)
    {
        _audioMixer.SetFloat("VolMusique", volume);
    }
}
