using UnityEngine;
using System.Collections;

public class Prize : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        if (collision.gameObject.GetComponent<PaddleController>() != null)
        {
            collision.gameObject.transform.localScale *= 2;
        }

    }



}
