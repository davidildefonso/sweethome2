using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dino : MonoBehaviour
{
    public LayerMask groundLayers; 
    public Rigidbody2D dinoBody; 
    public float moveSpeed; 
    private SpriteRenderer sprite; 
    private BoxCollider2D boxcollider2d;
    private bool facingRight;
    
    // Start is called before the first frame update
        
    void Start()
    {
        facingRight=true;
        sprite= GetComponent<SpriteRenderer>();
        dinoBody=transform.GetComponent<Rigidbody2D>();
        boxcollider2d= transform.GetComponent<BoxCollider2D>();
    }

    private void Awake(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isGrounded() && Input.GetKeyDown(KeyCode.Space))
       {
        
            float jumpVelocity=10f;
           dinoBody.velocity= Vector2.up*jumpVelocity;
       }


        float horizontal = Input.GetAxis("Horizontal");
    // esta funcion maneja el movimiento de dino
       HandleMovement();

       Flip(horizontal);
       
       
       //otra manera del mov horizontal

       /*else if(Input.GetAxisRaw("Horizontal")>0 ||Input.GetAxisRaw("Horizontal")<0){
            float h = Input.GetAxisRaw("Horizontal");
            dinoBody.velocity = new Vector2(h*speed,0); 
            
            if(h<0){
                sprite.flipX=true;
                
            }else if(h>=0){
                sprite.flipX=false; 
                
            }
       }*/
        
       
        
       
       
    }

    bool isGrounded(){

        // -- para el raycast en linea , no funcionaba muy bien
       // Vector2 position=transform.position;
       // Vector2 direction = Vector2.down;
      //  float distance=1f;


        //--  para ver el rayito raycast
       // Debug.DrawRay(position, direction, Color.green);



        RaycastHit2D hit = Physics2D.BoxCast(boxcollider2d.bounds.center,boxcollider2d.bounds.size,0f,Vector2.down,.1f,groundLayers);
       // Debug.Log(hit.collider);
        if(hit.collider !=null){
            return true;
        }
        return false;
    }


    private void HandleMovement()
    {
        
         //moveSpeed=10f;  //-- ahora esta variable se cambia en el editor
        if(Input.GetKey(KeyCode.LeftArrow))
        {
             
           // sprite.flipX=true;
           // gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(1.2f, -1.6f);
           // gameObject.GetComponent<PolygonCollider2D>().offset = new Vector2(2.3f, 0f);
            dinoBody.velocity= new Vector2(-moveSpeed,dinoBody.velocity.y);
        }else{
            if(Input.GetKey(KeyCode.RightArrow)){

             //   sprite.flipX=false;
              //  gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-1.2f, -1.6f);
          //  gameObject.GetComponent<PolygonCollider2D>().offset = new Vector2(0f, 0f);
                dinoBody.velocity = new Vector2(+moveSpeed,dinoBody.velocity.y);
            }else{
                //no keys pressed
                dinoBody.velocity=new Vector2(0,dinoBody.velocity.y);
            }
        }
    }


    private void Flip(float horizontal)
    {
        if(horizontal>0 && !facingRight || horizontal<0 && facingRight)
        {
            facingRight= !facingRight;
              Vector3 theScale = transform.localScale;
              theScale.x *= -1;
              transform.localScale = theScale;

        }
    }
}
