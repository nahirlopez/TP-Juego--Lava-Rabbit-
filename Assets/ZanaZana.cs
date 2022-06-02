using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZanaZana : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "conejito")
        {
            Destroy(gameObject);
            //delay ewd

        }

    }
}
