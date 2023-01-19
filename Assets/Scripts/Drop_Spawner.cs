using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_Spawner : MonoBehaviour
{
    public GameObject dropPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DropSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropSpawn()
    {
        float rand = Random.Range(-1.87f,1.9f);
        Instantiate(dropPrefabs, new Vector3(rand,transform.position.y,transform.position.z),Quaternion.identity);
    }


    IEnumerator DropSpawner() {
        while (true) {
            int time = Random.Range(8,20);
            yield return new WaitForSeconds(time);
            DropSpawn();
        }
    }
}
