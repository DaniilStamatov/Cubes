using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Spawner : MonoBehaviour
    {
        private float spawnTime;
        [SerializeField] private InputReader inputReader;
        [SerializeField] private Cube cube;

        private void Update()
        {
            if( spawnTime > 0 )
                spawnTime-= Time.deltaTime;

            SpawnCube();
        }

        private void SpawnCube()
        {
            if (spawnTime <= 0 && inputReader.EnteredAll()) {
                Instantiate(cube, transform.position, Quaternion.identity).Init(inputReader.speed, inputReader.distance);
                spawnTime = inputReader.spawnTime;
            }
        }
    }
}
