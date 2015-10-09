using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
    public int numberCount = 0;
    public bool isPlayer = true;

    public bool gameOver = false;

    public bool win = false;

    public Animator anim;

    public string nextLevel = "";

    public TimeScore shells;

    //The 3 level sound played when the snail get each shell
    public AudioClip[] getPointSfx = new AudioClip[3];

    //Audio component
    private BgmManager bgmManager;
    private SfxManager sfxManager;

    //win component
    public SpriteRenderer winning, shell1, shell2, shell3, shellTemplate, menuBtn, nextBtn, restartBtn, snailHappy;
    public MeshRenderer winText, scoreText;
    public TextMesh score;
    public CircleCollider2D menu, next, restart;
    public AudioClip winSfx;

    public Animator menuBtnAnim, nextBtnAnim, restartBtnAnim, shell1Anim, shell2Anim, shell3Anim, snailHappyAnim, winTextAnim;

    //game over component
    public SpriteRenderer gameover, menuBtn2, restartBtn2, snailSad;
    public MeshRenderer gameOverText;
    public CircleCollider2D menu2, restart2;
    public AudioClip gameoverSfx;

    public Animator gameoverTextAnim, menuBtn2Anim, restartBtn2Anim, snailSadAnim; 
    
    void Awake()
    {
        bgmManager = ScriptableObject.FindObjectOfType<BgmManager>();
        sfxManager = ScriptableObject.FindObjectOfType<SfxManager>();
    }
	
	void Start () {
        shells = Object.FindObjectOfType<TimeScore>();

        gameOverText.enabled = false;
        winText.enabled = false;
        anim = gameObject.GetComponent<Animator>();

        winTextAnim.enabled = false;
        menuBtnAnim.enabled = false;
        nextBtnAnim.enabled = false;
        restartBtnAnim.enabled = false;
        snailHappyAnim.enabled = false;
        shell1Anim.enabled = false;
        shell2Anim.enabled = false;
        shell3Anim.enabled = false;

        gameoverTextAnim.enabled = false;
        menuBtn2Anim.enabled = false;
        restartBtn2Anim.enabled = false;
        snailSadAnim.enabled = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(gameOver && !win){
            //Sound management
            bgmManager.StopBgm();
            sfxManager.PlaySfx(gameoverSfx);

            anim.SetBool("Lose", true);

            gameoverTextAnim.enabled = true;
            menuBtn2Anim.enabled = true;
            restartBtn2Anim.enabled = true;
            snailSadAnim.enabled = true;

            shells.timeIsRunning = false;
            gameOverText.enabled = true;
            gameover.enabled = true;
            menuBtn2.enabled = true;
            restartBtn2.enabled = true;
            snailSad.enabled = true;

            menu2.enabled = true;
            restart2.enabled = true;
        }

        if(win && !gameOver){
            //Sound management
            bgmManager.StopBgm();
            sfxManager.PlaySfx(winSfx);

            winTextAnim.enabled = true;
            menuBtnAnim.enabled = true;
            nextBtnAnim.enabled = true;
            restartBtnAnim.enabled = true;
            snailHappyAnim.enabled = true;

            shells.timeIsRunning = false;
            //Time.timeScale = 0;
            winText.enabled = true;
            //Application.LoadLevel(nextLevel);
            winning.enabled = true;
            shellTemplate.enabled = true;
            menuBtn.enabled = true;
            restartBtn.enabled = true;
            nextBtn.enabled = true;
            snailHappy.enabled = true;

            scoreText.enabled = true;
            score.text = "Score : " + shells.starScore*1000;

            if(shells.starScore == 1){
                shell1Anim.enabled = true;
                shell1.enabled = true;
            } else if(shells.starScore == 2){
                shell1Anim.enabled = true;
                shell2Anim.enabled = true;
                shell1.enabled = true;
                shell2.enabled = true;
            } else if(shells.starScore == 3){
                shell1Anim.enabled = true;
                shell2Anim.enabled = true;
                shell3Anim.enabled = true;
                shell1.enabled = true;
                shell2.enabled = true;
                shell3.enabled = true;
            }

            menu.enabled = true;
            next.enabled = true;
            restart.enabled = true;
        }
          
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Shell"){

            if (collision.collider.GetComponent<NumberScript>().isNumber)
            {
                numberCount++;
                //soundEffect.PlayOneShot(shellSound[numberCount-1]);
                collision.collider.GetComponent<NumberScript>().numberIndex = numberCount;
                collision.collider.GetComponent<NumberScript>().numberTouched = true;
            }
        }

        if(collision.gameObject.tag == "Dead Zone"){
            if (collision.collider.GetComponent<DeadZone>().deadZone)
            {
                Destroy(collision.gameObject);
                gameOver = true;
            }
        }        

        if(collision.gameObject.tag == "Bone"){
            if (collision.collider.GetComponent<BoneScript>().isBone)
            {
                gameOver = true;
            }
        }        

        if(collision.gameObject.tag == "Bullet"){
            if (collision.collider.GetComponent<PoisonGasScript>().isPoisonGas)
            {
                gameOver = true;
            }
        }
        
        if(collision.gameObject.tag == "Thorn"){
            if (collision.collider.GetComponent<DeadlyPipeScript>().isDeadlyPipe)
            {
                gameOver = true;
            }
        }        
    }
}
