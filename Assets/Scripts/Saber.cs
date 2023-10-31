using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    Vector3 prevpos;
    private AudioSource APlayer;
    public AudioClip hitsound;
    public GameObject effect;
    public word Word;
    void Awake()
    {
        APlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 2, layer))
        {
            if (Vector3.Angle(transform.position-prevpos, hit.transform.up) > 130)
            {
                Destroy(hit.transform.gameObject);
                GameManager.Instance.score += 50;
                GameManager.Instance.combo += 1;
                //Word.resetAnim();
                //Word.tong();
                APlayer.PlayOneShot(hitsound);
                Instantiate(effect, hit.transform.position, Quaternion.identity);
                
            }
        }
        prevpos = transform.position;
    }
}
