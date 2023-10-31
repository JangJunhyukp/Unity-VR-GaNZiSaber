using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public int combo = 0;
    public Text scoretext;
    public Text combotext;
    public GameObject comboui;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : " + score;

        if (combo != 0 && combo > 0)
        {  
           comboui.SetActive(true);
           combotext.text = "Combo : " + combo + "!";
        }

        else
        {
            comboui.SetActive(false);
        }
    }
}
