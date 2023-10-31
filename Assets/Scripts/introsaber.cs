using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introsaber : MonoBehaviour
{
    public LayerMask layer;
    Vector3 prevpos;
    private AudioSource APlayer;
    public AudioClip hitsound;
    public GameObject effect;
    public static int coin = 0;
    public string sceneName;
    public GameObject startui;
    public GameObject[] endui;
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
            if (Vector3.Angle(transform.position - prevpos, hit.transform.up) > 130)
            {
                Destroy(hit.transform.gameObject);
                coin += 1;
                Debug.Log(coin);
                APlayer.PlayOneShot(hitsound);
                Instantiate(effect, hit.transform.position, Quaternion.identity);

            }
        }

        if (coin == 3)
        {
            Invoke("Scenemove", 2f);
            startui.SetActive(true);
            endui[0].SetActive(false);
            endui[1].SetActive(false);
        }

        prevpos = transform.position;
    }

    public void Scenemove()
    {
        SceneManager.LoadScene(sceneName);
    }
}
