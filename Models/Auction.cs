/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 13.03.2015
 * Время: 8:45
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc2.Models
{
	/// <summary>
	/// Description of Auction.
	/// </summary>
	[Table("auction")]
	public class Auction
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id {get;set;}
		[Required]
		public string Title {get;set;}
		[Required]
		public string Description{get;set;}
		public string StartPrice{get;set;}
		public string EndTime{get;set;}
		
		public Auction()
		{
		}
	}
}
