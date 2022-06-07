using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZanaZana : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        mensaje.SetActive(false);
    }
    public GameObject mensaje;
    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "conejito")
        {
            gameObject.SetActive(false);

            mensaje.SetActive(true);
        }

    }
}
