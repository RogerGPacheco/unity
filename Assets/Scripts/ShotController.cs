using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public GameObject tiroPreFab;
    public float forceSpeedFire;
    public bool isPlayer;
    private float currentTime;
    public float shootInterval;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentTime += Time.deltaTime;

         if (Input.GetButton("Fire1") && isPlayer)
         {
            if (currentTime >= shootInterval)
            {
               currentTime = 0;
                Atirar();
            }
         }
    }

    public void Atirar()
    {
        GameObject tempTiro = Instantiate(tiroPreFab) as GameObject;
        tempTiro.transform.position = transform.position;

        tempTiro.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forceSpeedFire));
    }
}
