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
        TextUI.text = Hp.ToString();     //UI에 체력 표시

        if (Input.GetKeyDown(KeyCode.Space)) //마우스 왼쪽 입력이 되었을 때 조건
        {
            Hp -= 10;                    //Hp =Hp - 10
            if(Hp <=0 )                  //체력이 0이하가 되면 파괴한다.
            {
                TextUI.text = Hp.ToString();    //UI에 체력 표시
                Destroy(gameObject);     //gameobject는 스크립트가 붙어있는 오브젝트를 지칭
            }
        }
    }
}
