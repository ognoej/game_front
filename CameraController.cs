using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    float CameraSpeed = 5f;

    [SerializeField]
    GameObject BckImg;

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            if(transform.position.x >=16)
            {
                return;
            }
            transform.Translate(new Vector3(CameraSpeed *Time.deltaTime, 0, 0));
            BckImg.transform.Translate(new Vector3(CameraSpeed  * Time.deltaTime*1.1f, 0, 0));
       }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x <= 0.6)
            {
                return;
            }
            transform.Translate(new Vector3(-(CameraSpeed  * Time.deltaTime), 0, 0));
            BckImg.transform.Translate(new Vector3(-(CameraSpeed  * Time.deltaTime*1.1f), 0, 0));
        }
    }
}
