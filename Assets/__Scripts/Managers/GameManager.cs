using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    public int score;
    public Text uiScore;
    public Text uiDistance;
    public Text finalScore;
    public Text finalDistance;
    public Text uiChicks;

    public static int numberOfChicks;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        numberOfChicks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollision.playerState())
        {
            score = Mathf.RoundToInt(player.transform.position.z * 2);
            if (uiScore != null)
            {
                uiScore.text = "SCORE: " + score.ToString() + ""; // Score
                finalScore.text = uiScore.text; //Final Score

            }

            int distance = Mathf.RoundToInt(player.transform.position.z);
            if (uiDistance != null)
            {
                uiDistance.text = "DISTANCE: " + distance.ToString() + ""; //Distance
                finalDistance.text = uiDistance.text; //Final Distance
            }

            if (uiChicks != null)
            {
                //Chicks collected 
                uiChicks.text = "CHICKS: " + numberOfChicks.ToString() + "";
            }
        }
        
    }
}
