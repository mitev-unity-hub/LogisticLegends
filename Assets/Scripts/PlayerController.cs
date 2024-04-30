using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float movingSpeed = 0.01f;
    [SerializeField] float steeringSpeed= 0.1f;

    private enum InputManager
    {
        Horizontal,
        Vertical
    }

    // Update is called once per frame
    private void Update()
    {
        Controller();
    }

    private void Controller()
    {
        float steerAmount = -Input.GetAxis(InputManager.Horizontal.ToString()) * steeringSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis(InputManager.Vertical.ToString()) * movingSpeed * Time.deltaTime;

        transform.Translate(0, moveAmout, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
