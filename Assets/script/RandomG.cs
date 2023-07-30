using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomG : MonoBehaviour
{
    [SerializeField] private GameObject[] prifads;
    [SerializeField] private GameObject obeject;
    [SerializeField] private GameObject gg;
    [SerializeField] private int rast;
    [SerializeField] private Config Config;

    void Start()
    {
        gg = GameObject.Find("gg");
        int ran = Random.Range(0, prifads.Length);
        obeject = Instantiate(prifads[ran], transform.position, Quaternion.identity);
        Config = (GameObject.Find("Config")).GetComponent<Config>();
        rast = Config.rast;
    }

    void Update()
    {
        if(Vector3.Distance(gg.transform.position, transform.position) > rast)
        {
            obeject.SetActive(false);
        }
        else
        {
            obeject.SetActive(true);
        }
    }
}
