using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerStayEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        print("Collider");
    }

    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }


}


