using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Transform transform;
    public float speed = 1.5f;
    public float rotationSpeed = 5f;
    public  AudioSource Gasoline_sound;
    public Score_Manager score_Value;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        // gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
       Movment();
       Clamp();
    }

    void Movment() {
    if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed * Time.deltaTime ,0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,57), rotationSpeed * Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= new Vector3(speed * Time.deltaTime ,0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,115), rotationSpeed * Time.deltaTime);
        }

        if (transform.rotation.z != 90) {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,90), rotationSpeed * Time.deltaTime);
        }
    }

    void Clamp() {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-1.92f,1.92f);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Enemy"){
               Time.timeScale = 0 ;
            //    gameOverPanel.SetActive(true);
        }
        if (collision.gameObject.tag == "Drop"){
            //    Gasoline_sound.Play();
               score_Value.score += 10;
               Destroy(collision.gameObject);
        }
        
    }
}
