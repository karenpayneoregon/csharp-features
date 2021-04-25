using System.Collections.Generic;

namespace JsonCodeSamples.Models
{
    /// <summary>
    /// Place mocked ups here for testing serialize and deserializing objects
    /// </summary>
    public class Mockups
    {
        public static ShippingInfo singleShipInfo() => new()
        {
            firstname = "Jim", 
            lastname = "Adams", 
            gender = Gender.Male, 
            AddressDetails = new AddressDetails()
            {
                Street = "1 Maple Drive", 
                City = "Portland", 
                State = "OR", 
                PostalCode = "97666"
            }
        };

        public static List<ShippingInfo> ShippingInfoList()
        {
            var list = new List<ShippingInfo>
            {
                new()
                {
                    firstname = "Jim", 
                    lastname = "Adams", 
                    gender = Gender.Male, 
                    AddressDetails = new AddressDetails()
                    {
                        Street = "1 Maple Drive", 
                        City = "Portland", 
                        State = "OR", 
                        PostalCode = "97666"
                    }
                },
                new()
                {
                    firstname = "Mary", 
                    lastname = "Adams", 
                    gender = Gender.Female, 
                    AddressDetails = new AddressDetails()
                    {
                        Street = "1 Maple Drive", 
                        City = "Portland", 
                        State = "OR", 
                        PostalCode = "97666"
                    }
                }
            };

            return list;
        }     
    }
}