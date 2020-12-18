using UnityEngine;

public class DestroyOnClick : MonoBehaviour {
    [SerializeField] GameObject explosionParticlesPrefab;
    void OnMouseDown() {
        Destroy(gameObject);
        LevelManager.currentLevel.OnBlockDestroyedHandler();
        SpawnParticles();
    }

    void SpawnParticles() {
        var p = Instantiate(explosionParticlesPrefab);
        p.transform.position = transform.position;
    }
}