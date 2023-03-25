using Foundation.Services.Interfaces;
using UnityEngine;

namespace Foundation.Services
{
    public class UnityInput : IInput
    {
        public Vector2 MouseAxis => new (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        public Vector2 MousePosition => Input.mousePosition;

        public bool GetMouseButtonDown(int button)
            => Input.GetMouseButtonDown(button);
    }
}