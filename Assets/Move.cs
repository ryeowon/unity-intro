using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(5, 0.5f, 0);
    void Start() {
        //Vector3 vec = new Vector3(0, 0, 0);
        //transform.Translate(vec);
    }
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동 멈춤");

        if (Input.GetMouseButtonUp(0)) //0은 왼쪽 버튼, 1은 오른쪽 버튼
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중 ...");

        if (Input.GetButtonUp("Jump")) //Edit - project setting - input manager 에서 확인 가능
            Debug.Log("점프!!!");
        */

        transform.Translate(new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*3, 0, Input.GetAxis("Vertical")*Time.deltaTime*3));

        if (transform.position.x > 5 || transform.position.x < -5 || 
            transform.position.z > 5 || transform.position.z < -5 || transform.position.y < 0.5f)
            transform.Translate(new Vector3(0, -0.1f, 0));

        if (transform.position.y < -10)
            transform.position = new Vector3(0, 0.5f, 0);

        //transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);

        //Vector3 velo = Vector3.zero;

        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.5f);

        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        //transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
