
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgRewardViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.LoopVerticalScrollRect E_CardItemsLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CardItemsLoopVerticalScrollRect == null )
     			{
		    		this.m_E_CardItemsLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"BackGround/ContentBackGround/E_CardItems");
     			}
     			return this.m_E_CardItemsLoopVerticalScrollRect;
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

		public UnityEngine.UI.Text E_TimerText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TimerText == null )
     			{
		    		this.m_E_TimerText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Timer");
     			}
     			return this.m_E_TimerText;
     		}
     	}

		public UnityEngine.UI.Button E_QuitButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QuitButton == null )
     			{
		    		this.m_E_QuitButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Quit");
     			}
     			return this.m_E_QuitButton;
     		}
     	}

		public UnityEngine.UI.Image E_QuitImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QuitImage == null )
     			{
		    		this.m_E_QuitImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Quit");
     			}
     			return this.m_E_QuitImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_CardItemsLoopVerticalScrollRect = null;
			this.m_E_CloseButton = null;
			this.m_E_CloseImage = null;
			this.m_EG_ESItemInfoRootRectTransform = null;
			this.m_E_TimerText = null;
			this.m_E_QuitButton = null;
			this.m_E_QuitImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.LoopVerticalScrollRect m_E_CardItemsLoopVerticalScrollRect = null;
		private UnityEngine.UI.Button m_E_CloseButton = null;
		private UnityEngine.UI.Image m_E_CloseImage = null;
		private UnityEngine.RectTransform m_EG_ESItemInfoRootRectTransform = null;
		private UnityEngine.UI.Text m_E_TimerText = null;
		private UnityEngine.UI.Button m_E_QuitButton = null;
		private UnityEngine.UI.Image m_E_QuitImage = null;
		public Transform uiTransform = null;
	}
}
