using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = 1;
    float timer= 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > beat && timer > 6f && timer < 110f)
        {
            if (timer < 20f)
            {
                beat = 0.3f;
            }

            timer -= beat;

            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);

            c.transform.localPosition = Vector3.zero;

            c.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
        }
    }
}
