using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDoor : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
        door.GetComponent<Renderer>().enabled=false;
    }

}
