using System;
using System.ComponentModel.DataAnnotations;

namespace UKParliament.CodeTest.Domain
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; } = string.Empty;

        [Required]
        //Looking forward to .Net 6 DateOnly!!  The good times are coming!
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;

        [Required]
        [StringLength(25)]
        public string Address {  get; set; } = string.Empty;

        [Required]
        [StringLength(25)]
        public string FavouriteIceCream {  get; set; } = string.Empty;
    }
}