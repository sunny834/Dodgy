using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    MeshRenderer rend;
    Rigidbody rigid;
    [SerializeField] float timeToWait=5f;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();

        rend.enabled = false;
        rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Time.time > timeToWait)
        {
        rend.enabled = true;
        rigid.useGravity = true;
           
        }
        
     }
        
}
