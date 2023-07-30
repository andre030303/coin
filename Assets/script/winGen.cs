using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winGen : MonoBehaviour
{
    [SerializeField] private GameObject obeject;
    [SerializeField] private GameObject gg;
    [SerializeField] private int linespawn;
    [SerializeField] private int lineend;
    [SerializeField] private bool spawn;
    [SerializeField] private Config Config;

    void Start()
    {
        gg = GameObject.Find("gg");
        Config = (GameObject.Find("Config")).GetComponent<Config>();
        linespawn = Config.linespawn;
        lineend = Config.lineend;
        if(transform.position.y < lineend)
        {
            Instantiate(obeject, transform.position, Quaternion.identity);
            spawn = true;
        }
    }

    void Update()
    {
        if(linespawn < gg.transform.position.y)
        {
            linespawn+=1000;
            lineend+=1000;
        }
        if(transform.position.y < lineend && !spawn)
        {
            Instantiate(obeject, transform.position, Quaternion.identity);
            spawn = true;
        }
    }
}
