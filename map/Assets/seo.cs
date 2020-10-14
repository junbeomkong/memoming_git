using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class seo : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Transform d;
    public Transform n;
    public Transform ds;
    public Transform seo1;
    int num;
   
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData data)
    {
        seo1.GetComponent<Image>().color = new Color(135 / 255f, 144 / 255f, 185 / 255f);
    }
    public void OnPointerExit(PointerEventData data1)
    {
        seo1.GetComponent<Image>().color = new Color(255 / 255f, 255 / 255f, 255 / 255f);
    }
    public void OnPointerDown(PointerEventData data2)
    {
        if (num < 1)
        {
            num++;
            seo1.GetComponent<RectTransform>().localScale += new Vector3(1.0f, 1.0f, 1.0f);
            n.gameObject.SetActive(false);
            d.gameObject.SetActive(false);
            ds.gameObject.SetActive(false);
        }
        else if (num >= 1)
        {
            num--;
            seo1.GetComponent<RectTransform>().localScale -= new Vector3(1.0f, 1.0f, 1.0f);
            n.gameObject.SetActive(true);
            d.gameObject.SetActive(true);
            ds.gameObject.SetActive(true);
        }
    }
}
