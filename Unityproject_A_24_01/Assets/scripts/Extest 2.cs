using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Extest2 : MonoBehaviour
{
    public int Hp = 100;
    public Text TextUI = null; 
 
    // Update is called once per frame
    void Update()
    {
        TextUI.text = Hp.ToString();     //UI�� ü�� ǥ��

        if (Input.GetKeyDown(KeyCode.Space)) //���콺 ���� �Է��� �Ǿ��� �� ����
        {
            Hp -= 10;                    //Hp =Hp - 10
            if(Hp <=0 )                  //ü���� 0���ϰ� �Ǹ� �ı��Ѵ�.
            {
                TextUI.text = Hp.ToString();    //UI�� ü�� ǥ��
                Destroy(gameObject);     //gameobject�� ��ũ��Ʈ�� �پ��ִ� ������Ʈ�� ��Ī
            }
        }
    }
}
