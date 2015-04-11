/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 26.03.2015
 * Время: 11:02
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using mvc2.Models.Grids;
using mvc2.Models.References;

namespace mvc2.Models
{
	/// <summary>
	/// Description of Transport.
	/// </summary>
	
	[Table("transport")]
	public class Transport
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Display(Name = "Марка")]
		public int AutoModelId { get; set; }
		//public virtual  AutoModel  AutoModel { get; set; }
		[Display(Name = "Тип")]
		public int AutoTypeId { get; set; }
		//public virtual  AutoType  AutoType { get; set; }
		[Display(Name = "Количество машин")]
		public int AutosQuantity { get; set; }
		
		[Display(Name = "Госномера")]
		public virtual List<AutoNumber> AutoNumbers { get; set; }
		
		[Required(ErrorMessage="Требуется поле Телефон")]
		[Display(Name = "Телефон")]
		public string Tel { get; set; }
		
		[Display(Name = "Электронная почта")]
		[DataType(DataType.EmailAddress)]
        [StringLength(128)]
        [Required(ErrorMessage="Требуется поле Электронная почта") ]
      	[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage="Введенный имейл выглядит как ошибочный")]
		public string Email { get; set; }
		
		[Display(Name = "Дата")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }
		//список количество машин
		
		
		
		[NotMapped]
		public List<AutoType> AutoTypeList { get; set; }
		[NotMapped]
		public List<AutoModel> AutoModelList { get; set; }
				
		
		public SelectList getSelectedAutoTypeList(object selectedValue){
			
			return new SelectList(AutoTypeList,"Id","Name",selectedValue);
		}
		
		public SelectList getSelectedAutoModelList(object selectedValue){
	
			return  new SelectList(AutoModelList,"Id","Name",selectedValue);
		}
		
	
		
	}
}
