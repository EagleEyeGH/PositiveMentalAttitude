using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speed;
    public Transform target;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        transform.LookAt(target);

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.up * Input.GetAxis("Vertical") * Time.deltaTime * speed); //.up = positive y
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed); //.right = positive x
        }
        transform.position = target.position + new Vector3(0, 2, 0);
    }
}