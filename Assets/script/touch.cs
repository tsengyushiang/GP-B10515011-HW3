using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public GameObject bulletPool;
    public GameObject bullet;
    List<Vector3> touches= new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches) {
            Vector3 touchPoint = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (touches.Count < touch.fingerId)
                {
                    touches.Insert(touch.fingerId, touchPoint);
                }
                touches[touch.fingerId] = touchPoint;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                //touches.Insert(touch.fingerId, touchPoint);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                //touches.Insert(touch.fingerId);
            }
        }
        Debug.Log(touches.Count);
        /*
        foreach (Vector3 v in touches) {

            GameObject newbullet =Instantiate(bullet);
            newbullet.transform.position = v;
        }
        */
    }
}
