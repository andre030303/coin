using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winGen : MonoBehaviour
{
    [SerializeField] private GameObject obeject;
    [SerializeField] private GameObject gg;
    [SerializeField] private int i;
    [SerializeField] private int i2;
    [SerializeField] private bool i3;

    void Start()
    {
        gg = GameObject.Find("gg");
        if(transform.position.y < i2)
        {
            Instantiate(obeject, transform.position, Quaternion.identity);
            i3 = true;
        }
    }

    void Update()
    {
        if(i < gg.transform.position.y)
        {
            i+=1000;
            i2+=1000;
        }
        if(transform.position.y < i2 && !i3)
        {
            Instantiate(obeject, transform.position, Quaternion.identity);
            i3 = true;
        }
    }
}
