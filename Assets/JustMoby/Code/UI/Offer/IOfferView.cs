using System.Collections.Generic;
using JustMoby.Code.ContentProvider.Offer;

namespace JustMoby.Code.UI.Offer
{
    public interface IOfferView
    {
        public void SetOfferData(OfferData data);
        public void SetOfferItems(List<OfferItemData> itemList);
    }
}
