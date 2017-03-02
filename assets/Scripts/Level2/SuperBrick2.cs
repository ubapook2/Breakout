using UnityEngine;
using System.Collections;

public class SuperBrick2 : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController2>().SuperBrickSmashed();
        GameObject.Destroy(this.gameObject);
    }
}
