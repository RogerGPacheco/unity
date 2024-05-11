using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMove : MonoBehaviour
{
    public float maxy;
    public float miny;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > maxy || transform.position.y < miny)
        {
            Destroy(this.gameObject);
        }
    }
}
