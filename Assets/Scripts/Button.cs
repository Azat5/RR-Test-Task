using UnityEngine;

public class Button : MonoBehaviour
{
	public Card[] cards = new Card[6];
	private int randomValue, randomObject, index;

	public void ChangeRandomValue()
	{
		if (index >= cards.Length)
		{
			index = 0;
		}

		randomValue = Random.Range(-2, 9);
		randomObject = Random.Range(1, 4);

		switch (randomObject)
		{
			case 1:
				cards[index].health = randomValue;
				index++;
				break;
			case 2:
				cards[index].attack = randomValue;
				index++;
				break;
			case 3:
				cards[index].mana = randomValue;
				index++;
				break;
		}
	}
}