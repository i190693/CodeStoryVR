using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightLimit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, 2.0f, transform.localPosition.z);

    }
}
