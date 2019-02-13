using Main.Domain.UI;
using Main.UseCases.UI;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Main.Infrastructure.Controllers.Network
{
	public class UIController : MonoBehaviour
	{
		[FormerlySerializedAs("StartingView")] public View startingView;
		
		private ChangeCurrentView _changeCurrentView;


		[Inject]
		public void Init(ChangeCurrentView changeCurrentView)
		{
			_changeCurrentView = changeCurrentView;
		}

		public void Start()
		{
			_changeCurrentView.Change(startingView);
		}
	}
}
