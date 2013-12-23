using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    public float speed = 30.0F;
    public float smooth = 0.1F;
    void Update() {
        float Around = Input.GetAxis("Vertical") * speed;
        transform.Rotate(Around, 0, 0);
    }
}