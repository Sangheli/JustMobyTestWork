using System.Threading.Tasks;
using JustMoby.Code.ContentProvider.View;
using JustMoby.Code.Message;
using UnityEngine;
using UnityEngine.Events;

namespace JustMoby.Code.UI.StartScreen
{
    public class StartScreenEntity
    {
        private IStartScreenView _view;
        
        public StartScreenEntity(Transform root, ViewProvider viewProvider,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            Init(root,viewProvider,offerWindowMessageEvent);
        }

        private async void Init(Transform root, ViewProvider viewProvider,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            await CreateView(root, viewProvider,offerWindowMessageEvent);
        }

        private async Task CreateView(Transform root, ViewProvider viewProvider,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            var handle = viewProvider.StartScreenView.InstantiateAsync(root);
            await handle.Task;
            _view = handle.Result.GetComponent<IStartScreenView>();
            _view.Init(offerWindowMessageEvent,3);
        }
    }
}