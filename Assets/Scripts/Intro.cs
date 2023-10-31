using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public static Intro Instance;
    public int coin = 0;
    public string sceneName;
    // Update is called once per frame
    void Update()
    {
        if (coin == 3)
        {
            Invoke("Scenemove", 2f);
        }
    }

    public void Scenemove()
    {
        SceneManager.LoadScene(sceneName);
    }
}
