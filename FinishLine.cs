using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
	[SerializeField] private GameObject GameFinishPanel;

	private void OnCollision(Collider other)
	{
		if(other.gameObject.tag == "Player"){
			GameFinishPanel.SetActive(true);
		}
	}
}
