using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subirlava : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float vel;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < (50.4))
        {
            transform.Translate(0, vel, 0);

        }
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "conejito")
        {
            transform.position = new Vector3(-1.7f, -5f, 10f);
        }
    }
}
