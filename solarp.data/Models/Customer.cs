using System;
namespace solarp.data.Models{


    public class Customer{

        public int id {get;set;}
        public DateTime createdOn{get;set;}
        public DateTime updatedOn { get; set; }
        public string FirstName{get;set;}
        public string LastName { get; set; }
    }
}