using UnityEngine;

public class Block : MonoBehaviour {
    
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;

    private void FixedUpdate() {
        rb.velocity = -Vector3.forward * speed;
    }

}
