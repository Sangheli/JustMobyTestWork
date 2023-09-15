using System;
using UnityEngine;

namespace JustMoby.Code.ContentProvider.Offer
{
    [CreateAssetMenu(menuName = "JustMoby/OfferProvider",fileName = "OfferProvider")]
    public class OfferProvider : ScriptableObject
    {
        public OfferData[] offerDataArr;

        public OfferData GetById(string offerId)
        {
            foreach (var t in offerDataArr)
                if (t.offerId == offerId) return t;

            throw new Exception($"OfferProvider hos no item: {offerId}");
        }
    }
}
