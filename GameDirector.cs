using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    [SerializeField]
    GameObject Building_UI;

    [SerializeField]
    GameObject Building_Btn_1;

    [SerializeField]
    GameObject Building_Btn_2;

    [SerializeField]
    GameObject Building_Btn_3;

    [SerializeField]
    GameObject Building_Btn_4;

    [SerializeField]
    GameObject[] building_prefab;


    [SerializeField]
    GameObject[] Builing_Spot;

    List<GameObject> m_Builing_spot_List;
    List<GameObject> m_my_Unit_List;

    // Start is called before the first frame update
    void Start()
    {
        m_Builing_spot_List = new List<GameObject>();
        m_my_Unit_List = new List<GameObject>();
        m_Builing_spot_List.AddRange(Builing_Spot);

        int j = 0;
        foreach(var i in m_Builing_spot_List)
        {
            i.GetComponent<Builing_Spot_Controller>()._index = j;
            j++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Color new_alpha;
    public void Builing_Btn_Down(int _num)
    {
        print(_num);
        switch (_num)
        {
            case 1:
                {
                    foreach (var i in m_Builing_spot_List)
                    {
                        if(i.GetComponent<Builing_Spot_Controller>().Ocupied == true)
                        {
                            continue;
                        }
                        var new_alpha_builing = Instantiate(building_prefab[0]);
                        new_alpha_builing.GetComponent<Building_Controller>().builing_type = 1;
                        new_alpha_builing.transform.SetParent(i.transform);
                        new_alpha_builing.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                        new_alpha_builing.transform.localPosition = new Vector3(0, 0, 0);
                        new_alpha = new_alpha_builing.GetComponent<SpriteRenderer>().color;
                        new_alpha = new Color(255, 255, 255, 0.5f);
                        new_alpha_builing.GetComponent<SpriteRenderer>().color = new_alpha;

                    }
                    break;
                }
            case 2:
                {
                    foreach (var i in m_Builing_spot_List)
                    {
                        if (i.GetComponent<Builing_Spot_Controller>().Ocupied == true)
                        {
                            continue;
                        }
                        var new_alpha_builing = Instantiate(building_prefab[1]);
                        new_alpha_builing.GetComponent<Building_Controller>().builing_type = 2;
                        new_alpha_builing.transform.SetParent(i.transform);
                        new_alpha_builing.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                        new_alpha_builing.transform.localPosition = new Vector3(0, 0, 0);
                        new_alpha = new_alpha_builing.GetComponent<SpriteRenderer>().color;
                        new_alpha = new Color(255, 255, 255, 0.5f);
                        new_alpha_builing.GetComponent<SpriteRenderer>().color = new_alpha;


                    }
                    break;
                }
            case 3:
                {
                    foreach (var i in m_Builing_spot_List)
                    {
                        if (i.GetComponent<Builing_Spot_Controller>().Ocupied == true)
                        {
                            continue;
                        }
                        var new_alpha_builing = Instantiate(building_prefab[2]);
                        new_alpha_builing.GetComponent<Building_Controller>().builing_type = 3;
                        new_alpha_builing.transform.SetParent(i.transform);
                        new_alpha_builing.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                        new_alpha_builing.transform.localPosition = new Vector3(0, 0, 0);
                        new_alpha = new_alpha_builing.GetComponent<SpriteRenderer>().color;
                        new_alpha = new Color(255, 255, 255, 0.5f);
                        new_alpha_builing.GetComponent<SpriteRenderer>().color = new_alpha;
                    }
                    break;
                }

            case 4:
                {
                    foreach (var i in m_Builing_spot_List)
                    {
                        if (i.GetComponent<Builing_Spot_Controller>().Ocupied == true)
                        {
                            continue;
                        }
                        var new_alpha_builing = Instantiate(building_prefab[3]);
                        new_alpha_builing.GetComponent<Building_Controller>().builing_type = 4;
                        new_alpha_builing.transform.SetParent(i.transform);
                        new_alpha_builing.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                        new_alpha_builing.transform.localPosition = new Vector3(0, 0, 0);
                        new_alpha = new_alpha_builing.GetComponent<SpriteRenderer>().color;
                        new_alpha = new Color(255, 255, 255, 0.5f);
                        new_alpha_builing.GetComponent<SpriteRenderer>().color = new_alpha;

                    }
                    break;
                }

        }
    }



    public void Add_UnitList(GameObject _new_unit)
    {
       // m_my_Unit_List.Add(_new_unit);
    }



    public void Builing_Complete(int _num)
    {
        print(_num);
        for(int i =0; i<9;i++)
        {
            var child_builing = Builing_Spot[i].transform.GetChild(0).gameObject;
            if (_num == i)
            {
                Builing_Spot[i].GetComponent<Builing_Spot_Controller>().Ocupied = true;
                new_alpha = child_builing.GetComponent<SpriteRenderer>().color;
                new_alpha = new Color(255, 255, 255, 1f);
                child_builing.GetComponent<SpriteRenderer>().color = new_alpha;
                continue;
            }
            if(Builing_Spot[i].GetComponent<Builing_Spot_Controller>().Ocupied==true)
            {
                continue;
            }
            Destroy(child_builing);
        }

    }




    bool isBuilidng_Ui_BtnDown = false;

    public void Building_UI_Down()
    {
        if (isBuilidng_Ui_BtnDown == false)
        {
            Building_Btn_1.SetActive(true);
            Building_Btn_2.SetActive(true);
            Building_Btn_3.SetActive(true);
            Building_Btn_4.SetActive(true);
            isBuilidng_Ui_BtnDown = true;
        }
        else
        {
            Building_Btn_1.SetActive(false);
            Building_Btn_2.SetActive(false);
            Building_Btn_3.SetActive(false);
            Building_Btn_4.SetActive(false);
            isBuilidng_Ui_BtnDown = false;
        }

    }
}
