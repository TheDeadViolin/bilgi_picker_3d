using UnityEngine;
using Managers;
using Data.ValueObjects;
using Sirenix.OdinInspector;

namespace Controllers.Player
{
    public class PlayerMeshController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerManager manager;
        [SerializeField] private new Renderer renderer;

        #endregion

        #region Private Variables

        [ShowInInspector] private ScaleData _data;

        #endregion

        #endregion

        public void OnReset()
        {

        }

        public void GetMeshData(ScaleData scaleData)
        {
            _data = scaleData;
        }
    }
}
