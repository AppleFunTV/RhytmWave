using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource notes;
    [Header("Audio Clip")]
    public AudioClip musicGame;
    public AudioClip musicMenu;
    public AudioClip menuButton;
    public AudioClip shoot;
    public AudioClip shootEnemy;
    public AudioClip hitPlayer;
    public AudioClip[] hit;    
    public AudioClip wave;
    public AudioClip[] musicNotes;
    public AudioClip death;


    private void Start()
    {
        musicSource.clip = musicGame;
        musicSource.volume = 0.3f;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayNotes(AudioClip clip)
    {
        notes.volume = 0.5f;
        notes.PlayOneShot(clip);
    }

}
