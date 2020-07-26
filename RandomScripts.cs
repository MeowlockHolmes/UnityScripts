//Basic Function
public void functionName(GameObject a, GameObject b)
    {
    }

//Debug
 Debug.Log(a);

//Position of Object
a.GetComponent<Transform>().position.x;

//Set child for one the object
a.transform.parent = transform;

//Find Child Count
a.transform.childCount;

//Get Child
a.transform.GetChild(i);

//Creating object
GameObject a = Instantiate(prefab, pointOne.transform.position,Quaternion.identity);

//Destroy object
DestroyImmediate(a.gameObject);

//Destroy child
DestroyImmediate(a.transform.GetChild(i).gameObject);

//Math Functions
Mathf.Pow(a,2);
Mathf.Sqrt(a,2);
Random.Range(1, 3);

//Rotate 180 
a.transform.Rotate(Vector3.up*180);

//Animation bool (Animator)
animator.SetBool("Jump", true);

//Collision get tag
 if (collision.collider.tag == "Wall"){}

 //Change Time Scale
 Time.timeScale = 0f;

//Change Rigidbody Constraints
 rb.constraints = ~RigidbodyConstraints.FreezeAll;

//Call function from other objects
FindObjectOfType<Manage>().EndGame();

//Call function in same script
Invoke("functionName", delaytime);

//Scenes (Add using UnityEngine.SceneManagement; to the top)
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //next lwl
SceneManager.LoadScene(SceneManager.GetActiveScene().name);             //restart lwl

//Change Text of textobject (Add using UnityEngine.UI; to the top)
txt.text = "text";

//Activate object
a.SetActive(true);

//Quit Game
Application.Quit();

//Change Gravity
Physics.gravity = new Vector3(0, -9.8f * 3, 0);

//Grounded
isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, whatIsGround);

//Compare 2 objects
if(GameObject.ReferenceEquals( firstGameObject, secondGameObject))
       Debug.Log("first and second are the same");
