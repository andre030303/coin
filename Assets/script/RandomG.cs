using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomG : MonoBehaviour
{
    [SerializeField] private GameObject[] prifads;

    void Start()
    {
        int ran = Random.Range(0, prifads.Length);
        Instantiate(prifads[ran], transform.position, Quaternion.identity);
        
    }
}
