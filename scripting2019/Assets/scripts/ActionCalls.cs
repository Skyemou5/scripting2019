using System;
using UnityEngine;

public class ActionCalls : MonoBehaviour
{
    public float speed = 1f, 
        rotateSpeed = 10f;

    private void Start()
    {
        transformState = OnMove();
    }

    public enum TransformStates
    
    {
        Move,
        Update,
        Scale
    }

    public TransformStates transformState;
    
    private Vector3 location, 
        scales, 
        scaleSpeed;

    private void Update()
    {
        switch (transformState)
        {
            case TransformStates.Move:
                
        }
    }

    public void OnMove()
    {
        location.x = speed * Time.deltaTime;
        transform.Translate(location);
    }

    public void OnRotate()
    {
        location.y += rotateSpeed * Time.deltaTime;
        transform.Rotate(location);
    }

    public void OnScale()
    {
        scales.Set(scaleSpeed,scaleSpeed,scaleSpeed);
        transform.localScale += scales;
    }
    
}
