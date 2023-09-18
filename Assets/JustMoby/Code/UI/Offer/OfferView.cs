using System.Collections.Generic;
using JustMoby.Code.ContentProvider.Offer;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JustMoby.Code.UI.Offer
{
    public class OfferView : MonoBehaviour, IOfferView
    {
        [Header("offer image")]
        [SerializeField] private Image bigImage;
     
        [Header("info")]
        [SerializeField] private TMP_Text headerText;
        [SerializeField] private TMP_Text infoText;
        
        [Header("price")]
        [SerializeField] private Button buttonPrice;
        [SerializeField] private TMP_Text buttonPriceText;
        [SerializeField] private TMP_Text buttonPriceTextNoDiscount;

        [Header("discount")]
        [SerializeField] private Image discountImage;
        [SerializeField] private TMP_Text discountText;
        
        [Header("items")]
        [SerializeField] private List<ItemView> _itemViews;

        private void Start()
        {
            buttonPrice.onClick.AddListener(() => { });
        }

        public void SetOfferData(OfferData offerData)
        {
            headerText.text = offerData.offerHeader;
            infoText.text = offerData.offerDescription;
            
            bigImage.sprite = offerData.sprite;

            var newPrice = offerData.defaultPrice;
            if (offerData.hasDiscount) newPrice = newPrice * offerData.defaultDiscount / 100;
            
            buttonPriceText.text = $"${newPrice:0.00}";
            buttonPriceTextNoDiscount.text = $"<s>${offerData.defaultPrice:0.00}</s>";
            buttonPriceTextNoDiscount.gameObject.SetActive(offerData.hasDiscount);
            
            discountImage.gameObject.SetActive(offerData.hasDiscount);
            discountText.text = $"-{offerData.defaultDiscount}%";
        }

        public void SetOfferItems(List<OfferItemData> itemList)
        {
            var count = itemList.Count <= _itemViews.Count ? itemList.Count : _itemViews.Count; 
            
            for (var i = 0; i < count; i++)
            {
                if(!_itemViews[i].gameObject.activeSelf)
                    _itemViews[i].gameObject.SetActive(true);
                
                _itemViews[i].SetData(itemList[i]);
            }

            for (var i = itemList.Count; i < _itemViews.Count; i++)
            {
                if(_itemViews[i].gameObject.activeSelf)
                    _itemViews[i].gameObject.SetActive(false);
            }            
        }
    }
}
