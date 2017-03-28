// Various IEnumerator timer examples for Unity
using UnityEngine;
using System.Collections;

public class IEnumeratorExamples : MonoBehaviour
{
    // Flag for checking if a coroutine is running
    private bool alreadyDelayed;

    // Necessary to stop a coroutine
    private IEnumerator coroutine;

    void Start()
    {
        // Coroutines run in Start are only called once. No if statement + bool needed.
        StartCoroutine(LoopingTimer(7f));

        // Set to an IEnumerator
        coroutine = LoopingTimer(1f);
        StartCoroutine(coroutine);
    }

    void Update()
    {
        // Left ctrl key is Fire1 in Input Manager
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(DelayTimerOneShot(1f));
        }

        // Space bar is Jump in Input Manager
        if (Input.GetButtonDown("Jump"))
        {
            // This if statement ensures that a coroutine can't be run again if it is already running.
            if (!alreadyDelayed)
            {
                StartCoroutine(DelayTimerLatching(3f));
            }
        }

        // Left alt is Fire2 in Input Manager.
        if (Input.GetButtonDown("Fire2"))
        {
            // To stop a coroutine...
            StopCoroutine(coroutine);
            Debug.Log("Stopped at " + Time.time);
        }
    }

    // Wait for an amount of time before doing something (one shot behavior)
    private IEnumerator DelayTimerOneShot(float delayLength)
    {
        yield return new WaitForSeconds(delayLength);
        // Do something
        Debug.Log("Delayed One Shot");
    }

    // Wait for an amount of time before doing something (latching behavior)
    private IEnumerator DelayTimerLatching(float delayLength)
    {
        // Set the already delayed flag to signal that this coroutine is already running
        alreadyDelayed = true;
        // Do something 
        Debug.Log("Delayed Latch");
        yield return new WaitForSeconds(delayLength);
        // Do something
        Debug.Log("Delayed Latch Released");
        // Reset the already delayed flag so that this coroutine can be used once again.
        alreadyDelayed = false;
    }

    // Sequence of delays
    private IEnumerator DelayTimerSequence(float delayLength1, float delayLength2)
    {
        alreadyDelayed = true;
        yield return new WaitForSeconds(delayLength1);
        // Do first thing
        Debug.Log("First Delay");
        yield return new WaitForSeconds(delayLength2);
        // Do second thing
        Debug.Log("Second Delay");
        alreadyDelayed = false;
    }

    // This creates an endless loop
    private IEnumerator LoopingTimer(float loopInterval)
    {
        while (true)
        {
            // Do something
            Debug.Log("Repeat");
            yield return new WaitForSeconds(loopInterval);
        }
    }
}
