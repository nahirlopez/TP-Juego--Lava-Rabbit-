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
    public GameObject conejou;
    public GameObject conejo;
    GameObject clon;
   
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

            for(int i=0; i < 20; i++)
            {
                clon = Instantiate(conejou);
                Destroy(clon, 5);
            }
        }

    }

    
}
