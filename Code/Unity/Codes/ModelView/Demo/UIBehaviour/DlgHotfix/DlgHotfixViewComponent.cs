
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgHotfixViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_HotfixButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_HotfixButton == null )
     			{
		    		this.m_E_HotfixButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Sprite_BackGround/E_Hotfix");
     			}
     			return this.m_E_HotfixButton;
     		}
     	}

		public UnityEngine.UI.Image E_HotfixImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_HotfixImage == null )
     			{
		    		this.m_E_HotfixImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Sprite_BackGround/E_Hotfix");
     			}
     			return this.m_E_HotfixImage;
     		}
     	}

		public UnityEngine.UI.Button E_ClearButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ClearButton == null )
     			{
		    		this.m_E_ClearButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Sprite_BackGround/E_Clear");
     			}
     			return this.m_E_ClearButton;
     		}
     	}

		public UnityEngine.UI.Image E_ClearImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ClearImage == null )
     			{
		    		this.m_E_ClearImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Sprite_BackGround/E_Clear");
     			}
     			return this.m_E_ClearImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_Text == null )
     			{
		    		this.m_ELabel_Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Sprite_BackGround/ELabel_");
     			}
     			return this.m_ELabel_Text;
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
		    		this.m_E_SliderSlider = UIFindHelper.FindDeepChild<UnityEngine.UI.Slider>(this.uiTransform.gameObject,"Sprite_BackGround/E_Slider");
     			}
     			return this.m_E_SliderSlider;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_HotfixButton = null;
			this.m_E_HotfixImage = null;
			this.m_E_ClearButton = null;
			this.m_E_ClearImage = null;
			this.m_ELabel_Text = null;
			this.m_E_SliderSlider = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_HotfixButton = null;
		private UnityEngine.UI.Image m_E_HotfixImage = null;
		private UnityEngine.UI.Button m_E_ClearButton = null;
		private UnityEngine.UI.Image m_E_ClearImage = null;
		private UnityEngine.UI.Text m_ELabel_Text = null;
		private UnityEngine.UI.Slider m_E_SliderSlider = null;
		public Transform uiTransform = null;
	}
}
