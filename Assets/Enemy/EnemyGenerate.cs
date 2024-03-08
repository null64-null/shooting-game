using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    public GameObject Enemy;
    public float rangeX;
    public float rangeZ;
    private float time;
    private float interval = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > interval)
        {
            float x = Random.Range(-rangeX, rangeX);
            float z = Random.Range(-rangeZ+30.0f, rangeZ+30.0f);
            Vector3 pos = new Vector3(x, 5.0f, z);
            Instantiate(Enemy, pos, Quaternion.identity);
            time = 0f;
            interval = Random.Range(3.0f, 10.0f);
        }
    }

}
