using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offsetX = new Vector3(15, 1, -2);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offsetX;
    }
}
