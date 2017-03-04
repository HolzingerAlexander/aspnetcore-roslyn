namespace Program
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;

    using DtoCreator;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    public class Program
    {
        public static void Main(string[] args)
        {
            #region File
            var testFile = @"
// --------------------------------------------------------------------------------------------------------------------
// <copyright file='Customer.cs' company=''>
// </copyright>
// <summary>
//   Defines the Customer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

            // ReSharper disable ClassWithVirtualMembersNeverInherited.Global
            // ReSharper disable UnusedMember.Global
            // ReSharper disable UnusedAutoPropertyAccessor.Global
    namespace EasySell.Models.CustomerModel
    {
        using System;
        using System.Collections.Generic;

        using EasySell.Models.Common;
        using EasySell.Models.IntersectionTables;
        using EasySell.Models.OpportunityModel;
        using ContactPersonModel;
        using AccountManagerModel;

        /// <summary>
        /// TODO The customer.
        /// </summary>
        public class Customer
        {
            /// <summary>
            /// Gets or sets the id.
            /// </summary>
            /// <value>
            /// TODO The id.
            /// </value>
            public int Id { get; set; }

            /// <summary>
            /// Gets or sets the international name.
            /// </summary>
            /// <value>
            /// TODO The international name.
            /// </value>
            public string InternationalName { get; set; }

            /// <summary>
            /// Gets or sets the local name.
            /// </summary>
            /// <value>
            /// TODO The local name.
            /// </value>
            public string LocalName { get; set; }

            /// <summary>
            /// Gets or sets the synonym name.
            /// </summary>
            /// <value>
            /// TODO The synonym name.
            /// </value>
            public string SynonymName { get; set; }

            /// <summary>
            /// Gets or sets the languages.
            /// </summary>
            /// <value>
            /// TODO The languages.
            /// </value>
            public virtual ICollection<CustomerLanguage> Languages { get; set; }

            /// <summary>
            /// Gets or sets the head office id.
            /// </summary>
            /// <value>
            /// TODO The head office id.
            /// </value>
            public int? HeadOfficeId { get; set; }

            /// <summary>
            /// Gets or sets the head office.
            /// </summary>
            /// <value>
            /// TODO The head office.
            /// </value>
            public Address HeadOffice { get; set; }

            /// <summary>
            /// Gets or sets the offices.
            /// </summary>
            /// <value>
            /// TODO The offices.
            /// </value>
            public virtual ICollection<Address> Offices { get; set; }

            /// <summary>
            /// Gets or sets the regions.
            /// </summary>
            /// <value>
            /// TODO The regions.
            /// </value>
            public virtual ICollection<CustomerCustomRegion> Regions { get; set; }

            /// <summary>
            /// Gets or sets the phone numbers.
            /// </summary>
            /// <value>
            /// TODO The phone numbers.
            /// </value>
            public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

            /// <summary>
            /// Gets or sets the email addresses.
            /// </summary>
            /// <value>
            /// TODO The email addresses.
            /// </value>
            public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

            /// <summary>
            /// Gets or sets the website.
            /// </summary>
            /// <value>
            /// TODO The website.
            /// </value>
            public string Website { get; set; }

            /// <summary>
            /// Gets or sets the vat number.
            /// </summary>
            /// <value>
            /// TODO The vat number.
            /// </value>
            public string VatNumber { get; set; }

            /// <summary>
            /// Gets or sets the customer type id.
            /// </summary>
            /// <value>
            /// TODO The customer type id.
            /// </value>
            public int? CustomerTypeId { get; set; }

            /// <summary>
            /// Gets or sets the customer type.
            /// </summary>
            /// <value>
            /// TODO The customer type.
            /// </value>
            public CompanyType CustomerType { get; set; }

            /// <summary>
            /// Gets or sets the social media pages.
            /// </summary>
            /// <value>
            /// TODO The social media pages.
            /// </value>
            public virtual ICollection<SocialMediaAccount> SocialMediaPages { get; set; }

            /// <summary>
            /// Gets or sets the sectors.
            /// </summary>
            /// <value>
            /// TODO The sectors.
            /// </value>
            public virtual ICollection<CustomerSector> Sectors { get; set; }

            /// <summary>
            /// Gets or sets the customer priority id.
            /// </summary>
            /// <value>
            /// TODO The customer priority id.
            /// </value>
            public int? CustomerPriorityId { get; set; }

            /// <summary>
            /// Gets or sets the priority.
            /// </summary>
            /// <value>
            /// TODO The priority.
            /// </value>
            public CustomerPriority Priority { get; set; }

            /// <summary>
            /// Gets or sets the customer since.
            /// </summary>
            /// <value>
            /// TODO The customer since.
            /// </value>
            public DateTime? CustomerSince { get; set; }

            /// <summary>
            /// Gets or sets the is friendly customer.
            /// </summary>
            /// <value>
            /// TODO The is friendly customer.
            /// </value>
            public bool? IsFriendlyCustomer { get; set; }

            /// <summary>
            /// Gets or sets the additional info.
            /// </summary>
            /// <value>
            /// TODO The additional info.
            /// </value>
            public string AdditionalInfo { get; set; }

            /// <summary>
            /// Gets or sets the employees.
            /// </summary>
            /// <value>
            /// TODO The employees.
            /// </value>
            public virtual ICollection<CustomerContactPerson> Employees { get; set; }

            /// <summary>
            /// Gets or sets the account managers.
            /// </summary>
            /// <value>
            /// TODO The account managers.
            /// </value>
            public ICollection<AccountManagerCustomer> AccountManagers { get; set; }

            /// <summary>
            /// Gets or sets the parent id.
            /// </summary>
            /// <value>
            /// TODO The parent id.
            /// </value>
            public int? ParentId { get; set; }

            /// <summary>
            /// Gets or sets the parent.
            /// </summary>
            /// <value>
            /// TODO The parent.
            /// </value>
            public virtual Customer Parent { get; set; }

            /// <summary>
            /// Gets or sets the children.
            /// </summary>
            /// <value>
            /// TODO The children.
            /// </value>
            public virtual ICollection<Customer> Children { get; set; }

            /// <summary>
            /// Gets or sets the opportunities.
            /// </summary>
            /// <value>
            /// TODO The opportunities.
            /// </value>
            public virtual ICollection<Opportunity> Opportunities { get; set; }


            /// <summary>
            /// Adds a employee to the customer.
            /// </summary>
            /// <param name='contactPerson'>
            /// The ContactPerson(employee).
            /// </param>
            /// <returns>
            /// The <see cref='CustomerContactPerson'/>.
            /// </returns>
            public CustomerContactPerson AddEmployee(ContactPerson contactPerson)
                => new CrmContext().CustomersContactPersons.Add(
                    new CustomerContactPerson()
                    {
                        ContactPerson = contactPerson,
                        Customer = this
                    }).Entity;

            /// <summary>
            /// Adds an AccountManager to the Customer.
            /// </summary>
            /// <param name='accountManager'>
            /// The AccountManager.
            /// </param>
            /// <returns>
            /// The <see cref='AccountManagerCustomer'/>.
            /// </returns>
            public AccountManagerCustomer AddAccountManager(AccountManager accountManager)
                => new CrmContext().AccountManagersCustomers.Add(
                    new AccountManagerCustomer()
                    {
                        AccountManager = accountManager,
                        Customer = this
                    }).Entity;

            /// <summary>
            /// Adds a Sector to the customer.
            /// </summary>
            /// <param name='sector'>
            /// The sector.
            /// </param>
            public CustomerSector AddSector(Sector sector)
                => new CrmContext().CustomersSectors.Add(
                    new CustomerSector()
                    {
                        Customer = this,
                        Sector = sector
                    }).Entity;

            /// <summary>
            /// Creates a new SocialMediaAccount and adds it to the Customer.
            /// </summary>
            /// <param name='socialMediaPlatform'>
            /// The SocialMediaPlatform.
            /// </param>
            /// <param name='customPart'>
            /// The custom part of the URL
            /// </param>
            public SocialMediaAccount AddSocialMediaAccount(SocialMediaPlatform socialMediaPlatform, string customPart)
                => new CrmContext().SocialMediaAccounts.Add(
                    new SocialMediaAccount()
                    {
                        SocialMediaPlatform = socialMediaPlatform,
                        CustomPart = customPart,
                        Customer = this
                    }).Entity;

            /// <summary>
            /// Creates a new email address and adds it to the Customer.
            /// </summary>
            /// <param name='emailAddress'>
            /// The email address.
            /// </param>
            /// <param name='additionalInfo'>
            /// Additional information.
            /// </param>
            /// <param name='type'>
            /// THe type of the EmailAddress.
            /// </param>
            public EmailAddress AddEmailAddress(string emailAddress, string additionalInfo = null, EmailAddressType type = null)
                => new CrmContext().EmailAddresses.Add(
                    new EmailAddress()
                    {
                        Address = emailAddress,
                        AddressType = type,
                        AdditionalInfo = additionalInfo,
                        Customer = this
                    }).Entity;

            /// <summary>
            /// Creates a new PhoneNumber and adds it to the Customer.
            /// </summary>
            /// <param name='number'>
            /// The phone number.
            /// </param>
            /// <param name='type'>
            /// The type of phone number.
            /// </param>
            /// <param name='additionalInfo'>
            /// Additional information.
            /// </param>
            public PhoneNumber AddPhoneNumber(string number, PhoneNumberType type = null, string additionalInfo = null)
                => new CrmContext().PhoneNumbers.Add(
                    new PhoneNumber()
                    {
                        Number = number,
                        Type = type,
                        AdditionalInfo = additionalInfo,
                        Customer = this
                    }).Entity;

            /// <summary>
            /// Adds a Language to the Customers Language.
            /// </summary>
            /// <param name='lang'>
            /// The language to be added
            /// </param>
            public CustomerLanguage AddLanguage(Language lang)
                => new CrmContext().CustomersLanguages.Add(
                    new CustomerLanguage()
                    {
                        Language = lang,
                        Customer = this
                    }).Entity;

            /// <summary>
            /// Adds a new office address to the Customer.
            /// </summary>
            /// <param name='country'>
            /// The country of the Address.
            /// </param>
            /// <param name='province'>
            /// The province of the Address.
            /// </param>
            /// <param name='city'>
            /// The city of the Address.
            /// </param>
            /// <param name='streetAddress'>
            /// The street address.
            /// </param>
            /// <param name='postalCode'>
            /// The postal code of the Address.
            /// </param>
            public Address AddOffice(string country, string province, string city, string streetAddress, string postalCode)
                =>
                    new CrmContext().Addresses.Add(
                        new Address()
                        {
                            Country = country,
                            Province = province,
                            City = city,
                            StreetAddress = streetAddress,
                            PostalCode = postalCode
                        }).Entity;

            /// <summary>
            /// Adds a Region to the Customer.
            /// </summary>
            /// <param name='region'>
            /// TODO The region.
            /// </param>
            public CustomerCustomRegion AddRegion(CustomRegion region)
                => new CrmContext().CustomersCustomRegions.Add(
                    new CustomerCustomRegion()
                    {
                        Customer = this,
                        Region = region
                    }).Entity;
        }
    }
";
            #endregion

            var tree = CSharpSyntaxTree.ParseText(testFile);

            bool PropertyValid(PropertyDeclarationSyntax prop)
            {
                var prohibitedNames = new List<string> {"HeadOffice"};
                var prohibitedTokens = new List<string> {"virtual", "private"};
                
                var nodes = prop.DescendantNodes();
                var keywords = prop.DescendantTokens().OfType<SyntaxToken>();

                if (keywords.Any(token => prohibitedTokens.Any(name => token.Text == name)))
                {
                    return false;
                }

                if (prop.Identifier.Text.EndsWith("Id") 
                    && prop.DescendantNodes().OfType<NullableTypeSyntax>().Any())
                {
                    return false;
                }

                return true;
            }

            var dtoCreator = new DtoCreator(tree, PropertyValid, "Test.DTO", "CustomerDto");

            var dto = dtoCreator.CreateDto();

            Console.WriteLine(dto);
        }
    }
}
