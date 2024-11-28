using UnityEngine;
using TMPro;

public class DisplayDistanceText : MonoBehaviour
{
[SerializeField]private TextMeshProUGUI _distanceText;
[SerializeField]private  Transform _PlayerTrans;
private Vector2 _startPosition;

private void Start(){
_startPosition = _PlayerTrans.position;
    }
    private void Update(){
      Vector2 distance = (Vector2)_PlayerTrans.position-_startPosition;
      distance.y=0;
      if(distance.x<0){
        distance.x=0;
      }
    //   _distanceText.text = distance.x.ToString("F2")+" m";
       _distanceText.text = distance.x.ToString("0");
    }

}
