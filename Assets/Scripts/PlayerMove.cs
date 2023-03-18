using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Meteorito;
    public int VelocityPlayer;

    public float TiempoMeteorito;
    private float NuevoMeteorito;

    public GameObject IniBala;
    public GameObject BalaPrefab;
    public float VelBala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NuevoMeteorito <= 0){
            NuevoMeteorito = TiempoMeteorito;
            int MeteoritoPost = Random.Range(-2,3);
            GameObject MeteoritoTemp = Instantiate(Meteorito, new Vector3(MeteoritoPost,10,0),Quaternion.identity); 
            Destroy(MeteoritoTemp, 5);
        }

        NuevoMeteorito -= Time.deltaTime; 

        if (Input.GetKey("d")){
            rb.velocity = transform.right * VelocityPlayer;
        }
        if (Input.GetKey("a")){
            rb.velocity = -transform.right * VelocityPlayer;
        }
        if(Input.GetButtonDown("Fire1")){
            GameObject TempBala = Instantiate(BalaPrefab,IniBala.transform.position,IniBala.transform.rotation);
            Rigidbody TempoRb = TempBala.GetComponent<Rigidbody>();
            TempoRb.AddForce(transform.up * VelBala);
            Destroy(TempBala, 5.0f);
        }
    }
    
}
