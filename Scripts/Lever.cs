using UnityEngine;

public class Lever : MonoBehaviour {
    
    Animator anim;
    GameObject accessToDoor, Ethan; 
    private Door doorScript;
    
    void Start() {
        anim = GetComponent<Animator>();
        accessToDoor = GameObject.Find("Door_Prefab_Opened");
        doorScript = accessToDoor.GetComponentInChildren<Door>();
        Ethan = GameObject.FindWithTag("Player");
    }
    bool NearTo() {
        float dist = Vector3.Distance(transform.position, Ethan.transform.position);
        if (dist < 2.0f) return true;
        else return false; 
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && NearTo()) {
            anim.SetBool("Up", true);
            doorScript.isOpened = true;
        }
    }
}
