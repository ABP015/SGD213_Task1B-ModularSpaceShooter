using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConstantlyOG : MonoBehaviour
{
        [SerializeField]
        private Vector2 direction;

        private EngineBaseOG movement;

        // Start is called before the first frame update
        void Start()
        {
            movement = GetComponent<EngineBaseOG>();
        }

        // Update is called once per frame
        void Update()
        {
            movement.Move(direction);
        }
    }
