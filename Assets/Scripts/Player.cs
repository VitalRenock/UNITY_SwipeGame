using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int _rage = 0;
    int _sanity = 10;
    int _verve = 1;
    int _xp = 0;

    private void Start()
    {
        StartCoroutine("Playing");
    }

    private IEnumerator Playing()
    {
        Debug.Log("Start Co-Routine");

        // Tant que je n'appuie pas sur 'Space'...
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        // Tant que ma 'Rage' est en dessous de 10 ET ma 'Sanity' est au dessus de 0
        while (_rage < 10 && _sanity > 0)
        {
            Ennemy currentEnemy = GameManager.RandomEnemy();

            bool acceptDebate = true;

            Debug.Log(currentEnemy._name + " is challenging you to a debate, press right to fight or left to flee");

            while (true)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    acceptDebate = true;
                    Debug.LogWarning("Push Right Arrow");
                    break;
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    acceptDebate = false;
                    Debug.LogWarning("Push Left Arrow");
                    break;
                }
                yield return null;
            }

            if (acceptDebate)
            {
                while(true)
                {
                    Debug.LogError("You speak so well that you inflict +" + _verve + " rage to " + currentEnemy._rage);
                    currentEnemy._rage += _verve;
                    Debug.Log(currentEnemy._name + "'s rage is now : " + currentEnemy._rage);
                    yield return new WaitForSeconds(4);

                    if(currentEnemy._rage >= 10) { break; }

                    Debug.LogError(currentEnemy._name + " speaks so well that you gain " + currentEnemy._verve + " rage!" );
                    _rage += currentEnemy._verve;
                    Debug.Log("Your rage is now " + _rage);
                    yield return new WaitForSeconds(4);

                    if(_rage >= 10) { break; }

                    if(_rage < 10)
                    {
                        if(currentEnemy._rage >= 10)
                        {
                            Debug.Log("You won this debate");
                            _xp++;
                        }
                    }
                    else
                    {
                        Debug.Log(currentEnemy._name + "'s verve is mightier than yours");
                        break;
                    }
                }
            }
            else
            {
                _sanity--;
                Debug.Log("You flee and lost sanity... You still have " + _sanity + " sanity left");
                yield return new WaitForSeconds(4);
            }
        }

        Debug.Log("You raged out");
    }

    //private IEnumerator Updating()
    //{
    //    while (true)
    //    {
    //        Debug.Log("Dans Co-Routine");

    //        yield return null;
    //    }
    //}
}
