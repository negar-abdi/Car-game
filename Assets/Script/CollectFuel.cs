// using UnityEngine;

// public class CollectFuel : MonoBehaviour
// {
//     private void OnTriggerEnter2D(Collider2D collision){
//         if(collision.gameObject.CompareTag("Player")){
//            FuelController.instance.FillFuel();
//            Destroy(gameObject);  

//         }
//     }
// }

using UnityEngine;

public class CollectFuel : MonoBehaviour
{

   [SerializeField] private AudioSource _fuelsorce;
    void Start(){
        _fuelsorce = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            string fuelType = gameObject.tag; 
            switch (fuelType)
            {
                case "GoldFuel":
                    FuelController.instance.FillFuel(1.0f);
                    break;
                case "BlueFuel":
                   FuelController.instance.FillFuel(0.5f); 
                    break;
                case "RedFuel":
                    FuelController.instance.FillFuel(0.25f); 
                    break;
            }
            
            AudioSource.PlayClipAtPoint(_fuelsorce.clip,transform.position);

            Destroy(gameObject);
        }
    }

    // void FillTank(float amount)
    // {
    //     // Implementation to fill tank based on amount.
    //     // This will depend on how your fuel bar is set up.
    //     FuelController.instance.FillFuel(amount);
    // }
}
