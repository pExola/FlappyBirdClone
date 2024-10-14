using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform player;

    private void Update()
    {
        Vector3 _newPosition = transform.position;
        _newPosition.x = player.position.x;

        transform.position = _newPosition;
    }
}
