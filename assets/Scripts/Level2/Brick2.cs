using UnityEngine;
using System.Collections;

public class Brick2 : MonoBehaviour {

    //public GameObject prize;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController2>().BrickSmashed();
        GameObject.Destroy(this.gameObject);
       // if (prize != null)
        //{
       //     Instantiate(prize, transform.position, Quaternion.identity);
       // }

    }
}
