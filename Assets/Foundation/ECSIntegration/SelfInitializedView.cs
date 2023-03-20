using Foundation.Attributes;
using UnityEngine;
using Zenject;

namespace Foundation.ECSIntegration
{
    [ImplicitInjectable]
    [RequireComponent(typeof(EntityView))]
    public class SelfInitializedView : MonoBehaviour
    {
        private GameContext _gameContext;

        [Inject]
        private void Construct(GameContext gameContext) => _gameContext = gameContext;

        private void Awake()
        {
            var view = GetComponent<EntityView>();
            view.Initialize(_gameContext.CreateEntity());
        }
    }
}