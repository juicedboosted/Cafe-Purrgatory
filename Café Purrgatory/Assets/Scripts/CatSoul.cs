using UnityEngine;

//CatPersonality
// personality traits of the catsoul
public enum CatPersonality
{
    //feline five: neuroticism, extraversion, dominance, impulsiveness, tolerance
    calm,
    curious,
    playful
}

// CatSoul
// creates cats
public class CatSoul : MonoBehaviour
{
    public string m_catName;
    public CatPersonality m_catPersonality;

    public int m_catHappiness;
    public int m_catAffection;

    public int m_catHunger;
    public int m_catThirst;
    public int m_catBladder;
    public int m_catCleanliness;
    public int m_catBordeom;


    private void OnMouseDown()
    {
        //MatchingSystem.Instance.SelectCat(this);
    }

}
