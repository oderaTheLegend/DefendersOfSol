using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour {
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
    int enemySelected = 0;
    static bool shouldSet=false;
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
        battling = PlayerController.inBattle;
        if (shouldSet)
        {
            enemy1.health = enemy1Temp.health;
            enemy1.strength = enemy1Temp.strength;
            enemy1.magicalPow = enemy1Temp.magicalPow;
            enemy1.magicalDef = enemy1Temp.magicalDef;
            enemy1.physicalDef = enemy1Temp.physicalDef;
            enemy1.charName = enemy1Temp.charName;

            enemy2.health = enemy2Temp.health;
            enemy2.strength = enemy2Temp.strength;
            enemy2.magicalPow = enemy2Temp.magicalPow;
            enemy2.magicalDef = enemy2Temp.magicalDef;
            enemy2.physicalDef = enemy2Temp.physicalDef;
            enemy2.charName = enemy2Temp.charName;
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
    }
    public static void StartBattle(int amountEnemies, Character name1, Character name2, Character name3) {

        currentEnemies = amountEnemies;
        enemy1Temp = name1;
        enemy2Temp = name2;
        enemy3Temp = name3;
        shouldSet = true;

    }
    public void Setter(){

        enemy1 = enemy1Temp;
        enemy2 = enemy2Temp;
        enemy3 = enemy3Temp;
    }
    void EnemyAttack() {
        Debug.Log(enemy1.health);
       
    }
    public void PlayerAttack(int ene) {
        if (ene == 1&&enemy1!=null)
        {
            enemy1.health -= 10;

        }
        else if (ene == 2 && enemy2 != null)
        {
            enemy2.health -= 10;
        }
        else if (ene == 3 && enemy3 != null)
        {
            enemy3.health -= 10;
        }

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
    public void ButtonSetEnemy(int ene) {

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
}
