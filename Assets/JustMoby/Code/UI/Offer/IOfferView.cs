using System.Collections.Generic;
using JustMoby.Code.ContentProvider.Offer;
using UnityEngine.Events;

namespace JustMoby.Code.UI.Offer
{
    public interface IOfferView
    {
        public void Init(UnityEvent offerClickEvent);
        public void SetOfferData(OfferData offerData);
        public void SetOfferItems(List<OfferItemData> itemList);
        public void ToggleView(bool state);
    }
}
