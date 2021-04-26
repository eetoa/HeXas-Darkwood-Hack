using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace HeXas_Darkwood_Hack
{
    public class Loader
    {
        public static void Init()
        {
            _gameObject = new GameObject();
            _gameObject.AddComponent<Main>();
            GameObject.DontDestroyOnLoad(_gameObject);
        }
        public static void Unload()
        {
            _Unload();
        }
        private static void _Unload()
        {
            GameObject.Destroy(_gameObject);
        }
        private static GameObject _gameObject;
    }
}
