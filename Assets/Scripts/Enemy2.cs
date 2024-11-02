using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    int direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x < -10)
        {
            direction = 1;
        }
        else 
        {
            direction = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(direction, 0, 0) * Time.deltaTime * 4f);

        if (transform.position.x < -14f || transform.position.x > 14f)
        {
            Destroy(this.gameObject);
        }
    }
}