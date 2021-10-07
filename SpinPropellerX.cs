using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour {
    public GameObject propeller;

    void Update() {
        propeller.transform.Rotate(0, 0, 40);
    }
}