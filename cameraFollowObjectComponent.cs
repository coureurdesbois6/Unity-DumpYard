using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowObject : MonoBehaviour {
    public Transform focus;
    void Update() {
        print(focus.localPosition.x + " " + focus.localPosition.y);
        transform.position = new Vector3(focus.localPosition.x, focus.localPosition.y, transform.localPosition.z);
    }
}
