using UnityEngine;
using UnityEngine.UI;

public class StorageManager : MonoBehaviour
{
	private StorageModel model;
	private StorageView view;
	private StorageController controller;

	public Text textUnits;
	public Text textNealyfull;

	public InputField inputFieldDelivery;

	void Start()
	{
		//model
		model = new StorageModel();

		//view
		view = new StorageView();
		view.SetModel(model);
		view.SetUITexts(textUnits, textNealyfull);
		view.Refresh ();

		//controller
		controller = new StorageController();
		controller.SetModel (model);
		controller.SetView (view);
		controller.SetInputFieldDelivery (inputFieldDelivery);
	}

	public void BUTTON_DeliveryOnclick()
	{
		controller.EVENT_Delivery ();
	}
}
