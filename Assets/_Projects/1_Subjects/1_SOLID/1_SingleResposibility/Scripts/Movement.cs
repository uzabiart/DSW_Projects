using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    public class Movement : MonoBehaviour
    {
        public float moveSpeed = 5.0f;

        public void Move(Vector3 direction)
        {
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
                Move(Vector3.up);
            if (Input.GetKey(KeyCode.DownArrow))
                Move(Vector3.down);
        }
    }
}