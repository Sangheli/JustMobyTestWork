using System.Threading.Tasks;
using JustMoby.Code.ContentProvider.Offer;
using JustMoby.Code.ContentProvider.View;
using UnityEngine;

namespace JustMoby.Code.UI.Offer
{
    public class OfferEntity
    {
        private IOfferView _view;
        private OfferController _controller;
    
        public OfferEntity(Transform root, ViewProvider viewProvider, OfferProvider offerProvider)
        {
            Init(root,viewProvider,offerProvider);
        }

        private async void Init(Transform root, ViewProvider viewProvider,OfferProvider offerProvider)
        {
            await CreateView(root, viewProvider);
            CreateController(offerProvider);
        }

        private async Task CreateView(Transform root, ViewProvider viewProvider)
        {
            var handle = viewProvider.OfferView.InstantiateAsync(root);
            await handle.Task;
            _view = handle.Result.GetComponent<IOfferView>();
        }

        private void CreateController(OfferProvider offerProvider)
        {
            _controller = new OfferController(_view, offerProvider);
        }
    }
}
