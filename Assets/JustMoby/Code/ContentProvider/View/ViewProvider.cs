using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JustMoby.Code.ContentProvider.View
{
    [CreateAssetMenu(menuName = "JustMoby/ViewProvider",fileName = "ViewProvider")]
    public class ViewProvider : ScriptableObject
    {
        [SerializeField] private AssetReference _offerView;
        public AssetReference OfferView => _offerView;
        
        [SerializeField] private AssetReference _startScreenView;
        public AssetReference StartScreenView => _startScreenView;
    }
}
