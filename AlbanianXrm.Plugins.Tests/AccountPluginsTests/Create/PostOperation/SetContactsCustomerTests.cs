using AlbanianXrm.Plugins;
using AlbanianXrm.Plugins.AccountPlugins.Create.PostOperation;
using FakeItEasy;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Models;
using System;
using System.Linq;
using Xunit;

namespace AccountPluginsTests.Create.PostOperation
{
    public class SetContactsCustomerTests
    {
        [Fact]
        public void Created_Acconts_Should_Set_Primary_Contacts_Parent_Customer()
        {
            //Arrange
            var context = new XrmFakedContext();

            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = "Betim",
                LastName = "Beja"
            };
            context.Initialize(contact);

            var target = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "AlbanianXrm",
                PrimaryContactId = contact.ToEntityReference()
            };
            var pluginContext = context.GetDefaultPluginContext();
            pluginContext.InputParameters.Add(PluginBase.Target, target);

            //Act
            context.ExecutePluginWith<SetContactsCustomer>(pluginContext);

            //Assert
            var updatedContact = context.CreateQuery<Contact>().FirstOrDefault();         
            Assert.NotNull(updatedContact);
            Assert.NotNull(updatedContact.ParentCustomerId);
            Assert.Equal(target.Id, updatedContact.ParentCustomerId.Id);
        }
    }
}
