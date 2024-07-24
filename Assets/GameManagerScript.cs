using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, new Vector3(0, 0, 10), Quaternion.identity);
        float x = Random.Range(-3.0f, 3.0f);
        Instantiate(enemy, new Vector3(x, 0, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
