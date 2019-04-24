using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour {
    public static BattleManager instance;
    bool battling = false;
    static int currentEnemies;
    static Character enemy1Temp;
    static Character enemy2Temp;
    static Character enemy3Temp;
    Character enemy1;
    Character enemy2;
    Character enemy3;
    bool enemyChance = false;
    int currentAttack = 0;//1 is attack,2 is magic
    int enemySelected = 0;//as
    static bool shouldSet=false;
    float playerHealth=100;
    GameObject enemyInView1;
    GameObject enemyInView2;
    GameObject enemyInView3;
    bool enemy1Died = false;
    bool enemy2Died = false;
    bool enemy3Died = false;
    private void Awake()
    {
        if (null == instance)
            instance = this;
    }
    void Start() {
        //enemy1 = ScriptableObject.CreateInstance<Character>();
        enemy2 = ScriptableObject.CreateInstance<Character>();
        enemy3 = ScriptableObject.CreateInstance<Character>();
        enemy1 = (Character)ScriptableObject.CreateInstance(typeof(Character));
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("enemy1=" + enemy1.health);
        Debug.Log("enemy2=" + enemy2.health);
        Debug.Log("playerhealth= "+playerHealth);
        battling = PlayerController.inBattle;
        if (shouldSet)
        {
            enemy1.health = enemy1Temp.health;
            enemy1.strength = enemy1Temp.strength;
            enemy1.magicalPow = enemy1Temp.magicalPow;
            enemy1.magicalDef = enemy1Temp.magicalDef;
            enemy1.physicalDef = enemy1Temp.physicalDef;
            enemy1.charName = enemy1Temp.charName;
            if (enemy2Temp != null)
            {
                enemy2.health = enemy2Temp.health;
                enemy2.strength = enemy2Temp.strength;
                enemy2.magicalPow = enemy2Temp.magicalPow;
                enemy2.magicalDef = enemy2Temp.magicalDef;
                enemy2.physicalDef = enemy2Temp.physicalDef;
                enemy2.charName = enemy2Temp.charName;
            }
            if (enemy3Temp!=null)
            {
                enemy3.health = enemy3Temp.health;
                enemy3.strength = enemy3Temp.strength;
                enemy3.magicalPow = enemy3Temp.magicalPow;
                enemy3.magicalDef = enemy3Temp.magicalDef;
                enemy3.physicalDef = enemy3Temp.physicalDef;
                enemy3.charName = enemy3Temp.charName;
            }
           

            shouldSet = false;


        }
      
        if (battling)
        {
            if (enemyChance)
            {
                EnemyAttack();
                  
            }
        }
        if (currentEnemies == 1)
        {
            if (enemy1.health<=0)
            {
                enemy1Died = true;
                enemyInView1.SetActive(false);
            }
            if (enemy1Died)
            {
                PlayerController.inBattle = false;
            }
        }
        else if (currentEnemies == 2)
        {
            //if (enemy1.health<=0&& enemy2.health <= 0)
            //  {
            //      enemyChance = false;
            //      PlayerController.inBattle = false;
            //      enemyInView1.SetActive(false);
            //      enemyInView2.SetActive(false);
            //      Debug.Log("i did ti");
            //  }
            
            if (enemy1.health <= 0)
            {
                enemy1Died = true;
                enemyInView1.SetActive(false);
               
            }
            if (enemy2.health <= 0)
            {
                enemy2Died = true;
                enemyInView2.SetActive(false);
            }
            if (enemy1Died&&enemy2Died)
            {
                PlayerController.inBattle = false;
            }
        }
        else if (currentEnemies == 3)
        {
            if (enemy1.health <= 0)
            {
                enemy1Died = true;
                enemyInView1.SetActive(false);

            }
            if (enemy2.health <= 0)
            {
                enemy2Died = true;
                enemyInView2.SetActive(false);
            }
            if (enemy3.health <= 0)
            {
                enemy3Died = true;
                enemyInView3.SetActive(false);
            }
            if (enemy1Died && enemy2Died&&enemy3Died)
            {
                PlayerController.inBattle = false;
            }
        }

    }
    public void StartBattle(int amountEnemies, Character name1, Character name2, Character name3) {

        currentEnemies = amountEnemies;
        enemy1Temp = name1;
        enemy2Temp = name2;
        enemy3Temp = name3;
        shouldSet = true;
        enemyChance = false;
        enemy1Died = false;
        enemy2Died = false;
        enemy3Died = false;
    }
    public void Setter(){

        enemy1 = enemy1Temp;
        enemy2 = enemy2Temp;
        enemy3 = enemy3Temp;
    }
    void EnemyAttack()
    {
        if (currentEnemies==1)
        {
            playerHealth -= enemy1.strength;
        }
        else if (currentEnemies == 2)
        {
            int rand = Random.Range(0, 1);
            if (rand == 0)
            {
                playerHealth -= enemy1.strength;
            }
            else if (rand == 1)
            {
                playerHealth -= enemy2.strength;
            }
        }
        else if (currentEnemies ==3)
        {
            int rand = Random.Range(0, 2);
            if (rand == 0)
            {
                playerHealth -= enemy1.strength;
            }
            else if (rand == 1)
            {
                playerHealth -= enemy2.strength;
            }
            else if (rand ==2)
            {
                playerHealth -= enemy3.strength;
            }
        }
        enemyChance = false;
     }
    public void PlayerAttack(int ene)
    {
        if (!enemyChance)
        {


            if (ene == 1 && enemy1 != null)
            {
                enemy1.health -= 40;


            }
            else if (ene == 2 && enemy2 != null)
            {
                enemy2.health -= 40;
            }
            else if (ene == 3 && enemy3 != null)
            {
                enemy3.health -= 40;
            }
        }
        enemyChance = true;
    }
    public void ButtonSetAttack(int att) {

        if (att==1)
        {
            currentAttack = 1;
        }
        else if (att==2)
        {
            currentAttack = 2;
        }
    }
    public void ButtonSetEnemy(int ene)
    {

        if (ene == 1)
        {
            enemySelected = 1;
        } else if (ene == 2)
        {
            enemySelected = 2;
        }
        else if (ene == 3)
        {
            enemySelected = 3;
        }

    }
    public void EnemyClone(GameObject one,GameObject two,GameObject three) {

        enemyInView1 = one;
        enemyInView2 = two;
        enemyInView3 = three;

    }
}
