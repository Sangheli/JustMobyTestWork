using System.Collections.Generic;
using JustMoby.Code.ContentProvider.Offer;

namespace JustMoby.Code.UI.Offer
{
    public interface IOfferView
    {
        public void SetOfferData(OfferData offerData);
        public void SetOfferItems(List<OfferItemData> itemList);
    }
}
