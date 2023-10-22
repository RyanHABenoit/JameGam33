using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    Vector3 startScale;
    [SerializeField] GameObject pauseMenu;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        startScale = transform.localScale;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip player when facing left/right.
        if (horizontalInput > 0.01f)
            transform.localScale = startScale;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(startScale.x * -1, startScale.y, startScale.z);

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            //open pause menu
            pauseMenu.SetActive(true);
        }
    }
}
