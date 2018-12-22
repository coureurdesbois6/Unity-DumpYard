using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionAll : MonoBehaviour
{
    public Vector3 position;
    void Start()
    {
        for (int i = 0; i <= transform.childCount-1; i++) {
            transform.GetChild(i).transform.position = position;
        }
    }
}
