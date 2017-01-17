using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownUpNumber : MonoBehaviour
{
	public float speed;

	Text t;
	int number;
	int start_number;
	int end_number;

	void Start ()
	{
		t = GetComponent<Text> ();
	}

	public void OnTextChanged(string newString)
	{
		start_number = int.Parse(t.text);
		end_number = int.Parse(newString);

		StartCoroutine (CountDownRoutine (speed));
	}

	IEnumerator CountDownRoutine(float timer)
	{
		float initial_time = timer;

		while (timer > 0f)
		{
			timer -= Time.deltaTime;

			t.text = Mathf.RoundToInt(Mathf.Lerp (start_number, end_number, (initial_time - timer) / initial_time)).ToString();

			yield return null;
		}
	}
}
