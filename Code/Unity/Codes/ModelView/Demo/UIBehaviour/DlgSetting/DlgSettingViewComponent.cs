
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgSettingViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.ToggleGroup E_TopButtonToggleGroup
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TopButtonToggleGroup == null )
     			{
		    		this.m_E_TopButtonToggleGroup = UIFindHelper.FindDeepChild<UnityEngine.UI.ToggleGroup>(this.uiTransform.gameObject,"BackGround/E_TopButton");
     			}
     			return this.m_E_TopButtonToggleGroup;
     		}
     	}

		public UnityEngine.UI.Toggle E_ChineseToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ChineseToggle == null )
     			{
		    		this.m_E_ChineseToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"BackGround/E_TopButton/E_Chinese");
     			}
     			return this.m_E_ChineseToggle;
     		}
     	}

		public UnityEngine.UI.Toggle E_EnglishToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_EnglishToggle == null )
     			{
		    		this.m_E_EnglishToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"BackGround/E_TopButton/E_English");
     			}
     			return this.m_E_EnglishToggle;
     		}
     	}

		public UnityEngine.UI.Button E_CloseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CloseButton == null )
     			{
		    		this.m_E_CloseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGround/E_Close");
     			}
     			return this.m_E_CloseButton;
     		}
     	}

		public UnityEngine.UI.Image E_CloseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CloseImage == null )
     			{
		    		this.m_E_CloseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGround/E_Close");
     			}
     			return this.m_E_CloseImage;
     		}
     	}

		public UnityEngine.UI.Slider E_SliderSlider
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SliderSlider == null )
     			{
		    		this.m_E_SliderSlider = UIFindHelper.FindDeepChild<UnityEngine.UI.Slider>(this.uiTransform.gameObject,"BackGround/E_Slider");
     			}
     			return this.m_E_SliderSlider;
     		}
     	}

		public UnityEngine.RectTransform EG_ESItemInfoRootRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EG_ESItemInfoRootRectTransform == null )
     			{
		    		this.m_EG_ESItemInfoRootRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EG_ESItemInfoRoot");
     			}
     			return this.m_EG_ESItemInfoRootRectTransform;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_TopButtonToggleGroup = null;
			this.m_E_ChineseToggle = null;
			this.m_E_EnglishToggle = null;
			this.m_E_CloseButton = null;
			this.m_E_CloseImage = null;
			this.m_E_SliderSlider = null;
			this.m_EG_ESItemInfoRootRectTransform = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.ToggleGroup m_E_TopButtonToggleGroup = null;
		private UnityEngine.UI.Toggle m_E_ChineseToggle = null;
		private UnityEngine.UI.Toggle m_E_EnglishToggle = null;
		private UnityEngine.UI.Button m_E_CloseButton = null;
		private UnityEngine.UI.Image m_E_CloseImage = null;
		private UnityEngine.UI.Slider m_E_SliderSlider = null;
		private UnityEngine.RectTransform m_EG_ESItemInfoRootRectTransform = null;
		public Transform uiTransform = null;
	}
}
