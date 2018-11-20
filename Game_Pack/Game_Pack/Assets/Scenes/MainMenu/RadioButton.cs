using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButton {
	#region Variables
	/// <summary>
	/// The text button radio.
	/// </summary>
	private Text[] textBtnRadio;
	/// <summary>
	/// The color button selected.
	/// </summary>
	private Color colorBtnSelected;
	/// <summary>
	/// The color button unselected.
	/// </summary>
	private Color colorBtnUnselected;
	/// <summary>
	/// Initializes a new instance of the <see cref="RadioButton"/> class.
	/// </summary>
	/// <param name="textBtnRadio">Text button radio.</param>
	/// <param name="colorBtnSelected">Color button selected.</param>
	/// <param name="colorBtnUnselected">Color button unselected.</param>
	private Image[] imageBtnRadio;
	#endregion
	#region Constructor
	/// <summary>
	/// Initializes a new instance of the <see cref="RadioButton"/> class.
	/// </summary>
	/// <param name="textBtnRadio">Text button radio.</param>
	/// <param name="colorBtnSelected">Color button selected.</param>
	/// <param name="colorBtnUnselected">Color button unselected.</param>
	public RadioButton(Text[] textBtnRadio, Color colorBtnSelected, Color colorBtnUnselected)
	{
		this.textBtnRadio = textBtnRadio;
		this.colorBtnSelected = colorBtnSelected;
		this.colorBtnUnselected = colorBtnUnselected;
	}
	/// <summary>
	/// Initializes a new instance of the <see cref="RadioButton"/> class.
	/// </summary>
	/// <param name="imageBtnRadio">Image button radio.</param>
	/// <param name="colorBtnSelected">Color button selected.</param>
	/// <param name="colorBtnUnselected">Color button unselected.</param>
	public RadioButton(Image[] imageBtnRadio, Color colorBtnSelected, Color colorBtnUnselected)
	{
		this.imageBtnRadio = imageBtnRadio;
		this.colorBtnSelected = colorBtnSelected;
		this.colorBtnUnselected = colorBtnUnselected;
	}
	#endregion
	#region Events
	/// <summary>
	/// Changes the button.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void ChangeButton(int id)
	{
		UnSelectAll ();
		if (textBtnRadio != null) {
			textBtnRadio [id].color = colorBtnSelected;
		} else {
			imageBtnRadio [id].color = colorBtnSelected;
		}
	}
	/// <summary>
	/// Unselect all.
	/// </summary>
	private void UnSelectAll()
	{
		if (textBtnRadio != null) {
			for (int i = 0; i < textBtnRadio.Length; i++) {
				textBtnRadio [i].color = colorBtnUnselected;
			}
		} else {
			for (int i = 0; i < imageBtnRadio.Length; i++) {
				imageBtnRadio [i].color = colorBtnUnselected;
			}
		}
	}
	#endregion
}