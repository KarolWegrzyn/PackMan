using System;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))] //wymagany komponent obiektu rigidbody2D

public class PacMan_Movement : MonoBehaviour
{
    public float speed = 8.0f; //predkosc
    public Vector2 initializeDirection; //kierunek ruchu poczatkowego
    public LayerMask obstacleLayer; //warstwa do promieni rayCast
    public new Rigidbody2D rigidbody {  get; private set; } //geterow publicznych, seterow prywatnych
    public Vector2 direction { get; private set; } //aktualny kierunek ruchu
    public Vector2 nextDirection { get; private set; } //nastepny kierunek ruchu
    public Vector3 startPos { get; private set; } //poczatkowa pozycja

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D> ();
        this.startPos = this.transform.position;
    }

    private void Start()
    {
        ResetState();
    }

    public void ResetState()
    {
        this.direction = this.initializeDirection; //ustawienie kierunku na domyslny
        this.nextDirection = Vector2.zero;
        this.transform.position = this.startPos;
        this.rigidbody.isKinematic = false;
        this.enabled = true;
    }

    private void FixedUpdate()
    {
        Vector2 position = this.rigidbody.position; //przypisanie aktualnej pozycji do zmiennej
        Vector2 translation = this.direction * this.speed * Time.fixedDeltaTime; //obliczenie odleg³oœci o ktora gracz ma sie przesunac

        this.rigidbody.MovePosition(position + translation);//przesuniecie gracza
    }

    private void Update()
    {
        if (this.nextDirection != Vector2.zero)
        {
            SetDirection(this.nextDirection);
        }
    }

    public void SetDirection(Vector2 direction, bool forced = false)
    {
        if (forced || !Occupied(direction))
        {
            this.direction = direction;
            this.nextDirection = Vector2.zero;
        }
        else
        {
            this.nextDirection = direction;
        }
    }

    public bool Occupied(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.75f, 0.0f, direction, 1.0f, this.obstacleLayer);
        return hit.collider != null; //zwraca prawde jezeli promien trafi w colider w promieniu 1,75
    }
}
