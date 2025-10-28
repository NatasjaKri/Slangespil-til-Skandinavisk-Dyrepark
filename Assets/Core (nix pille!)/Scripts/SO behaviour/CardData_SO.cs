using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "Scriptable Objects/CardData")]
public class CardData_SO : ScriptableObject
{
    #region Fields
    [SerializeField]
    private bool isPictureCard = true;
    [SerializeField]
    private Sprite sprite;
    [SerializeField]
    [TextArea] private string cardTextDanish;
    [SerializeField]
    [TextArea] private string cardTextEnglish;
    [SerializeField]
    private SnakeType snakeType = SnakeType.Snog;
    #endregion
    #region Properties
    public bool IsPictureCard { get => isPictureCard; private set => isPictureCard = value; }
    public Sprite Sprite { get => sprite; private set => sprite = value; }
    public string CardTextDanish { get => cardTextDanish; private set => cardTextDanish = value; }
    public string CardTextEnglish { get => cardTextEnglish; private set => cardTextEnglish = value; }
    public SnakeType TypeOfSnake { get => snakeType; set => snakeType = value; }


    #endregion
}