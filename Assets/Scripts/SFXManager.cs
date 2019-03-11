using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    /// <summary>
    /// This script is used to manage the sound of this game. This script 
    /// manages the background music as well as the sound made when a
    /// button is pressed.
    /// </summary>

    [Header("Background")]
    public AudioSource backgroundSource;    // Source of background music
    [Range(0, 1)]
    public float backgroundVolume;          // Volume of background music

    [Header("Button")]
    public AudioSource buttonSource;        // Source of button sound
    public AudioClip buttonClip;            // Clip of button sound
    [Range(0, 1)]
    public float buttonVolume;              // Volume of button sound

    public void Start()
    {
        backgroundSource.Play();            // Play background music
    }

    public void Update()
    {
        buttonSource.volume = buttonVolume; // Change button volume
        backgroundSource.volume = backgroundVolume; // Change background volume
    }
    public void Click()
    {
        buttonSource.PlayOneShot(buttonClip); // Play button sound
    }
}
