using System;
using System.ComponentModel.DataAnnotations;
namespace solarp.data.Models{


    public class CustomerAddress{

     
        public int id{get;set;}
        public DateTime createdOn{get;set;}
        public DateTime updatedOn{get;set;}

        [MaxLength(100)]
        public string Addressline1{get;set;}

        [MaxLength(100)]
        public string Addressline2{get;set;}

        [MaxLength(50)]
        public string City{get;set;}
        [MaxLength(50)]
        public string State{get;set;}
        [MaxLength(10)]
        public int Postalcode{get;set;}
        [MaxLength(40)]
        public string Country {get;set;}
        
    }
}