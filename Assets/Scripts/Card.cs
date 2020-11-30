using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Image cardImage;
    public Text healthText, attackText, manaText;
    public int health, attack, mana;
    private string url = "https://picsum.photos/200";

    [System.Obsolete]
    private IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        cardImage.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
    }

    private void Update()
    {
        healthText.text = string.Empty + health;
        attackText.text = string.Empty + attack;
        manaText.text = string.Empty + mana;

        if (health < 1)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}