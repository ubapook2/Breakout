using UnityEngine;
using System.Collections;

public class SuperBrick : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController>().SuperBrickSmashed();
        GameObject.Destroy(this.gameObject);
    }
}
