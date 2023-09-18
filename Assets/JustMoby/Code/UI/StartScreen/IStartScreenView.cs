using JustMoby.Code.Message;
using UnityEngine.Events;

namespace JustMoby.Code.UI.StartScreen
{
    public interface IStartScreenView
    {
        void Init(UnityEvent<OfferWindowMessage> offerWindowMessageEvent, int defaultCount);
    }
}