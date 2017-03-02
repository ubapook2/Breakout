using UnityEngine;
using System.Collections;

public class SuperBrick3 : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController3>().SuperBrickSmashed();
        GameObject.Destroy(this.gameObject);
    }
}