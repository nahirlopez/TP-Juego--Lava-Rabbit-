using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoplayer : MonoBehaviour
{
    // Start is called before the first frame update
   public float speedZ;
    public float speedgiro;
    public float JumpForce;
    public GameObject Lava;
    float Anguloy;

    AudioSource source;
    public AudioClip YAY;
    public AudioClip chanchan;
    

    Rigidbody rb;
    int hasJump; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = 2;
        source = GetComponent<AudioSource>();
        source.Play();
    }

    
    // Update is called once per frame
    void Update()
    {

        Anguloy = transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(0, Anguloy, 0);

        if (transform.position.y <= 1.535091f)
        {
            transform.position = new Vector3(5.422269f, 3.647719f, -3.427317f);
            transform.eulerAngles = new Vector3(0.486f, -88.15501f, 4.263f);

            Lava.transform.position = new Vector3(-1.7f, -5f, 10f);
            transform.localScale = new Vector3(1.328159f, 1.535091f, 1.451843f);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))

        {
            transform.Translate(0, 0, speedZ);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -speedZ);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, speedgiro, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -speedgiro, 0);
        }
        if (Input.GetKeyDown (KeyCode.Space) && hasJump > 0 ) 
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            hasJump --;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "plataforma")
            hasJump = 2;

        if (col.gameObject.name == "Lava")
        {
            transform.position= new Vector3(5.422269f, 3.647719f, -3.427317f);
            transform.eulerAngles = new Vector3(0.486f, -88.15501f, 4.263f);
            transform.localScale = new Vector3(1.328159f, 1.535091f, 1.451843f);

            
            source.clip = chanchan;
            source.Play();

        }
        if (col.gameObject.tag == "zanahoria")
        {
            transform.localScale = new Vector3 (14.26132f, 14.83979f, 12.83342f);
            transform.position = new Vector3(-22.2f, 91.3f, -8.5f);
            source.clip = YAY;
            source.loop = false;
            source.Play();
            
        }
            
    }

}
