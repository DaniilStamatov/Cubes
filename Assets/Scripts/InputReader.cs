using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class InputReader : MonoBehaviour
    {
        [SerializeField] private InputField spawnTimeField;
        [SerializeField] private InputField speedField;
        [SerializeField] private InputField distanceField;
        public float spawnTime;
        public float speed;
        public float distance;

        public void OnEnterSpawnTime(string input)
        {
            spawnTime = float.Parse(input);
        }
        public void OnEnterSpeed(string input)
        {
            speed = float.Parse(input);
        }
        public void OnEnterDistance(string input)
        {
            distance = float.Parse(input);
        }

        public bool EnteredAll()
        {
            if(spawnTime > 0&& speed > 0 && distance > 0) { return true; }
            return false;
        }
    }
}
