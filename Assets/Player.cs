using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    
    [SerializeField] float speed;
    Vector3 target;

    private void Start() {
        target = transform.position;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.A) && target.x > -5) {
            target += new Vector3(-5, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D) && target.x < 5) {
            target += new Vector3(5, 0, 0);
        }

        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Danger") {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
