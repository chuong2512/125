using UnityEngine;
using System.Collections;

public class MyScrollView : MonoBehaviour {

	public float springStrength = 8.0f;
	
	private UIScrollView scrollView;
	private int elementsPerPage;
	private int currentScrolledElements;
	private Vector3 startingScrollPosition;
	
	private UIGrid grid;
	
	// Use this for initialization
	void Start () 
	{
		if (scrollView == null)
		{
			scrollView = NGUITools.FindInParents<UIScrollView>(gameObject);
			if (scrollView == null)
			{
				Debug.LogWarning(GetType() + " requires " + typeof(UIScrollView) + " object in order to work", this);
				enabled = false;
				return;
			}
			
			grid = this.GetComponent<UIGrid>();
			elementsPerPage = (int) (scrollView.panel.clipRange.z / grid.cellHeight);
			currentScrolledElements = 0;
			startingScrollPosition = scrollView.panel.cachedTransform.localPosition;
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	/// <summary>
	/// Scrolls until target position matches target panelAnchorPosition (may be the center of the panel, one of its sides, etc)
	/// </summary>	
	void MoveBy (Vector3 target)
	{
		if (scrollView != null && scrollView.panel != null)
		{
			// Spring the panel to this calculated position
			SpringPanel.Begin(scrollView.panel.cachedGameObject, startingScrollPosition - target, springStrength);
		}
	}
	
	
	public void NextPage()
	{
		if (scrollView != null && scrollView.panel != null)
		{
			currentScrolledElements += elementsPerPage;
			if (currentScrolledElements > (this.transform.childCount - elementsPerPage))
			{
				currentScrolledElements = (this.transform.childCount - elementsPerPage);
			}
			float nextScroll = grid.cellHeight * currentScrolledElements;
			Vector3 target = new Vector3(0.0f, -nextScroll, 0.0f);				
			MoveBy(target);
		}
	}
	
	public void PreviousPage()
	{
		if (scrollView != null && scrollView.panel != null)
		{
			currentScrolledElements -= elementsPerPage;
			if (currentScrolledElements < 0)
			{
				currentScrolledElements = 0;
			}
			float nextScroll = grid.cellHeight * currentScrolledElements;
			Vector3 target = new Vector3(0.0f, -nextScroll, 0.0f);				
			MoveBy(target);
		}
	}
	
}