using System;
using System.ComponentModel.DataAnnotations;
namespace solarp.data.Models{
public class Product{

public int id { get; set; }
public DateTime CreatedOn { get; set; }
public DateTime UpdatedOn { get; set; }

[MaxLength(32)]
public string Name{get;set;}

[MaxLength(128)]
public string Description { get; set; }

public decimal Price{get;set;}









}
}