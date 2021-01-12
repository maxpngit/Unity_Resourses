using UnityEngine;

public class Lever2 : MonoBehaviour {
    bool canOperate;

    Animator anim;
    GameObject accessToDoor, Ethan; 
    private Door doorScript;
    
    void Start() {
        anim = this.transform.parent.GetComponent<Animator>();
        accessToDoor = GameObject.Find("Door_Prefab_Opened");
        doorScript = accessToDoor.GetComponentInChildren<Door>();
        Ethan = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter(Collider other) {
        canOperate = true;
        Debug.Log("Переключение разрешено!");
    }

    void OnTriggerExit(Collider other) {
        canOperate = false;
        Debug.Log("Переключение запрещено!");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && NearTo()) {
            anim.SetBool("Up", true);
            doorScript.isOpened = true;
        }
    }

    bool NearTo() {
        float dist = Vector3.Distance(transform.position, Ethan.transform.position);
        if (dist < 0.7f) return true;
        else return false; 
    }
}
