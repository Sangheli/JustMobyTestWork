using System.Threading.Tasks;
using JustMoby.Code.ContentProvider.Offer;
using JustMoby.Code.ContentProvider.View;
using JustMoby.Code.Message;
using UnityEngine;
using UnityEngine.Events;

namespace JustMoby.Code.UI.Offer
{
    public class OfferEntity
    {
        private IOfferView _view;
        private OfferController _controller;
        private readonly UnityEvent offerClickEvent = new UnityEvent();
        private UnityEvent<OfferWindowMessage> _offerWindowMessageEvent;

        public OfferEntity(Transform root, ViewProvider viewProvider, OfferProvider offerProvider,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            Init(root,viewProvider,offerProvider, offerWindowMessageEvent);
        }

        private async void Init(Transform root, ViewProvider viewProvider,OfferProvider offerProvider,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            await CreateView(root, viewProvider);
            CreateController(offerProvider,offerWindowMessageEvent);
        }

        private async Task CreateView(Transform root, ViewProvider viewProvider)
        {
            var handle = viewProvider.OfferView.InstantiateAsync(root);
            await handle.Task;
            _view = handle.Result.GetComponent<IOfferView>();
            _view.Init(offerClickEvent);
            _view.ToggleView(false);
        }

        private void CreateController(OfferProvider offerProvider,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            _controller = new OfferController(_view, offerProvider, offerClickEvent,offerWindowMessageEvent);
        }
    }
}
