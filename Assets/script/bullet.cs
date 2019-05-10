using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public Vector3 dir;

    // Update is called once per frame
    void Update()
    {
       transform.position += dir.normalized * speed*Time.deltaTime;
       transform.rotation = Quaternion.LookRotation(dir);
       transform.Rotate(Vector3.up, -90);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag!="bullet")
        Destroy(gameObject);
    }
}
