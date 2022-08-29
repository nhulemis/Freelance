using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    //Panel
    [SerializeField]
    GameObject winPanel;
    [SerializeField]
    GameObject loosePanel;
    [SerializeField]
    GameObject startPanel;
    [SerializeField]
    GameObject inGamePanel;
    [SerializeField]
    Text totalCoinText;
    [SerializeField]
    Text inGameCollectedCoinText;
    [SerializeField]
    Text currentLevelText;
    [SerializeField]
    Text winCollectedCoinText;
    [SerializeField]
    Text levelCompletedCollectedCoinText;
    [SerializeField]
    GameObject popUpText;
    [SerializeField]
    Transform  winCollectedCoinStartAnimation;
    private int totalCollectedCoin;
    private int currentCollectedCoin;
    private int currentLevelIndex;
   
        public class liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj()
        {
            
        }
        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj GetliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(){
        var clasx = new liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj();
        return  clasx;
    }

    public string RandomStringliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX()
        {
            
        }
        public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX GethuGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(){
        var clasx = new huGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX();
        return  clasx;
    }

    public string RandomStringhuGHTPfWAgheeRsPbUMJuUXOAoTNSNQjaEnYGbCHSCizwXrCvkvFlyxNX(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM()
        {
            
        }
        public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM GetRaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(){
        var clasx = new RaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM();
        return  clasx;
    }

    public string RandomStringRaWJzxrlhqOSHAcMUPHBLYOgISjhrXnjNgisIAOAQCGDUJWXdEnLigM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU()
        {
            
        }
        public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU GetRJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(){
        var clasx = new RJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU();
        return  clasx;
    }

    public string RandomStringRJeZoceAFOshbTFYXSsvJwXddxWrAvdxNHEjJgLjONOQnHvqsRYgiNbU(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp()
        {
            
        }
        public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp GetBAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(){
        var clasx = new BAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp();
        return  clasx;
    }

    public string RandomStringBAQMVodDWDBqaTMzzieaiRSmZFzZqqIDaETXmqpMslFNHOnITThEmHojhenPp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV()
        {
            
        }
        public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV GetREaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(){
        var clasx = new REaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV();
        return  clasx;
    }

    public string RandomStringREaYmBYRzNiElfsTjCNjNKOUQammUCLNdUxuSIutOAmeNSIUYxRhBOnHqGILPmxxBV(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update

        public class sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF()
        {
            
        }
        public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF GetsHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(){
        var clasx = new sHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF();
        return  clasx;
    }

    public string RandomStringsHewREmPyDZdTIARErslYRcxQSiSLxcHaBOTXLAyvjyURYbcuohHF(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    
    

        public class sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa()
        {
            
        }
        public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa GetsLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(){
        var clasx = new sLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa();
        return  clasx;
    }

    public string RandomStringsLqBhNJuKDeEaRkDTBHkISLLzwMDmjbBhUqhSzhmHIwzpFwFsBTKavDazfBkAFHa(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW()
        {
            
        }
        public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW GetueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(){
        var clasx = new ueTbFJXvUIaVXCDKBWobQIENcfTgmRiW();
        return  clasx;
    }

    public string RandomStringueTbFJXvUIaVXCDKBWobQIENcfTgmRiW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY()
        {
            
        }
        public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY GetbRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(){
        var clasx = new bRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY();
        return  clasx;
    }

    public string RandomStringbRhxBbIUUNXjGxRRNWkdMOhqELAidcCpcsqrmawqZguajGAKuxYaMY(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
        GameItemManager.Instance.SetUpColor();
        currentCollectedCoin = 0;
        setLevelText();
        
            setTotalCoinText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void winLevel()
    {
        inGamePanel.SetActive(false);
        updateTotalCollectedCoins();
        winPanel.SetActive(true);
        Invoke("setWinCollectedCoinText", 2f);
    }
    public void nextLevel()
    {
        AudioController.instance.buttonClick();
        updateLevelIndex();
        SceneManager.LoadScene(currentLevelIndex);
    }
    public void retryLevel()
    {
        AudioController.instance.buttonClick();

        SceneManager.LoadScene(currentLevelIndex);
    }
    public void startPlay()
    {
        AudioController.instance.buttonClick();

        inGamePanel.SetActive(true);
        startPanel.SetActive(false);
        GameManager.instance.startPlay();
    }
    public void looseLevel()
    {
        
        Invoke("DelayLoosePanel",1f);
    }
    private void DelayLoosePanel()
    {
        inGamePanel.SetActive(false);
        loosePanel.SetActive(true);
    }
    private void setTotalCoinText()
    {
        totalCollectedCoin = PlayerPrefs.GetInt("TotalCoins");
        totalCoinText.text = totalCollectedCoin + "";
    }
    public void updateCurrentCollectedCoins()
    {
        currentCollectedCoin++;
        inGameCollectedCoinText.text = currentCollectedCoin + "";

    }
    private void updateTotalCollectedCoins()
    {
        totalCollectedCoin += currentCollectedCoin;
        PlayerPrefs.SetInt("TotalCoins", totalCollectedCoin);
    }
    private void setLevelText()
    {
        currentLevelIndex = PlayerPrefs.GetInt("LevelIndex" , 1);
        
        currentLevelText.text = "Level : "+ (currentLevelIndex + 1);
    }
    private void updateLevelIndex() {
        currentLevelIndex++;
        if (currentLevelIndex >= 18)
        {
            currentLevelIndex = 0;
        } 
            PlayerPrefs.SetInt("LevelIndex", currentLevelIndex);       

    }
    private void setWinCollectedCoinText()
    {
        CoinManger.instance.animate(winCollectedCoinStartAnimation.position,5);
        winCollectedCoinText.text = currentCollectedCoin + "";
        levelCompletedCollectedCoinText.text = "0";

    }
    public void enablePopUp(Vector3 popUpstartPos)
    {
        popUpstartPos = Camera.main.WorldToScreenPoint(popUpstartPos);
        Instantiate(popUpText,popUpstartPos,Quaternion.identity,this.transform);
    }

}
