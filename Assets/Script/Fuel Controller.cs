
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
   public static FuelController instance;
   [SerializeField]private Image _fuelImage;

   [SerializeField,Range(0.1f,5f)] private float _fuelDrainSpeed = 1f;
   [SerializeField]private float _maxfuelAmount = 100f;
   [SerializeField]private Gradient _fuelGradient;
   private float _currentFuelAmount;
   
   private void Awake()
   {
    // if (instance== null){
    //  instance = this;
    //  }
     if (instance == null)
    {
        instance = this;
    }
    else
    {
        Destroy(gameObject);
    }
   }
   private void Start(){
    _currentFuelAmount = _maxfuelAmount;
    UpdateUI();
   }


   private void Update(){ 
    
     _currentFuelAmount -= _fuelDrainSpeed * Time.deltaTime;
     UpdateUI();
     
     if(_currentFuelAmount <= 0){
      
      GameManager.instance.GameOver();
     }
    }
   
   private void UpdateUI(){
    // _fuelImage. fillAmount= (_currentFuelAmount / _maxfuelAmount);
    // _fuelImage.color = _fuelGradient.Evaluate(_fuelImage.fillAmount);
    _fuelImage.fillAmount = _currentFuelAmount / _maxfuelAmount;
    _fuelImage.color = _fuelGradient.Evaluate(_currentFuelAmount / _maxfuelAmount);
   }

   public void FillFuel(float amount)
    {
      // _currentFuelAmount = _maxfuelAmount;
      // UpdateUI();

    _currentFuelAmount += amount * _maxfuelAmount;
    _currentFuelAmount = Mathf.Clamp(_currentFuelAmount, 0, _maxfuelAmount);
    UpdateUI();

   }


}
