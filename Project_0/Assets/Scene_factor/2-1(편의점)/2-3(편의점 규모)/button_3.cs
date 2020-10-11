using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_3 : MonoBehaviour
{
    void Start()
    {

    }

   
    public void capital()//자본금 수정
    {
        SceneManager.LoadScene("2-2.capital");
    }
    public void next()//다음 단계
    {
        //카페 클릭시 변수 추가
        SceneManager.LoadScene("2-4");
    }
}
