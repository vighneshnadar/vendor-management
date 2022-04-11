using System;
using System.ComponentModel.DataAnnotations;
namespace solarp.data.Models{
public class ProductInventorySnapshot{

public int id { get; set; }
public DateTime UpdatedTime { get; set; }
public int Quantity { get; set; }
public Product Product{get;set;}












}
}