using System;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public FloatData speed;

    private void Update()
    {
        var speedVect = new Vector3(x: speed.value, y: 0, z: 0) * Time.deltaTime;
        transform.Translate(speedVect);
    }
}
