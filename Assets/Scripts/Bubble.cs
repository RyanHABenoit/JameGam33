using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private float speed;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        Invoke("Pop", 4.0f);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
    }

    public void Pop()
    {
        anim.Play("BubblePop");
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
