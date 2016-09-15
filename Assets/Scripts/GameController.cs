using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    public GameObject hazard;
    public GameObject restartButton;
	public GameObject SphereLeft;
	public GameObject SphereRight;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GUIText scoreText;
    public GUIText gameOverText;
	public GUIText high;
	public GUIText current;
    private int score;
	public int hscore=0;
	string highScoreKey = "HighScore";
	public Button Pause;

    private bool gameOver;
   


    void Start() 
    {
		hscore = PlayerPrefs.GetInt (highScoreKey, 0);
        gameOver = false;
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
		Invoke ("CreateSphereLeft", 1.0f);
		Invoke ("CreateSphereRight", 3.0f);
		high.enabled = false;
		current.enabled = false;
			
    }
	void CreateSphereLeft()
	{
		Vector3 sphereLeftSpawn = new Vector3(-4.0f, 0.3f, -1.61f);
		Instantiate(SphereLeft, sphereLeftSpawn, Quaternion.identity);
	}

	void CreateSphereRight()
	{
		Vector3 sphereRightSpawn = new Vector3(4.0f, 0.3f, -1.61f);
		Instantiate(SphereRight, sphereRightSpawn, Quaternion.identity);
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
        
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }


    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
		if (score > hscore) {
			PlayerPrefs.SetInt (highScoreKey, score);
			PlayerPrefs.Save ();
		}
    }
   
    public void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
        Time.timeScale = 0.0f;
        Vector3 buttonSpawn = new Vector3(1, 10, -2);
        Instantiate(restartButton, buttonSpawn, Quaternion.identity);
		Pause.enabled = false;
		scoreText.enabled = false;
		high.enabled = true;
		current.enabled = true;
		high.text = "  High Score:" + hscore;
		score += 10;
		current.text = "Current Score:" + score;

    }


  
}
