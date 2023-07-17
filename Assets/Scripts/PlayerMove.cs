using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;  // Speed of player movement

    private Vector3 movement;  // Movement direction

    private void Update()
    {
        // Reset movement direction
        movement = Vector3.zero;

        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if touch is on a UI button
            if (touch.phase == TouchPhase.Began && UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            {
                // Check which button was pressed and set movement direction accordingly
                if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name == "UpButton")
                    movement += Vector3.forward;
                else if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name == "DownButton")
                    movement += Vector3.back;
                else if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name == "LeftButton")
                    movement += Vector3.left;
                else if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name == "RightButton")
                    movement += Vector3.right;
            }
        }

        // Normalize movement vector and apply speed
        movement.Normalize();
        movement *= speed;

        // Move the player
        transform.Translate(movement * Time.deltaTime);
    }
}
