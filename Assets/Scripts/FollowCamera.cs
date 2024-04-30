using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector3 cameraOffset = new Vector3(0, 0, -10);
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
