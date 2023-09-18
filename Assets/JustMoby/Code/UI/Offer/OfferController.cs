using JustMoby.Code.ContentProvider.Offer;
using JustMoby.Code.Message;
using UnityEngine;
using UnityEngine.Events;

namespace JustMoby.Code.UI.Offer
{
    public class OfferController
    {
        private readonly OfferProvider _offerProvider;
        private readonly IOfferView _view;
        private readonly UnityEvent _offerClickEvent;
        private UnityEvent<OfferWindowMessage> _offerWindowMessageEvent;
        
        private string offerId = "offer1";
        
        public OfferController(IOfferView view, OfferProvider offerProvider,UnityEvent offerClickEvent,UnityEvent<OfferWindowMessage> offerWindowMessageEvent)
        {
            _offerProvider = offerProvider;
            _view = view;
            _offerClickEvent = offerClickEvent;
            _offerWindowMessageEvent = offerWindowMessageEvent;
            
            _offerWindowMessageEvent.AddListener(InitView);
            _offerClickEvent.AddListener(OnOfferClick);
        }

        private void InitView(OfferWindowMessage offerWindowMessage)
        {
            var offer = _offerProvider.GetById(offerId);
            var items = offer.GetItemRange(offerWindowMessage.count);
            
            _view.SetOfferData(offer);
            _view.SetOfferItems(items);

            _view.ToggleView(true);
        }

        private void OnOfferClick()
        {
            Debug.Log("Offer clicked");
        }
    }
}