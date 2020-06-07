//Basic
public Transform player;
    public Vector3 offset;
    void Update()
    {
        if (player.position.y > 13)
        {
            transform.position = new Vector3(0, player.position.y + offset.y, offset.z);
        }
    }

//Look At
public GameObject Player;
void Update()
{
    transform.position = new Vector3(Player.transform.position.x/12, Player.transform.position.y / 12, Player.transform.position.z / 12) *50;
    transform.LookAt(Vector3.zero, Player.GetComponent<PlayerControl>().UpDirection);
}

//Camera rotate for PC
camera.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
camera.transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);