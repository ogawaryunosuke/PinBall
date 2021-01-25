using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    int score = 0;

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    private GameObject scoreText;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }
        this.scoreText.GetComponent<Text>().text = score.ToString();

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")

        {
            score = score + 10;
        }

        if (other.gameObject.tag == "LargeStarTag")
        {
            score = score + 30;
        }

        if (other.gameObject.tag == "LargeCloudTag")
        {
            score = score + 100;
        }

        if (other.gameObject.tag == "SmallCloudTag")
        {
            score = score + 100;
        }

    }
}