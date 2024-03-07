using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera c1;
    public Camera c3;

    private bool cam1 = false;
    public GameObject thrust;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            switchCamera();
        }
        if(cam1){
            thrust.SetActive(true);
        }
        else{
            thrust.SetActive(false);
        }
    }

    private void switchCamera(){
        if(cam1){
            cam1 = false;
            
        }
        else{
            cam1 = true;
        }

        c1.enabled = !c1.enabled;
        c3.enabled = !c3.enabled;
        
    }
}
