using JustMoby.Code.ContentProvider.Offer;
using UnityEngine;
using UnityEngine.UI;

namespace JustMoby.Code.UI.Offer
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Text _countText;
        
        public void SetData(OfferItemData data)
        {
            _countText.text = data.defaultPrice.ToString();
            _image.sprite = data.sprite;
        }
    }
}
