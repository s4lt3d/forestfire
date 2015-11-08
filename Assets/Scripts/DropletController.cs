using System.Collections;
using UnityEngine;

public class DropletController : MonoBehaviour
{
    public float Lifetime = 2f;

    Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        StartCoroutine(dieAfterLifetime());
    }

    IEnumerator dieAfterLifetime()
    {
        yield return new WaitForSeconds(Lifetime);
        die();
    }

    void die()
    {
        Destroy(gameObject);
    }

    public void Initialize(Vector2 vel)
    {
        _rb.velocity = vel;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.SendMessage(Messages.Splash, SendMessageOptions.DontRequireReceiver);
        die();
    }
}