using System.Collections;
using UnityEngine;


public class DisplayObjectForAMoment : MonoBehaviour
{
    [SerializeField] float displayTime;
    [SerializeField] GameObject objectToDisplay;

    private bool isRunning;
    private Coroutine coroutine;

    public void Display()
    {
        if (isRunning)
            StopCoroutine(coroutine);

        coroutine = StartCoroutine(IEDisplay());
    }

    IEnumerator IEDisplay()
    {
        isRunning = true;
        objectToDisplay.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        objectToDisplay.SetActive(false);
        isRunning = false;
    }

    private void OnDisable()
    {
        objectToDisplay.SetActive(false);
    }
}