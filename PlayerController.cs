using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10;
    public float borderLine = 9;
    public GameObject projectilePrefab;

    void Start()
    {
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (transform.position.x < -borderLine)
        {
            transform.position = new Vector3(-borderLine, transform.position.y, transform.position.z);
        }
        if (transform.position.x > borderLine)
        {
            transform.position = new Vector3(borderLine, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
