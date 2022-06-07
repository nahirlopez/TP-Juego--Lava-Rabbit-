using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempito : MonoBehaviour
{
    public Text tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        tiempo.text = Mathf.Floor(time).ToString() + " ";
            
    }
}
