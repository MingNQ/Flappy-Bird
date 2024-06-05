using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfx;
    [SerializeField] private AudioClip wingSFX;
    [SerializeField] private AudioClip scoreSFX;
    [SerializeField] private AudioClip gameOverSFX;

    private void Awake()
    {
        sfx.mute = false;
    }

    public void PlayWingSFX()
    {
        sfx.PlayOneShot(wingSFX);
    }

    public void PlayScoreSFX()
    {
        sfx.PlayOneShot(scoreSFX);
    }

    public void PlayGameOverSFX()
    {
        sfx.PlayOneShot(gameOverSFX);
    }

    public void MuteSFX()
    {
        sfx.mute = true;
    }
}
