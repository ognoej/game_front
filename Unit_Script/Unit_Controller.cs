using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Controller : MonoBehaviour
{
    public string unit_name;
    public float max_hp;
    public float max_mp;
    public float dmg;
    public float move_speed = 0;
    public float attack_speed;

    public int now_state = 1;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetTrigger("move");
    }


    float attack_time = 0f;
    float attack_time2 = 0f;
    // Update is called once per frame
    void Update()
    {
        attack_time += Time.deltaTime;
        if(attack_time>=5)
        {
            now_state = 2;
           // attack_time = 0;
        }
      switch(now_state)
      {
          case 1:
              {
                    //print("sibal");
                    //GetComponent<Animator>().SetTrigger("move");
                    gameObject.transform.Translate(move_speed * Time.deltaTime, 0, 0);
                    //print("shibal");
                    //gameObject.transform.position += new Vector3(move_speed * Time.deltaTime, 0, 0);
                    //print(move_speed);
                  break;
              }
            case 2:
                {
                    attack_time2 += Time.deltaTime;
                    if (attack_time2 > 3.0f)
                    {
                        GetComponent<Animator>().SetTrigger("attack");
                       // print("attack");
                        attack_time2 = 0;
                    }                    
                    break;
                }
      }

    }
}
