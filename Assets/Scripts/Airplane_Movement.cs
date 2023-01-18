using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane_Movement : MonoBehaviour
{
    public Transform transform;

    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,speed * Time.deltaTime,0);
    }
}
