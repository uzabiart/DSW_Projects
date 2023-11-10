using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    public class Attack : MonoBehaviour
    {
        public int attackDamage = 10;

        public void MakeAttack()
        {
            Debug.Log($"{gameObject.name} attacks with {attackDamage} damage.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MakeAttack();
            }
        }
    }
}
