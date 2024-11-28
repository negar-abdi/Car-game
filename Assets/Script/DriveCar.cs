using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
public class DriveCar : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _carRB;
    [SerializeField] private float _Speed=600f;
    [SerializeField] private float _rotationSpeed=300f;
    [SerializeField] private AudioSource _hornSource;
    
    private float _moveInput;
    private void Update(){
        _moveInput = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.H)){
         _hornSource.Play();
        }

        if(_moveInput==0 && Input.touchCount>0){
            Touch touch= Input.GetTouch(0); 
            if(touch.position.x<Screen.width/2){
                _moveInput=-1;
            }else{
                _moveInput=1;
            }
        }
    }
    private void FixedUpdate(){
        _frontTireRB.AddTorque(-_moveInput * _Speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _Speed * Time.fixedDeltaTime);
        _carRB.AddTorque(-_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    


    }
   
}

