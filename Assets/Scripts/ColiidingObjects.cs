using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float speed = 2f;


    private float currentLerpTime = 0f;
    private float journeyLength;

    private void Start()
    {
        journeyLength = Vector3.Distance(startPoint.position, endPoint.position);
    }

    private void Update()
    {
        currentLerpTime += Time.deltaTime * speed;

        if (currentLerpTime > 1f)
        {
            // Swap start and end points to move the platform back and forth
            Transform temp = startPoint;
            startPoint = endPoint;
            endPoint = temp;
            currentLerpTime = 0f;
        }

        float percentage = currentLerpTime / 1f;
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, percentage);
    }
}
