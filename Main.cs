using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace HeXas_Darkwood_Hack
{
    class Main : MonoBehaviour
    {
        public void Start()
        {
            _player = FindObjectOfType<Player>();
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                _player.upgradeHealth();
            }

            if (Input.GetKeyDown(KeyCode.Delete)) // Will just unload our DLL
            {
                Loader.Unload();
            }

        }
        public void OnGUI()
        {
            //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 150f, 50f), "GAME INJECTED"); // Should work and when injected you will see this text in the middle of the screen
        }
        private Player _player;
    }
}
