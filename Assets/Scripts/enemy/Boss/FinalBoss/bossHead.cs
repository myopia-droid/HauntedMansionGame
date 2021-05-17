using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHead : MonoBehaviour
{
    public Sprite head1;
    public Sprite head2;
    private SpriteRenderer sR;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        //head1.GetComponent<Renderer>().enabled==true;
        //head2.GetComponent<Renderer>().enabled==false;
        this.timer = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.timer < 60.0f){
           sR.sprite = head1;    
        }
        if(this.timer > 60.0f){
            sR.sprite = head2;
        }
    }
}
