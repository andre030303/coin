using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int jumpspeed;
    [SerializeField] private bool updowm;
    [SerializeField] private GameObject sled;
    [SerializeField] private float time;
    [SerializeField] private float lengthtime;
    [SerializeField] private bool prov1;
    [SerializeField] private bool prov2;
    [SerializeField] private int jump;

    Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.velocity = new Vector2(1,1);
    }

    void Update()
    {
        
        if(time <= 0f)
        {
            Instantiate(sled, transform.position, Quaternion.identity);
            time = lengthtime;
        }
        
        if(time > 0f)
        {
            time -= Time.deltaTime;
        }

        if(prov1 && transform.position.y > jump)
        {
            Rb.velocity = new Vector2(speed,speed);
            prov1 = false;
        }

        if(prov2 && transform.position.y < jump)
        {
            Rb.velocity = new Vector2(speed,-speed);
            prov2 = false;
        }
    }

    public void SuperUp(int perenos)
    {
        Rb.velocity = new Vector2(0,jumpspeed);
        jump = (int)transform.position.y * perenos;
        prov1 = true;
    }

    public void SuperDown(int perenos)
    {
        Rb.velocity = new Vector2(0,-jumpspeed);
        jump = (int)transform.position.y / perenos;
        prov2 = true;
    }

    public void Upd()
    {
        if(!prov1 && !prov2 && !updowm)
        {
            Rb.velocity = new Vector2(speed,-speed);
            updowm = true;
        }
        else if(!prov1 && !prov2)
        {
            Rb.velocity = new Vector2(speed,speed);
            updowm = false;
        }
    }
}
