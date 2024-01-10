using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed;
    public Rigidbody playerRigidbody;
    public Text CookieCollected;
    public int cookiecount;
    public GameObject cookie;

    // Start is called before the first frame update
    void Start()
    {
        CookieCollected.text = "Cookies Collected = " + cookiecount;
    }

    // Update is called once per frame
    void Update()
    {
        CookieCollected.text = "Cookies Collected = " + cookiecount;
        if (cookiecount >= 4)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(MoveHorizontal, 0, MoveVertical);
        transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hazard")
        {
            SceneManager.LoadScene("GameLose");
        }
        if (other.gameObject.tag == "Cookie")
        {
            Destroy(other.gameObject);
            cookiecount++;

        }
    }
}
