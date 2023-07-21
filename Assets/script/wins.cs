using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wins : MonoBehaviour
{
    [SerializeField] private GameObject winmemu;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            winmemu.SetActive(true);
        }
    }
}
