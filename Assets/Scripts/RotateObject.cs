using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotate;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotate*5*Time.deltaTime);
    }
}
