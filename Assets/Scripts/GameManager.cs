using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{  
    public Player player;
   public TextMeshProUGUI textMeshProUGUI;
   private int score;
   public GameObject playButton;
   public GameObject gameOver;
  
    private Spawner spawner;


    private void Awake()
    {
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
        
        Application.targetFrameRate = 60;
        Pause();
    }
    
    public void Play()
    {
        score =0; 
        textMeshProUGUI.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        // Pipes[] pipes = FindObjectOfType<Pipes>();

        // for(int i =0; i<pipes.Length ; i++)
        // {
        //     Destroy(pipes[i].gameObject);
        // }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

   public void IncreaseScore()
   {
        score++;
        textMeshProUGUI.text = score.ToString();
       
   }

   public void GameOver()
   {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
   }
}
