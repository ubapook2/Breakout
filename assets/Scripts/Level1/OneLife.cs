using UnityEngine;
using System.Collections;

public class OneLife : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController>().GiveLife();
        GameObject.Destroy(this.gameObject);
    }
}
