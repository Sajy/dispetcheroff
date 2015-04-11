/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 26.03.2015
 * Время: 18:18
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Linq;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;
using mvc2.Models;
using mvc2.Models.References;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of ContUtilsTrans.
	/// </summary>
	public class ContUtilsTrans
	{
		
		
		private const string Id="Id";
		private const string Name="Name";
		
		public enum DropDownListType {PopulateAutoType, PopulateAutoModel};
		
		
		private readonly TransportContext ds;

		public ContUtilsTrans(TransportContext ds)
		{
				this.ds=ds;
		}
		
		public  SelectList getListByType(DropDownListType t, AutoNumber model){
			object selectedProduct=null;
			switch (t){
				case DropDownListType.PopulateAutoType:
					if (model!=null)  selectedProduct=model.NumAutoTypeId;
					return new  SelectList(ds.AutoTypes.OrderBy(d => d.Name), Id, Name, selectedProduct);
				case DropDownListType.PopulateAutoModel:
					if (model!=null) selectedProduct=model.NumAutoTypeId;
					return new  SelectList(ds.AutoModels.OrderBy(v => v.Name), Id, Name, selectedProduct);
				
			}
			return null;
		}
		
	}
}
