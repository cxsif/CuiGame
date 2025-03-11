
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgCardViewComponent : Entity,IAwake,IDestroy 
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

		public UnityEngine.UI.Toggle E_SoliderToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SoliderToggle == null )
     			{
		    		this.m_E_SoliderToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"BackGround/E_TopButton/E_Solider");
     			}
     			return this.m_E_SoliderToggle;
     		}
     	}

		public UnityEngine.UI.Toggle E_MonkToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MonkToggle == null )
     			{
		    		this.m_E_MonkToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"BackGround/E_TopButton/E_Monk");
     			}
     			return this.m_E_MonkToggle;
     		}
     	}

		public UnityEngine.UI.Toggle E_AssistantToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AssistantToggle == null )
     			{
		    		this.m_E_AssistantToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"BackGround/E_TopButton/E_Assistant");
     			}
     			return this.m_E_AssistantToggle;
     		}
     	}

		public UnityEngine.UI.Toggle E_ShooterToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ShooterToggle == null )
     			{
		    		this.m_E_ShooterToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"BackGround/E_TopButton/E_Shooter");
     			}
     			return this.m_E_ShooterToggle;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect E_BagItemsLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BagItemsLoopVerticalScrollRect == null )
     			{
		    		this.m_E_BagItemsLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"BackGround/ContentBackGround/E_BagItems");
     			}
     			return this.m_E_BagItemsLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Image E_QualityImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QualityImage == null )
     			{
		    		this.m_E_QualityImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGround/ContentBackGround/E_BagItems/Content/Item_cardItem/E_Quality");
     			}
     			return this.m_E_QualityImage;
     		}
     	}

		public UnityEngine.UI.Image E_IconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IconImage == null )
     			{
		    		this.m_E_IconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGround/ContentBackGround/E_BagItems/Content/Item_cardItem/E_Icon");
     			}
     			return this.m_E_IconImage;
     		}
     	}

		public UnityEngine.UI.Button E_SelectButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SelectButton == null )
     			{
		    		this.m_E_SelectButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGround/ContentBackGround/E_BagItems/Content/Item_cardItem/E_Select");
     			}
     			return this.m_E_SelectButton;
     		}
     	}

		public UnityEngine.UI.Image E_SelectImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SelectImage == null )
     			{
		    		this.m_E_SelectImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGround/ContentBackGround/E_BagItems/Content/Item_cardItem/E_Select");
     			}
     			return this.m_E_SelectImage;
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

		public UnityEngine.UI.Button E_PreviousButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreviousButton == null )
     			{
		    		this.m_E_PreviousButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGround/Bottom/E_Previous");
     			}
     			return this.m_E_PreviousButton;
     		}
     	}

		public UnityEngine.UI.Image E_PreviousImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreviousImage == null )
     			{
		    		this.m_E_PreviousImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGround/Bottom/E_Previous");
     			}
     			return this.m_E_PreviousImage;
     		}
     	}

		public UnityEngine.UI.Text E_PageText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PageText == null )
     			{
		    		this.m_E_PageText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"BackGround/Bottom/E_Page");
     			}
     			return this.m_E_PageText;
     		}
     	}

		public UnityEngine.UI.Button E_NextButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextButton == null )
     			{
		    		this.m_E_NextButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGround/Bottom/E_Next");
     			}
     			return this.m_E_NextButton;
     		}
     	}

		public UnityEngine.UI.Image E_NextImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextImage == null )
     			{
		    		this.m_E_NextImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGround/Bottom/E_Next");
     			}
     			return this.m_E_NextImage;
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
			this.m_E_SoliderToggle = null;
			this.m_E_MonkToggle = null;
			this.m_E_AssistantToggle = null;
			this.m_E_ShooterToggle = null;
			this.m_E_BagItemsLoopVerticalScrollRect = null;
			this.m_E_QualityImage = null;
			this.m_E_IconImage = null;
			this.m_E_SelectButton = null;
			this.m_E_SelectImage = null;
			this.m_E_CloseButton = null;
			this.m_E_CloseImage = null;
			this.m_E_PreviousButton = null;
			this.m_E_PreviousImage = null;
			this.m_E_PageText = null;
			this.m_E_NextButton = null;
			this.m_E_NextImage = null;
			this.m_EG_ESItemInfoRootRectTransform = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.ToggleGroup m_E_TopButtonToggleGroup = null;
		private UnityEngine.UI.Toggle m_E_SoliderToggle = null;
		private UnityEngine.UI.Toggle m_E_MonkToggle = null;
		private UnityEngine.UI.Toggle m_E_AssistantToggle = null;
		private UnityEngine.UI.Toggle m_E_ShooterToggle = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_E_BagItemsLoopVerticalScrollRect = null;
		private UnityEngine.UI.Image m_E_QualityImage = null;
		private UnityEngine.UI.Image m_E_IconImage = null;
		private UnityEngine.UI.Button m_E_SelectButton = null;
		private UnityEngine.UI.Image m_E_SelectImage = null;
		private UnityEngine.UI.Button m_E_CloseButton = null;
		private UnityEngine.UI.Image m_E_CloseImage = null;
		private UnityEngine.UI.Button m_E_PreviousButton = null;
		private UnityEngine.UI.Image m_E_PreviousImage = null;
		private UnityEngine.UI.Text m_E_PageText = null;
		private UnityEngine.UI.Button m_E_NextButton = null;
		private UnityEngine.UI.Image m_E_NextImage = null;
		private UnityEngine.RectTransform m_EG_ESItemInfoRootRectTransform = null;
		public Transform uiTransform = null;
	}
}
