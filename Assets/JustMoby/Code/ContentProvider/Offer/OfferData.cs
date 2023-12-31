using System;
using System.Collections.Generic;
using UnityEngine;

namespace JustMoby.Code.ContentProvider.Offer
{
    [Serializable]
    public class OfferData
    {
        public string offerId;
        public string offerHeader;
        public string offerDescription;
        public float defaultPrice;
        public float defaultDiscount;
        public bool hasDiscount;
        public Sprite sprite;
        
        public List<OfferItemData> offerItemList;

        public List<OfferItemData> GetItemRange(int num)
        {
            return offerItemList.GetRange(0, num <= offerItemList.Count ? num : offerItemList.Count);
        }
    }
}
