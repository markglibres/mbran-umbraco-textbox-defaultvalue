//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1062 with alias "hasMetaHeader"
	/// <summary>_HasMetaHeader</summary>
	public partial interface IHasMetaHeader : IPublishedContent
	{
		/// <summary>Description</summary>
		string MetaDescription { get; }

		/// <summary>Title</summary>
		string MetaTitle { get; }
	}

	/// <summary>_HasMetaHeader</summary>
	[PublishedContentModel("hasMetaHeader")]
	public partial class HasMetaHeader : PublishedContentModel, IHasMetaHeader
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "hasMetaHeader";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HasMetaHeader(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HasMetaHeader, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for Description</summary>
		public static string GetMetaDescription(IHasMetaHeader that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return GetMetaTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetMetaTitle(IHasMetaHeader that) { return that.GetPropertyValue<string>("metaTitle"); }
	}
}
