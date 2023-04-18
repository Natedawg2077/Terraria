using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTwo : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("Square").GetComponent<Test>().testEvent.AddListener(ping);
    }

    void ping() 
    {
        Debug.Log("clicked");
    }
}
