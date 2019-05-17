using UnityEngine;
using System.Collections;

public class MovCamara : MonoBehaviour
{

    Vector2 touchDeltaPosition;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float pointer_x = Input.GetAxis("Mouse X");
            float pointer_y = Input.GetAxis("Mouse Y");
            transform.Translate(-pointer_x * 0.5f,
                        -pointer_y * 0.5f, 0);
        }
    }
}