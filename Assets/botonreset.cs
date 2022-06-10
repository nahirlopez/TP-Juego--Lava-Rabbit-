using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonreset : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject conejo;
    public GameObject lava;
    public GameObject mensaje;
    public AudioSource source;
    public GameObject zamahoria;
    public GameObject conejou;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetear()
    {
        Destroy(conejou);
        mensaje.SetActive(false);
        zamahoria.SetActive(true);
        lava.transform.position = new Vector3(-1.7f, -5f, 10f);
        conejo.transform.position = new Vector3(5.422269f, 3.647719f, -3.427317f);
        conejo.transform.eulerAngles = new Vector3(0.486f, -88.15501f, 4.263f);
        conejo.transform.localScale = new Vector3(1.328159f, 1.535091f, 1.451843f);
        source.Play();
}

}
