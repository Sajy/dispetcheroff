/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 05.04.2015
 * Время: 23:57
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using mvc2.Models.References;

namespace mvc2.Models.Grids
{
	/// <summary>
	/// Description of AutoNumbersSort.
	/// </summary>
	public class AutoNumbersSort
	{
		public List<AutoNumber> AutoNumbers { get; set; }
		
		public List<AutoType> AutoTypeList { get; set; }
	
		public List<AutoModel> AutoModelList { get; set; }
	
		
		public SelectList getSelectedAutoTypeList(object selectedValue){
			return new SelectList(AutoTypeList,"Id","Name",selectedValue);
		}
		
		public SelectList getSelectedAutoModelList(object selectedValue){
			return  new SelectList(AutoModelList,"Id","Name",selectedValue);
		}
		
		
	}
}
