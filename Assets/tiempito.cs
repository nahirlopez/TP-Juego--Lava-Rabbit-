using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempito : MonoBehaviour
{
    public Text tiempo;
    bool iscounting;
    float customtime;
    public GameObject conejo;
    public Text tiempofinal;
    // Start is called before the first frame update
    void Start()
    {
        iscounting = true;
        customtime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //float time = Time.time;
        //tiempo.text = Mathf.Floor(time).ToString() + " segs";

        if (iscounting) {
            //customtime += Mathf.Floor(Time.deltaTime);
            customtime += Time.deltaTime;
        }
        tiempo.text = customtime.ToString() + " segundos";

            if (conejo.transform.localScale ==new Vector3(14.26132f, 14.83979f, 12.83342f))
        {
            iscounting = false;
            tiempofinal.text = "¡En tan solo " + tiempo.text + "!"; 
            
        }

            if (tiempofinal.IsActive() == false)
        {
            iscounting = true;
        }

            if (conejo.transform.position == new Vector3(5.422269f, 3.647719f, -3.427317f))
        {
            customtime = 0;
        }



    }
}
