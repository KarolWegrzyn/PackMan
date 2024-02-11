using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PackMan_Controller : MonoBehaviour
{
    [SerializeField] float Speed;
    private Rigidbody2D rb;
    public GameObject pac_Sprite;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * Time.deltaTime * Speed * verticalInput); //gora, dol
        transform.Translate(Vector3.right * Time.deltaTime * Speed * horizontalInput); //prawo lewo 

        if(verticalInput>0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, 90);
        }
        else if(verticalInput<0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, -90);
        }

        if (horizontalInput>0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, 0);
        }else if (horizontalInput<0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 180, 0);
        }

    }
}
