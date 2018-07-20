using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed; // this will show up in the editor, so you dont have to go through code every time u want to modify this value.
    public Text countText; // for UI count text
    public Text winText;

    private Rigidbody rb;
    private int count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
    }

    //void Update () // Called before rendering a frame, so it is where game code is (hence not needed for this case, we are using rigidbody, physics based)
    //{

    //}

    private void FixedUpdate() // called before any physics calculation, so this is where physics goes
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce (movement * speed);
    }

    // could use collider to check collisions
    private void OnTriggerEnter(Collider other) // 'other' is what collider we are touching (when touching another trigger collider, do...)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
        else if (other.gameObject.CompareTag("Death"))
        {
            winText.text = "You Lost!";
            Destroy(this);
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 17)
        {
            winText.text = "You Win!";
        }
    }
}
