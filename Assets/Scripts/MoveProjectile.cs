using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] float rotateSpeed = 1f;
    [SerializeField] int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);
        transform.Rotate(0, 0, -rotateSpeed);
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        Attacker attacker = otherObject.gameObject.GetComponent<Attacker>();
        attacker.ProcessDamage(damage);
        Destroy(gameObject);
    }
}
