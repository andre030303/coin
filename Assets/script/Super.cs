using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super : MonoBehaviour
{
    [SerializeField] private bool up;
    [SerializeField] private int jump;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(up)
            {
                collision.gameObject.GetComponent<wasd>().SuperUp(jump);
            }
            else
            {
                collision.gameObject.GetComponent<wasd>().SuperDown(jump);
            }
            
        }
    }

}
