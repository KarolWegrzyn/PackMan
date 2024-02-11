using UnityEngine;

[RequireComponent(typeof(PacMan_Movement))]
public class PacMan : MonoBehaviour
{
    public PacMan_Movement movement {  get; private set; }
    public GameObject pac_Sprite;

    private void Awake()
    {
        this.movement = GetComponent<PacMan_Movement>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.movement.SetDirection(Vector2.up);
            //pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.movement.SetDirection(Vector2.down);
            //pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.movement.SetDirection(Vector2.right);
            //pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.movement.SetDirection(Vector2.left);
            //pac_Sprite.transform.localEulerAngles = new Vector3(0, 180, 0);
        }

        if(movement.direction.x < 0) {
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 180, 0);
        }else if(movement.direction.x > 0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        if (movement.direction.y < 0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, -90);
        }else if (movement.direction.y > 0){
            pac_Sprite.transform.localEulerAngles = new Vector3(0, 0, 90);
        }

    }
}
