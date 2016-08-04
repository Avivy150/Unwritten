using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic; 

public class equitmentWindow : MonoBehaviour
{
    int iteamNumber;
    public GameObject window;
    public Image iteamWindow;
    public Sprite yellowDress;
    public Slider slider;
    public bool active = false;
    public Image playerImage;
    public PlayerInput player;
    public dress dressControll;

    public Sprite GirlFront;
    public Sprite GirlRight;
    public Sprite GirlBack;
    public Sprite GirlLeft;

    public Text it0;
    public Text it1;
    public Text it2;
    public Text it3;
    public Text it4;
    public Text it5;
    public Text it6;
    public Text it7;
    public Text it8;
    public Text it9;
    public Text it10;
    public Text it11;
    public Text it12;
    public Text it13;
    public Text it14;
    public Text it15;
    public Text it16;
    public Text it17;
    public Text it18;
    public Text it19;
    public Text it20;
    public Text it21;
    public Text it22; 
    public Text it23;  

    int page = 1;
    static Dictionary<int, string> iteams = new Dictionary<int, string>();
    private int girl = 0;
    Color white = new Color(255,255,255);

    // Use this for initialization
    void Start()
    {
        window.SetActive(false);

        for (int i = 0; i <= 240; i++)
        {
            iteams.Add(i, "");
        }
    }

    void Update ()
    {
        page = (int) slider.value;  
	    if (page == 1)
        {
            setLabels(0);
        }else if (page == 2)
        {
            setLabels(24);
        }else if (page >= 10)
        {
            setLabels(((24 * page) - 24) + 1);
        }
        window.SetActive(active);
	}    

    void setLabels(int startI)
    { 
        it0.text = iteams[startI];
        startI++;  
        it1.text = iteams[startI];
        startI++; 
        it2.text = iteams[startI];
        startI++;
        it3.text = iteams[startI];
        startI++; 
        it4.text = iteams[startI];
        startI++; 
        it5.text = iteams[startI];
        startI++;
        it6.text = iteams[startI];
        startI++;
        it7.text = iteams[startI];
        startI++;
        it8.text = iteams[startI];
        startI++;
        it9.text = iteams[startI];
        startI++;
        it10.text = iteams[startI];
        startI++;
        it11.text = iteams[startI];
        startI++; 
        it12.text = iteams[startI];
        startI++;
        it13.text = iteams[startI];
        startI++; 
        it14.text = iteams[startI];
        startI++;
        it15.text = iteams[startI];
        startI++;
        it16.text = iteams[startI];
        startI++;
        it17.text = iteams[startI];
        startI++; 
        it18.text = iteams[startI];
        startI++;
        it19.text = iteams[startI];
        startI++; 
        it20.text = iteams[startI];
        startI++;
        it21.text = iteams[startI];
        startI++; 
        it22.text = iteams[startI];
        startI++; 
        it23.text = iteams[startI]; 
    } 

    public void addIteam (string iteam)
    {
        iteams.Remove(iteamNumber);
        iteams.Add(iteamNumber,iteam);
        iteamNumber++;
        print("hjkl");
    }


    public void iteamScrolled (Text text)
    {
        print("clicked");
        if (text.text == "Yellow School Dress")
        {
            iteamWindow.color = white;
            dressControll.setDressType("Yellow School Dress");
            iteamWindow.sprite = yellowDress;  
        }
    }  

    public bool itemInInvetory (string iteam)
    {
        int i = 0;
        foreach (KeyValuePair<int,string> entry in iteams)
        {
            if (iteams[i] == iteam)
            {
                return true;
            }
        }
        return false;
    }  

    public void deleteIteam (string iteam)
    {
        int i = 0;
        foreach (KeyValuePair<int,string> entry in iteams)
        {
            if (iteams[i] == iteam)
            {
                iteams.Remove(i);
                iteams.Add(i,"");
                return;
            }
        }
    }
     
    public void flipPlayer (bool rightArow)
    {
        const int girlFront = 0;
        const int girlRight = 1;
        const int girlBack = 2;
        const int girlLeft = 3; 
         

        if (rightArow)
        {
            girl++;
        }else
        {
            girl--;
        }
        if (girl >= 4)
        {
            girl = 0;
        }else if (girl <= -1)
        {
            girl = 3;
        }
        if (girl == girlFront)
        {
            playerImage.sprite = GirlFront;
        } else if (girl == girlRight)
        {
            playerImage.sprite = GirlRight;
        }else if (girl == girlBack)
        {
            playerImage.sprite = GirlBack;
        }else if (girl == girlLeft)
        {
            playerImage.sprite = GirlLeft;
        }
    }
} 


































 
