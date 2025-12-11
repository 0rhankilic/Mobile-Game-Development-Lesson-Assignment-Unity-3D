using UnityEngine;

public class kapiKontrol : MonoBehaviour
{  

    public Transform player;
    public Transform mutfakic;
    public Transform mutfakdis;
    public Transform garajic;
    public Transform garajdis;
    public Transform yodasiic;
    public Transform yodasidis;
    public Transform catiic;
    public Transform catidis;
    public GameObject playerg;

    public GameObject mutbtn1;
    public GameObject mutbtn2;
    public GameObject catibtn1;
    public GameObject catibtn2;
    public GameObject yatbtn1;
    public GameObject yatbtn2;
    public GameObject garbtn1;
    public GameObject garbtn2;

    

    // ---


    public void mutfakGir()
    {
        playerg.SetActive(false);
        player.position = mutfakic.position;
        player.rotation = mutfakic.rotation;
        playerg.SetActive(true);
        mutbtn1.SetActive(false);
        
    }
    public void mutfakCik() {
        playerg.SetActive(false);
        player.position = mutfakdis.position;
        player.rotation = mutfakdis.rotation;
        playerg.SetActive(true);
        mutbtn2.SetActive(false);
        
    }
    // ---
    public void yodasiGir() {
        playerg.SetActive(false);
        player.position = yodasiic.position;
        player.rotation = yodasiic.rotation;
        playerg.SetActive(true);
        yatbtn1.SetActive(false);
        
    }
    public void yodasiCik(){
        playerg.SetActive(false);
        player.position = yodasidis.position;
        player.rotation = yodasidis.rotation;
        playerg.SetActive(true);
        yatbtn2.SetActive(false);

    }
    // ---
    public void catiGir() {
        playerg.SetActive(false);
        player.position = catiic.position;
        player.rotation = catiic.rotation;
        playerg.SetActive(true);
        catibtn1.SetActive(false);
        
    }
    public void catiCik() {
        playerg.SetActive(false);
        player.position = catidis.position;
        player.rotation = catidis.rotation;
        playerg.SetActive(true);
        catibtn2.SetActive(false);
        
    }
    // ---
    public void garajGir() {
        playerg.SetActive(false);
        player.position = garajic.position;
        player.rotation = garajic.rotation;
        playerg.SetActive(true);
        garbtn1.SetActive(false);
        
    }
    public void garajCik() {
        playerg.SetActive(false);
        player.position = garajdis.position;
        player.rotation = garajdis.rotation;
        playerg.SetActive(true);
        garbtn2.SetActive(false);
        
    }
}
