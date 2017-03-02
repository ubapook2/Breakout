using UnityEngine;
using System.Collections;

public class Brick3 : MonoBehaviour
{

    //public GameObject prize;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController3>().BrickSmashed();
        GameObject.Destroy(this.gameObject);
        // if (prize != null)
        //{
        //     Instantiate(prize, transform.position, Quaternion.identity);
        // }

    }
}
