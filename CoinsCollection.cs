using UnityEngine;
using UnityEngine.UI;

public class CoinsCollection : MonoBehaviour
{
    public int CoinsScore;
    private int TotalScore;
    public Text ScoreText;
    public GameObject CoinsCollectionEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText.text = "Lets Go Babesss";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Coin"){
            TotalScore += CoinsScore;
			Instantiate(CoinsCollectionEffect, transform.position, Quaternion.identity);
			Destroy(other.gameObject);
            ScoreText.text = "Score: " + TotalScore;
			AudioManager.instance.PlaySFX(0);
			//Debug.Log(TotalScore);
        }
	}
}
