using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scet : MonoBehaviour
{
    [SerializeField] private TMP_Text cifra;

    void Update()
    {
        cifra.text = ((int)this.transform.position.y).ToString();
    }
}
