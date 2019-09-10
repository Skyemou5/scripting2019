
using System;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObject;
    public UnityEvent handlerEvent;
    private void Start()
    {
        //gameActionObject.action += Action;
    }

    private void Action()
    {
        handlerEvent.Invoke();
    }
}
