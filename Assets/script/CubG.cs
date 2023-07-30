using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubG : MonoBehaviour
{
    [SerializeField] private GameObject[] prifads;
    [SerializeField] private GameObject obeject;
    [SerializeField] private GameObject gg;
    [SerializeField] private GameObject win;
    [SerializeField] private int linespawn;
    [SerializeField] private int lineend;
    [SerializeField] private bool spawn;
    [SerializeField] private Config Config;

    void Start()
    {
        gg = GameObject.Find("gg");
        win = GameObject.Find("win");
        Config = (GameObject.Find("Config")).GetComponent<Config>();
        linespawn = Config.linespawn;
        lineend = Config.lineend;
        if(transform.position.y < lineend && transform.position.x < win.transform.position.x)
        {
            int ran = Random.Range(0, prifads.Length);
            obeject = Instantiate(prifads[ran], transform.position, Quaternion.identity);
            spawn = true;
        }
    }

    void Update()
    {
        if(linespawn < gg.transform.position.y)
        {
            linespawn+=100;
            lineend+=100;
        }
        if(transform.position.y < lineend && transform.position.x < win.transform.position.x && !spawn)
        {
            int ran = Random.Range(0, prifads.Length);
            obeject = Instantiate(prifads[ran], transform.position, Quaternion.identity);
            spawn = true;
        }
    }
}
