using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc.Properties;
namespace System.Web.Mvc.Html
{
	/// <summary>Представляет поддержку выбора из списка.</summary>
	public static class SelectExtensions
	{
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML и имя поля формы.</summary>
		/// <returns>HTML-элемент select.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name)
		{
			return htmlHelper.DropDownList(name, null, null, null);
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы и метку варианта.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string optionLabel)
		{
			return htmlHelper.DropDownList(name, null, optionLabel, null);
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы и заданные элементы списка.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList)
		{
			return htmlHelper.DropDownList(name, selectList, null, null);
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы, элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, object htmlAttributes)
		{
			return htmlHelper.DropDownList(name, selectList, null, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы, элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
		{
			return htmlHelper.DropDownList(name, selectList, null, htmlAttributes);
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы, элементы списка и метку варианта.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, string optionLabel)
		{
			return htmlHelper.DropDownList(name, selectList, optionLabel, null);
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы, элементы списка, метку варианта и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, string optionLabel, object htmlAttributes)
		{
			return htmlHelper.DropDownList(name, selectList, optionLabel, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
		}
		/// <summary>Возвращает элемент select с единственным выбором, используя указанные вспомогательный метод HTML, имя поля формы, элементы списка, метку варианта и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
		{
			return SelectExtensions.DropDownListHelper(htmlHelper, null, name, selectList, optionLabel, htmlAttributes);
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList)
		{
			return htmlHelper.DropDownListFor(expression, selectList, null, null);
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
		{
			return htmlHelper.DropDownListFor(expression, selectList, null, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
		{
			return htmlHelper.DropDownListFor(expression, selectList, null, htmlAttributes);
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка и метку варианта.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel)
		{
			return htmlHelper.DropDownListFor(expression, selectList, optionLabel, null);
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка, метку варианта и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel, object htmlAttributes)
		{
			return htmlHelper.DropDownListFor(expression, selectList, optionLabel, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка, метку варианта и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="optionLabel">Текст для пустого элемента по умолчанию.Этот параметр может иметь значение null.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
		{
			if (expression == null)
			{
				throw new ArgumentNullException("expression");
			}
			ModelMetadata metadata = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
			return SelectExtensions.DropDownListHelper(htmlHelper, metadata, ExpressionHelper.GetExpressionText(expression), selectList, optionLabel, htmlAttributes);
		}
		private static MvcHtmlString DropDownListHelper(HtmlHelper htmlHelper, ModelMetadata metadata, string expression, IEnumerable<SelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
		{
			return htmlHelper.SelectInternal(metadata, optionLabel, expression, selectList, false, htmlAttributes);
		}
		/// <summary>Возвращает элемент select с множественным выбором, используя указанные вспомогательный метод HTML и имя поля формы.</summary>
		/// <returns>HTML-элемент select.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString ListBox(this HtmlHelper htmlHelper, string name)
		{
			return htmlHelper.ListBox(name, null, null);
		}
		/// <summary>Возвращает элемент select с множественным выбором, используя указанные вспомогательный метод HTML, имя поля формы и заданные элементы списка.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString ListBox(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList)
		{
			return htmlHelper.ListBox(name, selectList, null);
		}
		/// <summary>Возвращает элемент select с множественным выбором, используя указанные вспомогательный метод HTML, имя поля формы и заданные элементы списка.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString ListBox(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, object htmlAttributes)
		{
			return htmlHelper.ListBox(name, selectList, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
		}
		/// <summary>Возвращает элемент select с множественным выбором, используя указанные вспомогательный метод HTML, имя поля формы, элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select с подэлементом option для каждого элемента списка.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="name">Имя возвращаемого поля формы.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или пуст.</exception>
		public static MvcHtmlString ListBox(this HtmlHelper htmlHelper, string name, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
		{
			return SelectExtensions.ListBoxHelper(htmlHelper, null, name, selectList, htmlAttributes);
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип свойства.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList)
		{
			return htmlHelper.ListBoxFor(expression, selectList, null);
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип свойства.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
		{
			return htmlHelper.ListBoxFor(expression, selectList, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
		}
		/// <summary>Возвращает HTML-элемент select для каждого свойства объекта, представленного указанным выражением, используя указанные элементы списка и атрибуты HTML.</summary>
		/// <returns>HTML-элемент select для каждого свойства объекта, представленного выражением.</returns>
		/// <param name="htmlHelper">Экземпляр вспомогательного метода HTML, который расширяется данным методом.</param>
		/// <param name="expression">Выражение, которое определяет объект, содержащий свойства для отображения.</param>
		/// <param name="selectList">Коллекция объектов <see cref="T:System.Web.Mvc.SelectListItem" />, которые используются для заполнения раскрывающегося списка.</param>
		/// <param name="htmlAttributes">Объект, содержащий атрибуты HTML, которые следует задать для элемента.</param>
		/// <typeparam name="TModel">Тип модели.</typeparam>
		/// <typeparam name="TProperty">Тип свойства.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="expression" /> равен null.</exception>
		public static MvcHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
		{
			if (expression == null)
			{
				throw new ArgumentNullException("expression");
			}
			ModelMetadata metadata = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
			return SelectExtensions.ListBoxHelper(htmlHelper, metadata, ExpressionHelper.GetExpressionText(expression), selectList, htmlAttributes);
		}
		private static MvcHtmlString ListBoxHelper(HtmlHelper htmlHelper, ModelMetadata metadata, string name, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
		{
			return htmlHelper.SelectInternal(metadata, null, name, selectList, true, htmlAttributes);
		}
		private static IEnumerable<SelectListItem> GetSelectData(this HtmlHelper htmlHelper, string name)
		{
			object obj = null;
			if (htmlHelper.ViewData != null)
			{
				obj = htmlHelper.ViewData.Eval(name);
			}
			if (obj == null)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, MvcResources.HtmlHelper_MissingSelectData, new object[]
				{
					name,
					"IEnumerable<SelectListItem>"
				}));
			}
			IEnumerable<SelectListItem> enumerable = obj as IEnumerable<SelectListItem>;
			if (enumerable == null)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, MvcResources.HtmlHelper_WrongSelectDataType, new object[]
				{
					name,
					obj.GetType().FullName,
					"IEnumerable<SelectListItem>"
				}));
			}
			return enumerable;
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
		private static IEnumerable<SelectListItem> GetSelectListWithDefaultValue(IEnumerable<SelectListItem> selectList, object defaultValue, bool allowMultiple)
		{
			IEnumerable enumerable;
			if (allowMultiple)
			{
				enumerable = (defaultValue as IEnumerable);
				if (enumerable == null || enumerable is string)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, MvcResources.HtmlHelper_SelectExpressionNotEnumerable, new object[]
					{
						"expression"
					}));
				}
			}
			else
			{
				enumerable = new object[]
				{
					defaultValue
				};
			}
			IEnumerable<string> collection = 
				from object value in enumerable
				select Convert.ToString(value, CultureInfo.CurrentCulture);
			HashSet<string> hashSet = new HashSet<string>(collection, StringComparer.OrdinalIgnoreCase);
			List<SelectListItem> list = new List<SelectListItem>();
			foreach (SelectListItem current in selectList)
			{
				current.Selected = ((current.Value != null) ? hashSet.Contains(current.Value) : hashSet.Contains(current.Text));
				list.Add(current);
			}
			return list;
		}
		private static MvcHtmlString SelectInternal(this HtmlHelper htmlHelper, ModelMetadata metadata, string optionLabel, string name, IEnumerable<SelectListItem> selectList, bool allowMultiple, IDictionary<string, object> htmlAttributes)
		{
			string fullHtmlFieldName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
			if (string.IsNullOrEmpty(fullHtmlFieldName))
			{
				throw new ArgumentException(MvcResources.Common_NullOrEmpty, "name");
			}
			bool flag = false;
			if (selectList == null)
			{
				selectList = htmlHelper.GetSelectData(name);
				flag = true;
			}
			object obj = allowMultiple ? htmlHelper.GetModelStateValue(fullHtmlFieldName, typeof(string[])) : htmlHelper.GetModelStateValue(fullHtmlFieldName, typeof(string));
			if (!flag && obj == null && !string.IsNullOrEmpty(name))
			{
				obj = htmlHelper.ViewData.Eval(name);
			}
			if (obj != null)
			{
				selectList = SelectExtensions.GetSelectListWithDefaultValue(selectList, obj, allowMultiple);
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (optionLabel != null)
			{
				stringBuilder.AppendLine(SelectExtensions.ListItemToOption(new SelectListItem
				{
					Text = optionLabel,
					Value = string.Empty,
					Selected = false
				}));
			}
			foreach (SelectListItem current in selectList)
			{
				stringBuilder.AppendLine(SelectExtensions.ListItemToOption(current));
			}
			TagBuilder tagBuilder = new TagBuilder("select")
			{
				InnerHtml = stringBuilder.ToString()
			};
			tagBuilder.MergeAttributes<string, object>(htmlAttributes);
			tagBuilder.MergeAttribute("name", fullHtmlFieldName, true);
			tagBuilder.GenerateId(fullHtmlFieldName);
			if (allowMultiple)
			{
				tagBuilder.MergeAttribute("multiple", "multiple");
			}
			ModelState modelState;
			if (htmlHelper.ViewData.ModelState.TryGetValue(fullHtmlFieldName, out modelState) && modelState.Errors.Count > 0)
			{
				tagBuilder.AddCssClass(HtmlHelper.ValidationInputCssClassName);
			}
			tagBuilder.MergeAttributes<string, object>(htmlHelper.GetUnobtrusiveValidationAttributes(name, metadata));
			return tagBuilder.ToMvcHtmlString(TagRenderMode.Normal);
		}
	}
}
