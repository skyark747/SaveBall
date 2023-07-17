using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorwplayer : MonoBehaviour
{
    [SerializeField] private float force = 40f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Turbine"))
        {
            Vector3 throwdirection = transform.right;

            Rigidbody R=GetComponent<Rigidbody>();

            R.AddForce(throwdirection*force,ForceMode.Impulse);

        }
    }
}
