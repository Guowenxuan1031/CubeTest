using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject cubeCorrect;
    private GameObject cubeWrong;
    // Start is called before the first frame update
    void Start()
    {
        // 按名称获取需要控制的两个物体
        cubeCorrect = GameObject.Find("CubeCorrect");
        cubeWrong = GameObject.Find("CubeWrong");
    }

    void Update()
    {

        // 获取按下的按键
        float speed = 5f;
        float forwardCtl = 0f;
        float horizontalCtl = 0f;
        
        if(Input.GetKey(KeyCode.W))
        {
            forwardCtl = 1;
        }else if(Input.GetKey(KeyCode.S))
        {
            forwardCtl = -1;
        }

        if(Input.GetKey(KeyCode.D))
        {
            horizontalCtl = 1;
        }else if(Input.GetKey(KeyCode.A))
        {
            horizontalCtl = -1;
        }

        // 控制物体移动，其中Translate函数需要用向量控制
        Vector3 moveDirection = new Vector3(horizontalCtl,0,forwardCtl);
        moveDirection = moveDirection * Time.deltaTime * speed;
        Vector3 moveDirectionRev = moveDirection * (-1f);
        
        // 在按键按下时才对物体进行移动
        if(forwardCtl != 0f || horizontalCtl != 0f)
        {
            cubeCorrect.transform.Translate(moveDirection);
            cubeWrong.transform.Translate(moveDirectionRev);
        }
        
    }
}
