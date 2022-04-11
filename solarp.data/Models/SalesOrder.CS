using System;
using System.ComponentModel.DataAnnotations;
namespace solarp.data.Models{
public class SalesOrder{

public int id { get; set; }
public DateTime CreatedOn { get; set; }
public DateTime UpdatedOn { get; set; }

public List<SalesOrderItem> Orders{get;set;}
public Customer Customer{get;set;}
public bool isPaid{get;set;}







}
}