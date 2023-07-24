using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubG : MonoBehaviour
{
    [SerializeField] private GameObject[] prifads;
    [SerializeField] private GameObject obeject;
    [SerializeField] private GameObject gg;
    [SerializeField] private GameObject win;
    [SerializeField] private int i;
    [SerializeField] private int i2;
    [SerializeField] private bool i3;

    void Start()
    {
        gg = GameObject.Find("gg");
        win = GameObject.Find("win");
        if(transform.position.y < i2 && transform.position.x < win.transform.position.x)
        {
            int ran = Random.Range(0, prifads.Length);
            obeject = Instantiate(prifads[ran], transform.position, Quaternion.identity);
            i3 = true;
        }
    }

    void Update()
    {
        if(i < gg.transform.position.y)
        {
            i+=100;
            i2+=100;
        }
        if(transform.position.y < i2 && transform.position.x < win.transform.position.x && !i3)
        {
            int ran = Random.Range(0, prifads.Length);
            obeject = Instantiate(prifads[ran], transform.position, Quaternion.identity);
            i3 = true;
        }
    }
}
