using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class word : MonoBehaviour
{
    float time;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetAnim()
    {
        time = 0;
    }

    public void tong()
    {
        if (time < 0.4f) //Ư�� ��ġ���� �������� �̵�
        {
            this.transform.position = new Vector3(0, 12 - 30 * time, 0);
        }
        else if (time < 0.5f) // ƨ���
        {
            this.transform.position = new Vector3(0, time - 0.4f, 0) * 4;
        }
        else if (time < 0.6f) //�ٽ� ���ڸ���
        {
            this.transform.position = new Vector3(0, 0.6f - time, 0) * 4;
        }
        else if (time < 0.7f) //ƨ���
        {
            this.transform.position = new Vector3(0, (time - 0.6f) / 2, 0) * 4;
        }
        else if (time < 0.8f) //�ٽ� ���ڸ�
        {
            this.transform.position = new Vector3(0, 0.05f - (time - 0.7f) / 2, 0) * 4;
        }
        else
        {
            this.transform.position = Vector3.zero;
        }

        time += Time.deltaTime;
    }
}
