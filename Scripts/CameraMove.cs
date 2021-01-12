using UnityEngine;

public class CameraMove: MonoBehaviour {

    [SerializeField]
    private float mouseSens = 0.4f;
    [SerializeField]
    private float moveSpeed = 2f;

    private Vector3 mousePrevPos;
    private float rotX;
    private float rotY;

    void Update() {
        Move();
        Rotate();
    }

    void Move() {

        float shiftMult = 1f;

        if (Input.GetKey(KeyCode.LeftShift)) {
            shiftMult = 3f;
        }

        float right = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");
        float up = 0;
        
        if (Input.GetKey(KeyCode.E)) {
            up = 1f;
        } else if (Input.GetKey(KeyCode.C)) {
            up = -1f;
        }

        Vector3 offset = new Vector3(right, up, forward) * moveSpeed * shiftMult * Time.unscaledDeltaTime;
        transform.Translate(offset);
    }

    void Rotate() {

        Vector3 mouseDelta;

        if (Input.GetMouseButtonDown(1)) {
            mousePrevPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(1)) {
            mouseDelta = Input.mousePosition - mousePrevPos;
            mousePrevPos = Input.mousePosition;

            rotX -= mouseDelta.y * mouseSens;
            rotY += mouseDelta.x * mouseSens;

            transform.localEulerAngles = new Vector3(rotX, rotY, 0f);
        }
    }

}
