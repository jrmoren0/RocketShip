using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spin : MonoBehaviour
{
 
   //public Transform earth;


   public float spinSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0,spinSpeed * Time.deltaTime,0);
    
    }
}
