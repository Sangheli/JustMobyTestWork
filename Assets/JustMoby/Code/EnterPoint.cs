using JustMoby.Code.ContentProvider.Offer;
using JustMoby.Code.ContentProvider.View;
using JustMoby.Code.Message;
using JustMoby.Code.UI.Offer;
using JustMoby.Code.UI.StartScreen;
using UnityEngine;
using UnityEngine.Events;

namespace JustMoby.Code
{
    public class EnterPoint : MonoBehaviour
    {
        [SerializeField] private Transform _uiRoot;
        [SerializeField] private OfferProvider _offerProvider;
        [SerializeField] private ViewProvider _viewProvider;

        private readonly UnityEvent<OfferWindowMessage> _offerWindowMessageEvent = new UnityEvent<OfferWindowMessage>();

        private void Start()
        {
            var startScreenEntity = new StartScreenEntity(_uiRoot, _viewProvider,_offerWindowMessageEvent);
            var offerEntity = new OfferEntity(_uiRoot, _viewProvider, _offerProvider,_offerWindowMessageEvent);
        }
    }
}
