using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_1 : MonoBehaviour
{
    GameObject Magnifying_Panel = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Magnifying_Panel = GameObject.Find("c").transform.FindChild("Magnifying_Panel").gameObject;
    }


        public void ChangeFirstScene()//창업 시작하기 버튼
    {
        SceneManager.LoadScene("01.Sectors");
    }

    public void Magnifying_Glass()//돋보기 클릭
    {
       Magnifying_Panel.SetActive(true);
    }
    
    public void Magnifying_Glass2()//돋보기 - 확인 클릭
    {
       Magnifying_Panel.SetActive(false);
    }
    public void Convenience()//편의점 선택
    {
        //편의점 클릭시 변수 추가
        SceneManager.LoadScene("02.capital");
    }
    public void cafe()//카페 선택
    {
        //카페 클릭시 변수 추가
        SceneManager.LoadScene("02.capital");
    }
}
