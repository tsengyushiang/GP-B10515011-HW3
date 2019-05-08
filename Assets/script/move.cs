using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public float threshold;
    void Awake() {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    void Update()
    {
        float deltaY = Input.acceleration.y + 0.5f;

        if (transform.localPosition.y + deltaY > threshold) return;
        if (transform.localPosition.y + deltaY < -threshold) return;

        //transform.Translate(0, deltaY, 0);
    }
}