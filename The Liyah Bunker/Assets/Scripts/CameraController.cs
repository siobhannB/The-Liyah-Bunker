using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; //make sure to drag player into target slot on under camera script
                             //make sure to add pixelsnap material to material in tilemap renderer for pixel art/grid.  

    void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }

}
