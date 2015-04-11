/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 01.04.2015
 * Время: 10:15
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc2.Helpers
{
	/// <summary>
	/// Description of CustomHelper.
	/// </summary>
	public static class CustomHelper
	{
		public static IHtmlString NoEcdActionLink(this HtmlHelper htmlHelper, string linkText, string action, string controller, object routeValues = null, object htmlAttributes = null)
		{
			TagBuilder builder;
			UrlHelper urlHelper;
			urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
			builder = new TagBuilder("a");
			builder.InnerHtml = linkText;
			builder.Attributes["href"] = urlHelper.Action(action, controller, routeValues);
			builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
			return MvcHtmlString.Create(builder.ToString());
		}
		
		internal static string ListItemToOption(SelectListItem item)
		{
			TagBuilder tagBuilder = new TagBuilder("option")
			{
				InnerHtml = HttpUtility.HtmlEncode(item.Text)
			};
			if (item.Value != null)
			{
				tagBuilder.Attributes["value"] = item.Value;
			}
			if (item.Selected)
			{
				tagBuilder.Attributes["selected"] = "selected";
			}
			return tagBuilder.ToString(TagRenderMode.Normal);
		}
		
		public static IHtmlString DropDownListCustom(this HtmlHelper htmlHelper,  string name, IEnumerable<SelectListItem> selectList,  IDictionary<string, object> htmlAttributes, 
		                                             string index, string pref,string fName)
		{
			string fullHtmlFieldName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
			
			StringBuilder stringBuilder = new StringBuilder();
			
			foreach (SelectListItem current in selectList) {
				stringBuilder.AppendLine(CustomHelper.ListItemToOption(current));
			}
			TagBuilder tagBuilder = new TagBuilder("select") {
				InnerHtml = stringBuilder.ToString()
			};
			tagBuilder.MergeAttributes<string, object>(htmlAttributes);
			tagBuilder.MergeAttribute("name", pref+"["+index+"]."+fName, true);
		
			tagBuilder.GenerateId(fullHtmlFieldName);
			
			ModelState modelState;
			if (htmlHelper.ViewData.ModelState.TryGetValue(fullHtmlFieldName, out modelState) && modelState.Errors.Count > 0) {
				tagBuilder.AddCssClass(HtmlHelper.ValidationInputCssClassName);
			}
			tagBuilder.MergeAttributes<string, object>(htmlHelper.GetUnobtrusiveValidationAttributes(name, null));
			return  MvcHtmlString.Create(tagBuilder.ToString());
		}
		
		

	}
}
