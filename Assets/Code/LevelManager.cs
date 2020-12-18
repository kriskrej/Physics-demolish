using System;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager currentLevel;
    [SerializeField] HeightMeasure measure;
    [SerializeField] GameObject youWonPopup;

    int blocksToDestroy=3;

    void Start() {
        currentLevel = this;
    }

    public void OnBlockDestroyedHandler() {
        blocksToDestroy--;
        if (blocksToDestroy <= 0)
            ActivateHeightMeasure();
    }

    void ActivateHeightMeasure() {
        measure.gameObject.SetActive(true);
    }

    void Update() {
        if (measure.transform.position.y < 1.7f)
            CongratulatePlayer();
    }

    void CongratulatePlayer() {
        youWonPopup.SetActive(true);
    }
}