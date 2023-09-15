using System.Collections.Generic;
using JustMoby.Code.ContentProvider.Offer;
using UnityEngine;
using UnityEngine.UI;

namespace JustMoby.Code.UI.Offer
{
    public class OfferView : MonoBehaviour, IOfferView
    {
        [SerializeField] private Image bigImage;
        
        [SerializeField] private Text headerText;
        [SerializeField] private Text infoText;
        
        [SerializeField] private Button buttonPrice;
        [SerializeField] private Text buttonPriceText;
        
        [SerializeField] private List<ItemView> _itemViews;

        private void Start()
        {
            buttonPrice.onClick.AddListener(() => { });
        }

        public void SetOfferData(OfferData data)
        {
            headerText.text = data.offerId;
            infoText.text = data.offerId;
            
            bigImage.sprite = data.sprite;
            buttonPriceText.text = data.defaultPrice.ToString();
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
