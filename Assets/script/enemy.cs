using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public Text remainBlood;
    public float blood;
    public float speed;

    void Start() {
        demage(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right.normalized * speed * Time.deltaTime;
        if (transform.position.x < -15)
            transform.position =new Vector3(15,transform.position.y,transform.position.z);
    }

    public void demage(float damage) {

        blood -= damage;

        if (blood < 1)
            Destroy(gameObject);

        int bloodint = (int)blood;
        remainBlood.text = bloodint.ToString();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
            demage(10);
    }
}
