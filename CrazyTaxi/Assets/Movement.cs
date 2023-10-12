using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public float rotDegrees = 0.5f;
    [SerializeField] public Rigidbody cabinRigidbody;
    [SerializeField] private Vector3 relativeFwd;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        relativeFwd = cabinRigidbody.transform.TransformDirection(Vector3.forward);
        
           if (Input.GetKey("w"))
           cabinRigidbody.transform.eulerAngles = new Vector3(
           cabinRigidbody.transform.eulerAngles.x - rotDegrees,
            cabinRigidbody.transform.eulerAngles.y ,
            cabinRigidbody.transform.eulerAngles.z) ;

           if ( Input.GetKey("s"))
           {
               cabinRigidbody.transform.eulerAngles = new Vector3(
                   cabinRigidbody.transform.eulerAngles.x + rotDegrees,
                   cabinRigidbody.transform.eulerAngles.y ,
                   cabinRigidbody.transform.eulerAngles.z) ;
           }

           if (Input.GetKey("d"))
           {
               cabinRigidbody.transform.eulerAngles = new Vector3(
                   cabinRigidbody.transform.eulerAngles.x ,
                   cabinRigidbody.transform.eulerAngles.y + rotDegrees ,
                   cabinRigidbody.transform.eulerAngles.z) ;     

           }

           if (Input.GetKey("a"))
           {
               cabinRigidbody.transform.eulerAngles = new Vector3(
                   cabinRigidbody.transform.eulerAngles.x ,
                   cabinRigidbody.transform.eulerAngles.y - rotDegrees ,
                   cabinRigidbody.transform.eulerAngles.z) ;
           }

           if (Input.GetKey("space"))
           {
               cabinRigidbody.velocity = relativeFwd * speed * maxSpeed;
           }
           
           if (Input.GetKeyUp("space"))
           {
               cabinRigidbody.velocity = relativeFwd * speed * maxSpeed / 2;
           }

           if (Input.GetKey("e"))
           {
               cabinRigidbody.velocity = Vector3.zero;
           }
                     
    }
}
