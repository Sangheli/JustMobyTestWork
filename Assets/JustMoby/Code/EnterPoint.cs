using JustMoby.Code.ContentProvider.Offer;
using JustMoby.Code.ContentProvider.View;
using JustMoby.Code.UI.Offer;
using UnityEngine;

namespace JustMoby.Code
{
    public class EnterPoint : MonoBehaviour
    {
        [SerializeField] private Transform _uiRoot;
        [SerializeField] private OfferProvider _offerProvider;
        [SerializeField] private ViewProvider _viewProvider;

        private void Start()
        {
            var offerEntity = new OfferEntity(_uiRoot, _viewProvider, _offerProvider);
        }
    }
}
