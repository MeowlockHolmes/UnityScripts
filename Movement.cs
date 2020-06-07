//Jump Force
 rb.velocity = Vector2.up * jumpforce;

//Change Position in time
 transform.position += movement * Time.deltaTime * speed;

//Movement Type for PC 1
moveInput = Input.GetAxis("Horizontal");       
Vector3 movement = new Vector3(moveInput, 0f, 0f);
transform.position += movement * Time.deltaTime * speed;

//Movement Type for PC 2
Vector2 vektor = new Vector2(sidewaysForce * Time.deltaTime, 0);
if (Input.GetKey(KeyCode.RightArrow)){
    rb.AddForce(new Vector2(sidewaysForce,0),ForceMode2D.Force);
}
else if (Input.GetKey(KeyCode.LeftArrow)){
    rb.AddForce(new Vector2(-sidewaysForce, 0), ForceMode2D.Force);
}

//Movement Type for PC 3
if (Input.GetKey(KeyCode.RightArrow))
    {
        rb.AddForce(sidewaysForce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
    }

//Movement Type for PC 4
rb.MovePosition(a.transform.position+new Vector3(0,0, speed * Time.deltaTime));

//AddForce
rb.AddForce(0, 0, forwardForce * Time.deltaTime);

// Flip
void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }

//Move body with camera movement
player.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

//Move on sphere (Kinda , Doesn't work correctly)
Vector3 origin = Vector3.zero;
Quaternion hq = Quaternion.AngleAxis(-horizontal, UpDirection);
Quaternion vq = Quaternion.AngleAxis(vertical, RightDirection);
Quaternion q = hq * vq;
rb.MovePosition(q * (rb.transform.position - origin) + origin);

