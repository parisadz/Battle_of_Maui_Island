using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane_Spawner : MonoBehaviour
{
    public GameObject[] Enemy;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(SpawnPlans());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Plans() {
        int rand = Random.Range(0,Enemy.Length);
        float randXPos= Random.Range(-1.87f,1.9f);
        Instantiate(Enemy[rand], new Vector3(randXPos, transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,270));
    }

    IEnumerator SpawnPlans() {
       while(true){
             yield return new WaitForSeconds(4);
               Plans();
       }
    }
}
