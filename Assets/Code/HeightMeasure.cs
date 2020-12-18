using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeightMeasure : MonoBehaviour {
    [SerializeField] TMP_Text label;

    void Update() {
        var height = transform.position.y*4;
        label.text = height.ToString("0.0") + "m";
    }
}