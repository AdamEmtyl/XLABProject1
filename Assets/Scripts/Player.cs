using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        private bool m_isDown = false;
        public void OnCollisionStick(Collider collider)
        {
            Debug.Log(collider, this);
            
        }

    }
}