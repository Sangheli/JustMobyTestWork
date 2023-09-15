using JustMoby.Code.ContentProvider.Offer;

namespace JustMoby.Code.UI.Offer
{
    public class OfferController
    {
        private readonly OfferProvider _offerProvider;
        private readonly IOfferView _view;
        private string offerId = "offer1";
        
        public OfferController(IOfferView view, OfferProvider offerProvider)
        {
            _offerProvider = offerProvider;
            _view = view;
            Init();
        }

        private void Init()
        {
            var offer = _offerProvider.GetById(offerId);
            var items = offer.GetItemRange(4);
            
            _view.SetOfferData(offer);
            _view.SetOfferItems(items);
        }
    }
}