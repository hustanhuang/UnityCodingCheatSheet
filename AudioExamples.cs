// Various audio examples for Unity
using UnityEngine;
using System.Collections;

public class AudioExamples : MonoBehaviour
{
    // Important: You need to have an AudioSource component attached to this gameObject
    private AudioSource audioSource;

    // Set an audioclip in the Inspector
    public AudioClip clip1;

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Plays the AudioClip set in the AudioSource component. Will be interrupted if the function is called again.
        audioSource.Play();
    }

    void Update()
    {
        // AudioSource.Play() can also be paused or stopped. 
        // Check if audioSource is playing a clip. Jump is space and Fire1 is left ctrl.
        if (audioSource.isPlaying)
        {
            if (Input.GetButtonDown("Jump"))
            {
                audioSource.Pause();
            }
            else if (Input.GetButtonDown("Fire1"))
            {
                audioSource.Stop();
            }
        }

        // PlayOneShot can be used to play a short clip. Will not be interrupted if the function is called again. 
        // Can't be used with Pause & Stop. Fire2 is left alt in the Input Manager.
        if (Input.GetButtonDown("Fire2"))
        {
            audioSource.PlayOneShot(clip1);

            // You can give this an optional volume setting as well (0-1 range)
            //audioSource.PlayOneShot(clip1, 0.5f);
        }

        // Fire3 is left shift
        if (Input.GetButtonDown("Fire3"))
        {
            // Set the pitch and volume of the clips played by Audio Source. Volume range is 0~1
            audioSource.pitch = Random.Range(0.25f, 2f);

            audioSource.volume = Random.Range(0.25f, 1f);
        }
    }
}