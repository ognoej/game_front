using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Building_Controller : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    GameObject m_Swordman;


    public int builing_level = 0;
    public int builing_type = 0;
    public float generate_time = 5.0f;
    public float m_nowtime = 0.0f;

    bool isComplete = false;

    public void OnMouseDown()
    {
        if(isComplete==true)
        {
            return;
        }
        GameObject.Find("GameDirector").GetComponent<GameDirector>().SendMessage("Builing_Complete", gameObject.GetComponentInParent<Builing_Spot_Controller>()._index);
        isComplete = true;
    }



    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(isComplete==false)
        {
            return;
        }

        m_nowtime += Time.deltaTime;
        //print(m_nowtime);

       
       // print(generate_time);
        if (m_nowtime>=generate_time)
        {
            m_nowtime -= generate_time;
            var new_unit = Instantiate(m_Swordman, transform.position, Quaternion.identity) as GameObject;
           // new_unit.transform.localScale = new Vector3(1, 1, 1);

            //print(gameObject.transform.localPosition);
            //new_unit.transform.SetParent(gameObject.transform);
            //print(transform.position);
            // new_unit.transform.position = transform.position;
            // print(new_unit.transform.position);
            //print( transform.TransformPoint(transform.position));
            //new_unit.transform.localScale = new Vector3(-1, 1, 1);
            //print(new_unit.transform.position);
            var unit_info = new_unit.GetComponent<Unit_Controller>();
            unit_info.max_hp = 100.0f;
            unit_info.move_speed = 1.0f;

            
            GameObject.Find("GameDirector").GetComponent<GameDirector>().SendMessage("Add_UnitList", new_unit);
        }   
        
    }
}
