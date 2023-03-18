using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMeteorito : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){

        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Player" || collision.gameObject.name=="Piso"){
            ResetScene();
        }
    }
    void ResetScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
