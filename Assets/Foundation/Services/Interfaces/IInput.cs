using UnityEngine;

namespace Foundation.Services.Interfaces
{
    public interface IInput
    {
        Vector2 MouseAxis { get; }
        Vector2 MousePosition { get; }

        bool GetMouseButtonDown(int button);
    }
}