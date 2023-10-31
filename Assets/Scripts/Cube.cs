using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        if (Time.time > 6f)
        {
            transform.position += Time.deltaTime * transform.forward * 8f;
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "break")
        {
            GameManager.Instance.combo = 0;
        }
    }
}
