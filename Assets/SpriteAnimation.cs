using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpriteAnimation : MonoBehaviour
{
	public float speed;
	public Sprite[] sprites;

	private SpriteRenderer spriteRenderer;
	private Image image;

	private float timer;
	private int index = 0;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		image = GetComponent<Image> ();
		ChangeSprite ();
	}

	void ChangeSprite()
	{
		if(spriteRenderer != null) spriteRenderer.sprite=sprites[index];
		if(image != null) image.sprite = sprites [index];

		index++;

		timer = speed;

		if (index >= sprites.Length)
		{
			index = 0;
		}
	}

	void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0f)
		{
			ChangeSprite ();
		}
	}
}