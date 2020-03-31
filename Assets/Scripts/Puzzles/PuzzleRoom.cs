﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Puzzle Room", menuName = "Puzzle/Sample Room", order = 0)]
    public class PuzzleRoom : ScriptableObject
    {
        [Serializable]
        public struct PathWays
        {
            public bool North;
            public bool South;
            public bool West;
            public bool East;
        }
        
        //TODO: wtf editor?
        [Tooltip("Prefab to instantiate puzzle with")]
        public GameObject puzzlePrefab;

        [Header("Properties")]
        [Range(1, 5)]
        public float difficulty;
        [Tooltip("Position set to true if N, S, W, E exist, respectively")]
        public PathWays pathWays;
    }

    
}