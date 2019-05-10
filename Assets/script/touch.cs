using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public float coolDown;
    private float accum;
    public GameObject bulletPool;
    public GameObject bullet;
    List<Vector3> touches= new List<Vector3>();

    void Awake() {
         accum=0;
    }
    // Update is called once per frame
    void Update()
    {
        accum += Time.deltaTime;

        foreach (Touch touch in Input.touches) {
            Vector3 touchPoint = Camera.main.ScreenToWorldPoint(touch.position);
            touchPoint.z = 0;
            if (touch.phase == TouchPhase.Began)
            {
                if (touches.Count - 1 < touch.fingerId)
                {
                    touches.Add(Vector3.zero);
                    touches[touch.fingerId] = touchPoint;
                }
                else
                {
                    touches[touch.fingerId] = touchPoint;
                }
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                touches[touch.fingerId] = touchPoint;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                touches[touch.fingerId] = new Vector3(0, 0,-10);
            }
        }

        if (accum > coolDown)
        {
            foreach (Vector3 v in touches)
            {
                if (v.z !=0 ) continue;
                GameObject newbullet = Instantiate(bullet);
                newbullet.transform.position = bulletPool.transform.position;
                newbullet.GetComponent<bullet>().speed = 5;
                newbullet.GetComponent<bullet>().dir = v- newbullet.transform.position;
                
            }
            accum = 0;
        }
    }
}
