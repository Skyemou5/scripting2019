using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action; //cannot be directly called by unity event system

    public void Raise()
    {
        action?.Invoke();//check if its null if it's not null invoke it
    }
    
}
