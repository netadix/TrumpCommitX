using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject MexicanObjet;
    public GameObject MexicanField;
    public GameObject TrumpPentagon03;
    public GameObject BukisentakuArea;
    public GameObject Flypan1Prefub; 
    int approval_rating;
    GameObject ApprovalRatingText;

    public void AddScore()
    {
        this.approval_rating += 1;
        if (approval_rating > 100)
        {
            approval_rating--;
        }
    }
    // Use this for initialization
    void Start () {
        this.ApprovalRatingText = GameObject.Find("rating");

    }

    // Update is called once per frame
    void Update () {
		if (Random.Range(1f, 10f) >= 9f)
		{
            float y = MexicanField.transform.position.y + MexicanField.GetComponent<SpriteRenderer>().size.y / 2f;

            GameObject tmp = Instantiate(MexicanObjet, new Vector3(0f, y, 0f), Quaternion.identity);
            tmp.GetComponent<SpriteRenderer>().sortingOrder = 5;
        }

        AddScore();

        ApprovalRatingText.GetComponent<Text>().text = "支持率:"+approval_rating.ToString("D3")+"%";


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Flypan1Prefub, TrumpPentagon03.transform.position, Quaternion.identity);
        }
        

    }
}
