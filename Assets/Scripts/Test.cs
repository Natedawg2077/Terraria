using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour
{
    public UnityEvent testEvent;
    // Start is called before the first frame update
    void Start()
    {
        testEvent = new UnityEvent();
    }

    private void OnMouseDown()
    {
        testEvent.Invoke();
    }
}