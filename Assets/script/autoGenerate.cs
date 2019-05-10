using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoGenerate : MonoBehaviour
{
    public GameObject[] items;    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.childCount);
    }
}
