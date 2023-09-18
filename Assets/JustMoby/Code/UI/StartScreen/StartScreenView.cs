using JustMoby.Code.Message;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace JustMoby.Code.UI.StartScreen
{
    public class StartScreenView : MonoBehaviour, IStartScreenView
    {
        [SerializeField] private Button startButton;
        [SerializeField] private TMP_InputField inputFieldCount;
        private UnityEvent<OfferWindowMessage> _offerWindowMessageEvent;
        
        public void Init(UnityEvent<OfferWindowMessage> offerWindowMessageEvent,int defaultCount)
        {
            _offerWindowMessageEvent = offerWindowMessageEvent;
            startButton.onClick.AddListener(OnStartButtonClick);
            inputFieldCount.text = defaultCount.ToString();
        }

        private void OnStartButtonClick()
        {
            int minCount = int.TryParse(inputFieldCount.text, out minCount) ? minCount : 3;
            
            _offerWindowMessageEvent?.Invoke(new OfferWindowMessage
            {
                count = minCount
            });
            
            gameObject.SetActive(false);
        }
    }
}