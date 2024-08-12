using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class DataProvider
{

	public static Dictionary<string,BaseItem> GetBodyData ()
	{
		Dictionary<string,BaseItem> items = new Dictionary<string,BaseItem> ();

		items.Add ("1",new BaseItem ("01", "body1",BaseItem.CurrencyType.Default,0,false));
		items.Add ("2",new BaseItem ("02", "body2",BaseItem.CurrencyType.Default,0,false));
		items.Add ("3",new BaseItem ("03", "body3",BaseItem.CurrencyType.Default,0,false));
		items.Add ("4",new BaseItem ("04", "body4",BaseItem.CurrencyType.Default,0,false));
		items.Add ("5",new BaseItem ("05", "body5",BaseItem.CurrencyType.Default,0,false));
		items.Add ("6",new BaseItem ("06", "body6",BaseItem.CurrencyType.Default,0,false));

		return items;
	}

	public static Dictionary<string,BaseItem> GetEyesData ()
	{
		Dictionary<string,BaseItem> items = new Dictionary<string,BaseItem> ();

		items.Add ("1",new BaseItem ("01", "eyes1",BaseItem.CurrencyType.Default,0,false));
		items.Add ("2",new BaseItem ("02", "eyes2",BaseItem.CurrencyType.Default,0,false));
		items.Add ("3",new BaseItem ("03", "eyes3",BaseItem.CurrencyType.Default,0,false));
		items.Add ("4",new BaseItem ("04", "eyes4",BaseItem.CurrencyType.Default,0,false));
		items.Add ("5",new BaseItem ("05", "eyes5",BaseItem.CurrencyType.Default,0,false));
		items.Add ("6",new BaseItem ("06", "eyes6",BaseItem.CurrencyType.Default,0,false));

		return items;
	}

	public static Dictionary<string,BaseItem> GetFinsData ()
	{
		Dictionary<string,BaseItem> items = new Dictionary<string,BaseItem> ();

		items.Add ("1",new BaseItem ("01", "fins1",BaseItem.CurrencyType.Default,0,false));
		items.Add ("2",new BaseItem ("02", "fins2",BaseItem.CurrencyType.Default,0,false));
		items.Add ("3",new BaseItem ("03", "fins3",BaseItem.CurrencyType.Default,0,false));
		items.Add ("4",new BaseItem ("04", "fins4",BaseItem.CurrencyType.Default,0,false));
		items.Add ("5",new BaseItem ("05", "fins5",BaseItem.CurrencyType.Default,0,false));
		items.Add ("6",new BaseItem ("06", "fins6",BaseItem.CurrencyType.Default,0,false));

		return items;
	}

	public static Dictionary<string,BaseItem> GetHairsData ()
	{
		Dictionary<string,BaseItem> items = new Dictionary<string,BaseItem> ();

		items.Add ("1",new BaseItem ("01", "hairs1",BaseItem.CurrencyType.Default,0,false));
		items.Add ("2",new BaseItem ("02", "hairs2",BaseItem.CurrencyType.Default,0,false));
		items.Add ("3",new BaseItem ("03", "hairs3",BaseItem.CurrencyType.Default,0,false));
		items.Add ("4",new BaseItem ("04", "hairs4",BaseItem.CurrencyType.Default,0,false));
		items.Add ("5",new BaseItem ("05", "hairs5",BaseItem.CurrencyType.Default,0,false));
		items.Add ("6",new BaseItem ("06", "hairs6",BaseItem.CurrencyType.Default,0,false));

		return items;
	}

	public static Dictionary<string,BaseItem> GetTailsData ()
	{
		Dictionary<string,BaseItem> items = new Dictionary<string,BaseItem> ();

		items.Add ("1",new BaseItem ("01", "tail1",BaseItem.CurrencyType.Default,0,false));
		items.Add ("2",new BaseItem ("02", "tail2",BaseItem.CurrencyType.Default,0,false));
		items.Add ("3",new BaseItem ("03", "tail3",BaseItem.CurrencyType.Default,0,false));
		items.Add ("4",new BaseItem ("04", "tail4",BaseItem.CurrencyType.Default,0,false));
		items.Add ("5",new BaseItem ("05", "tail5",BaseItem.CurrencyType.Default,0,false));
		items.Add ("6",new BaseItem ("06", "tail6",BaseItem.CurrencyType.Default,0,false));

		return items;
	}
}

