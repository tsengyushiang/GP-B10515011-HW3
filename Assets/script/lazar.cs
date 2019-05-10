using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazar : MonoBehaviour
{
    public GameObject sprite;
    public float factor;
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.right, 100); ;
        if (hit.collider&& hit.collider.gameObject.tag!="bullet")
        {
            //Debug.DrawLine(transform.position, hit.point, Color.red, 0.1f, true);
            sprite.transform.localScale=new Vector3((hit.point.x - transform.position.x) * factor,2,1);

            if (hit.collider.gameObject.GetComponent<enemy>()) {
                hit.collider.gameObject.GetComponent<enemy>().demage(1f);
            }
        }
    }

}
