using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    AudioSource audio2;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio2 = GetComponent<AudioSource>();
        TimePassed.instance.Start();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(movimentoHorizontal, movimentoVertical);
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
        TimePassed.instance.TimePassedMethod();
        Debug.Log("time: " + TimePassed.instance.timePassed.ToString());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coletavel")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            GameController.GetCollected();
        }
    }
}
