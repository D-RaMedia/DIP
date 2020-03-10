using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float newY = 7.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            newY += 1;
        }
        Vector3 desiredPosition = new Vector3(0, newY, 12.5f);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, 1f * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
