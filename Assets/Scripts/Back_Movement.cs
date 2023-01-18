using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Movement : MonoBehaviour
{
    public Renderer meshRendere;

    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRendere.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}
