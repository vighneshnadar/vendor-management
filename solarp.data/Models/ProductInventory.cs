using System;
using System.ComponentModel.DataAnnotations;
namespace solarp.data.Models{
public class ProductInventory{

public int id { get; set; }
public DateTime CreatedOn { get; set; }
public DateTime UpdatedOn { get; set; }

public int Quantity{get;set;}
public int IdealQuantity{get;set;}
public Product Product{get;set;}












}
}