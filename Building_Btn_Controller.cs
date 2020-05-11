using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building_Btn_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public string Building_name;
    public Image m_image;
    //public Sprite m_sprite;


    void Start()
    {
        m_image = gameObject.GetComponentInChildren<Image>();
       // gameObject.GetComponent<SpriteRenderer>().sprite = m_image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Building_Btn_Down()
    {       
    }

}
