using Entitas;
using Foundation.Services.Interfaces;
using static InputMatcher;

namespace Kernel.Systems.Input
{
    public class EmmitInputSystem : IExecuteSystem
    {
        private readonly IInput _input;
        private readonly IGroup<InputEntity> _mouses;
        
        public EmmitInputSystem(InputContext context, IInput input)
        {
            _input = input;
            _mouses = context.GetGroup(Mouse);
        }
        
        public void Execute()
        {
            foreach (var mouse in _mouses)
            {
                mouse.ReplaceMousePosition(_input.MousePosition);
                mouse.isLeftMouse = _input.GetMouseButtonDown(0);
            }
        }
    }
}