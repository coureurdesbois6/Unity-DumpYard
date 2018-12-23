using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowObject : MonoBehaviour {
    public GameObject player;
    void Update() {
        print(player.transform.localPosition.x + " " + player.transform.localPosition.y);
        transform.position = new Vector3(player.transform.localPosition.x, player.transform.localPosition.y, transform.localPosition.z);
    }
}
