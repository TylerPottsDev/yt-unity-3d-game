using UnityEngine;

public class GC : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Danger") {
            Destroy(other.gameObject);
        }
    }
}
