﻿using System.ComponentModel.DataAnnotations;

namespace HAR.Service.ViewModels.Address
{
    public class AddressViewModel
    {
        [Required(ErrorMessage = "Идентификационния номер на адреса е задължителен.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Градът е задължителен")]
        public string City { get; set; }

        [Required(ErrorMessage = "Пощенския код е задължителен.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Кварталът е задължителен.")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "Улицата е задължителна.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Номер на улицата е задължителен.")]
        public string StreetNumber { get; set; }

        public string? BlockNumber { get; set; }

        public string? Entrance { get; set; }

        public int? Floor { get; set; }

        public string? Apartment { get; set; }
    }
}