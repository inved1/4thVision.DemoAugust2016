using UnityEngine;
using System.Collections;

    public class DebugMover : MonoBehaviour
    {
        public float TimeCounter = 0f;
         
        public float speed = 0.5f;
        public float width = 0.8f;
        public float height = 0.8f;

        public float heightOffset = 2.0f;
        public float xOffset = 2.0f;
        public float zOffset = 2.0f;
        // Use this for initialization
        void Start()
        {
         
        }

        // Update is called once per frame
        void Update()
        {
            TimeCounter += Time.deltaTime * speed;
            float x = Mathf.Abs(Mathf.Cos(TimeCounter) * width) + xOffset;
            float y = Mathf.Abs(Mathf.Sin(TimeCounter) * height) + heightOffset;
            float z = 0.1f + zOffset;

            transform.position = new Vector3(x, y, z);
            transform.rotation = new Quaternion(x, y, z,1f);
        }
    }
