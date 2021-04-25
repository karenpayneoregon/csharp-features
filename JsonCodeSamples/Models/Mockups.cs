using System.Collections.Generic;

namespace JsonCodeSamples.Models
{
    /// <summary>
    /// Place mocked ups here for testing serialize and deserializing objects
    /// </summary>
    public class Mockups
    {
        /// <summary>
        /// Single <see cref="ShippingInfo"/> mockup
        /// </summary>
        /// <returns><see cref="ShippingInfo"/></returns>
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
        /// <summary>
        /// Mocked list of <see cref="ShippingInfo"/>
        /// </summary>
        /// <returns><see cref="List&lt;ShippingInfo&gt;"/></returns>
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
        /// <summary>
        /// Mocked list of <see cref="ShippingInfo"/> with nested properties
        /// </summary>
        /// <returns>Mocked list of &lt;see cref="ShippingInfo"/&gt;</returns>
        public static List<ShippingInfo> ShippingInfoNestedList() 
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
                    }, SomethingNested = new List<SomethingNested>()
                    {
                        new() {Id = 1, Value = "One"},
                        new() {Id = 2, Value = "Two"},
                        new() {Id = 3, Value = "Three"}
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
                    }, SomethingNested = new List<SomethingNested>()
                    {
                        new() {Id = 4, Value = "Four"},
                        new() {Id = 5, Value = "Five"}
                    }
                }
            };

            return list;
        }

    }

}