using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public static GameManager instance;
    [SerializeField]private GameObject _GameoverCanvas;
     [SerializeField]private GameObject _background;
     [SerializeField] private GameObject _restartButton;
     [SerializeField]private GameObject _gameoverIcon;

    private void Awake(){
        if(instance == null){
            instance = this;
        }
        Time.timeScale = 1f;
        
    }
    public void GameOver(){
        _GameoverCanvas.SetActive(true);
        _background.gameObject.SetActive(true);
        _restartButton.gameObject.SetActive(true);
        _gameoverIcon.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartGame(){
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
