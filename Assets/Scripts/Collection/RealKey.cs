<<<<<<< HEAD
<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealKey : MonoBehaviour
{
    public GameObject key;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
          
          Destroy(key);       
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealKey : MonoBehaviour
{
    public GameObject key;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
          
          Destroy(key);       
        }
    }
}
>>>>>>> ed4648a097820aeb8aa537bfa568111cdb6bb006
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealKey : MonoBehaviour
{
    public GameObject key;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
          
          Destroy(key);       
        }
    }
}
>>>>>>> ed4648a097820aeb8aa537bfa568111cdb6bb006
