using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform player;
    [SerializeField]
    public float uplim, bottomlim, leftlim, rightlim;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void LateUpdate()
    {
        Vector3 positionCamera = transform.position;
        positionCamera.x = player.position.x;
        positionCamera.y = player.position.y;

        this.transform.position = positionCamera;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftlim, rightlim),
            Mathf.Clamp(transform.position.y, bottomlim, uplim),
            transform.position.z);
    }

}
