using JustMoby.Code.ContentProvider.Offer;
using UnityEngine;
using UnityEngine.Events;

namespace JustMoby.Code.UI.Offer
{
    public class OfferController
    {
        private readonly OfferProvider _offerProvider;
        private readonly IOfferView _view;
        private readonly UnityEvent _offerClickEvent;
        private string offerId = "offer1";
        
        public OfferController(IOfferView view, OfferProvider offerProvider,UnityEvent offerClickEvent)
        {
            _offerProvider = offerProvider;
            _view = view;
            _offerClickEvent = offerClickEvent;
            
            Init();
            _offerClickEvent.AddListener(OnOfferClick);
        }

        private void Init()
        {
            var offer = _offerProvider.GetById(offerId);
            var items = offer.GetItemRange(4);
            
            _view.SetOfferData(offer);
            _view.SetOfferItems(items);
        }

        private void OnOfferClick()
        {
            Debug.Log("Offer clicked");
        }
    }
}