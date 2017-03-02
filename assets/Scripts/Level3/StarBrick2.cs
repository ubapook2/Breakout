using UnityEngine;
using System.Collections;

public class StarBrick2 : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController3>().StarBrickSmashed();
        GameObject.Destroy(this.gameObject);
    }

}
